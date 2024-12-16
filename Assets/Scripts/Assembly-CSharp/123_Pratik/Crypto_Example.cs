using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using System.Numerics;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

public class Crypto_Example : MonoBehaviour
{
    void Start()
    {
        ECDSASample(256);
    }

    private static void ECDSASample(int keySize)
    {
        string s = "Hello World";
        var key = GenerateKeys(keySize);
        var signature = GetSignature(s, key);
        var signatureOK = VerifySignature(key, s, signature);

        //Show it to me
        var pubicKey = (ECPublicKeyParameters)(key.Public);
        var privateKey = (ECPrivateKeyParameters)(key.Private);
        // BouncyCastle Big Int to hex fuckery
        string privKeyHex = (BigInteger.Parse(privateKey.D.ToString())).ToString("X");
        print("Input Text: " + s);
        print("Key " + privateKey.D.BitLength + " " + privateKey.D);
        print("Key Hex " + privKeyHex);
        print("Signature" + signature.Length + " " + ToString(signature));
        print("Signature" + signatureOK);
    }


    private static AsymmetricCipherKeyPair GenerateKeys(int keySize)
    {
        var gen = new ECKeyPairGenerator();
        var secureRandom = new SecureRandom();
        var keyGenParam = new KeyGenerationParameters(secureRandom, keySize);
        gen.Init(keyGenParam);

        return gen.GenerateKeyPair();
    }

    private static byte[] GetSignature(string plainText, AsymmetricCipherKeyPair key)
    {
        var encoder = new ASCIIEncoding();
        var inputData = encoder.GetBytes(plainText);

        var signer = SignerUtilities.GetSigner("ECDSA");
        signer.Init(true, key.Private);
        signer.BlockUpdate(inputData, 0, inputData.Length);

        return signer.GenerateSignature();
    }

    private static bool VerifySignature(AsymmetricCipherKeyPair key, string plainText, byte[] signature)
    {
        var encoder = new ASCIIEncoding();
        var inputData = encoder.GetBytes(plainText);

        var signer = SignerUtilities.GetSigner("ECDSA");
        signer.Init(false, key.Public);
        signer.BlockUpdate(inputData, 0, inputData.Length);

        return signer.VerifySignature(signature);
    }

    private static string ToString(IEnumerable<byte> b)
    {
        string o = string.Empty;
        foreach (byte b1 in b)
        {
            o += b1.ToString("X2");
        }
        return o;
    }
}