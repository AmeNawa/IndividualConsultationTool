using IndividualConsultationTool.Common.Infrastructure;
using Ninject;

namespace IndividualConsultationTool.Repository.Mappers.SecureServiceForMappers
{
    public class ConsultationSecureService : EntitySecureService<Entity.Consultation>
    {
        private Common.Secure.ICrypt AES;

        public ConsultationSecureService()
        {
            var kernel = Factory.GetInstance();
            var AES = kernel.Get<Common.Secure.ICrypt>();
        }


        /// <summary>
        /// Decrypt most detailed information about consultation (description)
        /// </summary>
        /// <param name="source"></param>
        public void DecryptEntity(Entity.Consultation source)
        {
            AES.Decrypt(source.Description);
        }


        /// <summary>
        /// Encrypt most detailed information about consultation (description)
        /// </summary>
        /// <param name="source"></param>
        public void EncryptEntity(Entity.Consultation source)
        {
            AES.Encrypt(source.Description);
        }
    }
}
