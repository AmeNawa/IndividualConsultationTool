using Ninject;
using IndividualConsultationTool.Common.Infrastructure;

namespace IndividualConsultationTool.Repository.Mappers.SecureServiceForMappers
{
    public class AdressSecureService : EntitySecureService<Entity.Adress>
    {
        private Common.Secure.ICrypt AES;

        public AdressSecureService()
        {
            var kernel = Factory.GetInstance();
            var AES = kernel.Get<Common.Secure.ICrypt>();
        }


        /// <summary>
        /// Decrypt most detailed information about adress (street and postal code)
        /// </summary>
        /// <param name="source"></param>
        public void DecryptEntity(Entity.Adress source)
        {
            AES.Decrypt(source.Street);
            AES.Decrypt(source.PostalCode);
        }


        /// <summary>
        /// Encrypt most detailed information about adress (street and postal code)
        /// </summary>
        /// <param name="source"></param>
        public void EncryptEntity(Entity.Adress source)
        {
            AES.Encrypt(source.Street);
            AES.Encrypt(source.PostalCode);
        }
    }
}
