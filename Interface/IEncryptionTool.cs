namespace Interface
{
    public interface IEncryptionTool
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
}
