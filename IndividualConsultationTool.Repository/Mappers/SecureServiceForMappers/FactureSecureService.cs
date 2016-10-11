using IndividualConsultationTool.Common.Infrastructure;
using Ninject;

namespace IndividualConsultationTool.Repository.Mappers.SecureServiceForMappers
{
    public class FactureSecureService : EntitySecureService<Entity.Facture>
    {
        private Common.Secure.ICrypt AES;

        public FactureSecureService()
        {
            var kernel = Factory.GetInstance();
            var AES = kernel.Get<Common.Secure.ICrypt>();
        }


        /// <summary>
        /// Decrypt facture's number and pay in words
        /// </summary>
        /// <param name="source"></param>
        public void DecryptEntity(Entity.Facture source)
        {
            AES.Decrypt(source.FactureNumber);
            AES.Decrypt(source.ToPayInWords);
        }


        /// <summary>
        /// Encrypt facture's number and pay in words
        /// </summary>
        /// <param name="source"></param>
        public void EncryptEntity(Entity.Facture source)
        {
            AES.Decrypt(source.FactureNumber);
            AES.Decrypt(source.ToPayInWords);
        }
    }
}
