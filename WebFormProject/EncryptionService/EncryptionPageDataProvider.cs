using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Web;

namespace WebFormProject.EncryptionService
{
    public class EncryptionPageDataProvider
    {
        // Declare CspParmeters and RsaCryptoServiceProvider
        // objects with global scope of your Form class.
        readonly CspParameters _cspp = new CspParameters();
        RSACryptoServiceProvider _rsa;

        // Path variables for source, encryption, and
        // decryption folders. Must end with a backslash.
        const string EncrFolder = @"C:\Users\960134\source\Web Form Proj\WebFormProject\Encrypt\";
        const string DecrFolder = @"C:\Users\960134\source\Web Form Proj\WebFormProject\Decrypt\";
        const string SrcFolder = @"C:\Users\960134\source\Web Form Proj\WebFormProject\docs\";

        // Public key file
        const string PubKeyFile = @"C:\Users\960134\source\Web Form Proj\WebFormProject\Encrypt\rsaPublicKey.txt";

        // Key container name for
        // private/public key value pair.
        const string KeyName = "Key01";
    }
}