using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IEncryptionTool
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
}
