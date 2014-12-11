using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace suiteApp
{
    class RSA
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
        public byte[] kriptiranje(byte[] cistiTekst)
        {
            rsa.FromXmlString(LocalizedStrings.publicKey);
            byte[] rezultat = rsa.Encrypt(cistiTekst, false);
            return rezultat;
        }
    }
}
