using System.Collections.Generic;

namespace BestHTTP.SignalR.Messages
{
	public sealed class ProgressMessage : IServerMessage, IHubMessage
	{
		MessageTypes IServerMessage.Type => MessageTypes.Progress;

		public ulong InvocationId { get; private set; }

		public double Progress { get; private set; }

		void IServerMessage.Parse(object data)
		{
			IDictionary<string, object> dictionary = data as IDictionary<string, object>;
			IDictionary<string, object> dictionary2 = dictionary["P"] as IDictionary<string, object>;
			InvocationId = ulong.Parse(dictionary2["I"].ToString());
			Progress = double.Parse(dictionary2["D"].ToString());
		}
	}
}
