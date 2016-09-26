namespace IndividualConsultationTool.Common.Secure
{
    public interface ICrypt
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
}