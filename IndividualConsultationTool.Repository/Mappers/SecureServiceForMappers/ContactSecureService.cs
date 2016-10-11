using IndividualConsultationTool.Common.Infrastructure;
using Ninject;

namespace IndividualConsultationTool.Repository.Mappers.SecureServiceForMappers
{
    public class ContactSecureService : EntitySecureService<Entity.Contact>
    {
        private Common.Secure.ICrypt AES;

        public ContactSecureService()
        {
            var kernel = Factory.GetInstance();
            var AES = kernel.Get<Common.Secure.ICrypt>();
        }


        /// <summary>
        /// Decrypt most detailed information about contact (phone number and email)
        /// </summary>
        /// <param name="source"></param>
        public void DecryptEntity(Entity.Contact source)
        {
            AES.Decrypt(source.PhoneNumber);
            AES.Decrypt(source.Email);
        }


        /// <summary>
        /// Encrypt most detailed information about contact (phone number and email)
        /// </summary>
        /// <param name="source"></param>
        public void EncryptEntity(Entity.Contact source)
        {
            AES.Decrypt(source.PhoneNumber);
            AES.Decrypt(source.Email);
        }
    }
}
