using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	public class Gost3410PublicKeyParameters : Gost3410KeyParameters
	{
		private readonly BigInteger y;

		public BigInteger Y => y;

		public Gost3410PublicKeyParameters(BigInteger y, Gost3410Parameters parameters)
			: base(isPrivate: false, parameters)
		{
			if (y.SignValue < 1 || y.CompareTo(base.Parameters.P) >= 0)
			{
				throw new ArgumentException("Invalid y for GOST3410 public key", "y");
			}
			this.y = y;
		}

		public Gost3410PublicKeyParameters(BigInteger y, DerObjectIdentifier publicKeyParamSet)
			: base(isPrivate: false, publicKeyParamSet)
		{
			if (y.SignValue < 1 || y.CompareTo(base.Parameters.P) >= 0)
			{
				throw new ArgumentException("Invalid y for GOST3410 public key", "y");
			}
			this.y = y;
		}
	}
}
