namespace IndividualConsultationTool.Common.Secure
{
    public class SecurityOptions
    {
        /// <summary>
        /// Hasło
        /// </summary>
        public string Password;

        /// <summary>
        /// Hasło wew.
        /// </summary>
        public string Salt;

        /// <summary>
        /// Rodzaj hashowania (SHA1 lub MD5)
        /// </summary>
        public string HashAlghorithm;

        /// <summary>
        /// Musi mieć równo 16 znaków
        /// </summary>
        public string Vector;

        /// <summary>
        /// Il. iteracji jakie wykona algorytm
        /// </summary>
        public int Iterations;

        /// <summary>
        /// Rozmiar klucza, 256, 192, 128
        /// </summary>
        public int KeySize;
    }
}