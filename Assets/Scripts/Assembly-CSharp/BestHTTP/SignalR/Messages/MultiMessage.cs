using System;
using System.Collections;
using System.Collections.Generic;

namespace BestHTTP.SignalR.Messages
{
	public sealed class MultiMessage : IServerMessage
	{
		MessageTypes IServerMessage.Type => MessageTypes.Multiple;

		public string MessageId { get; private set; }

		public bool IsInitialization { get; private set; }

		public string GroupsToken { get; private set; }

		public bool ShouldReconnect { get; private set; }

		public TimeSpan? PollDelay { get; private set; }

		public List<IServerMessage> Data { get; private set; }

		void IServerMessage.Parse(object data)
		{
			IDictionary<string, object> dictionary = data as IDictionary<string, object>;
			MessageId = dictionary["C"].ToString();
			if (dictionary.TryGetValue("S", out var value))
			{
				IsInitialization = ((int.Parse(value.ToString()) == 1) ? true : false);
			}
			else
			{
				IsInitialization = false;
			}
			if (dictionary.TryGetValue("G", out value))
			{
				GroupsToken = value.ToString();
			}
			if (dictionary.TryGetValue("T", out value))
			{
				ShouldReconnect = ((int.Parse(value.ToString()) == 1) ? true : false);
			}
			else
			{
				ShouldReconnect = false;
			}
			if (dictionary.TryGetValue("L", out value))
			{
				PollDelay = TimeSpan.FromMilliseconds(double.Parse(value.ToString()));
			}
			IEnumerable enumerable = dictionary["M"] as IEnumerable;
			if (enumerable == null)
			{
				return;
			}
			Data = new List<IServerMessage>();
			IEnumerator enumerator = enumerable.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					IDictionary<string, object> dictionary2 = current as IDictionary<string, object>;
					IServerMessage serverMessage = null;
					serverMessage = ((dictionary2 == null) ? new DataMessage() : ((!dictionary2.ContainsKey("H")) ? ((!dictionary2.ContainsKey("I")) ? ((IServerMessage)new DataMessage()) : ((IServerMessage)new ProgressMessage())) : new MethodCallMessage()));
					serverMessage.Parse(current);
					Data.Add(serverMessage);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = enumerator as IDisposable) != null)
				{
					disposable.Dispose();
				}
			}
		}
	}
}
