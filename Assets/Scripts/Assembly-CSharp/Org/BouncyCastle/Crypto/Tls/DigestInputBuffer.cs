using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	internal class DigestInputBuffer : MemoryStream
	{
		private class DigStream : BaseOutputStream
		{
			private readonly IDigest d;

			internal DigStream(IDigest d)
			{
				this.d = d;
			}

			public override void WriteByte(byte b)
			{
				d.Update(b);
			}

			public override void Write(byte[] buf, int off, int len)
			{
				d.BlockUpdate(buf, off, len);
			}
		}

		internal void UpdateDigest(IDigest d)
		{
			WriteTo(new DigStream(d));
		}
	}
}
