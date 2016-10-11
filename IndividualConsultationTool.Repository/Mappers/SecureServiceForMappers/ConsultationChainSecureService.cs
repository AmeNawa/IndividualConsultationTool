using Ninject;
using IndividualConsultationTool.Common.Infrastructure;

namespace IndividualConsultationTool.Repository.Mappers.SecureServiceForMappers
{
    public class ConsultationChainSecureService : EntitySecureService<Entity.ConsultationChain>
    {
        private Common.Secure.ICrypt AES;

        public ConsultationChainSecureService()
        {
            var kernel = Factory.GetInstance();
            var AES = kernel.Get<Common.Secure.ICrypt>();
        }


        /// <summary>
        /// Decrypt consultation chain description
        /// </summary>
        /// <param name="source"></param>
        public void DecryptEntity(Entity.ConsultationChain source)
        {
            AES.Decrypt(source.Description);
        }


        /// <summary>
        /// Encrypt consultation chain description
        /// </summary>
        /// <param name="source"></param>
        public void EncryptEntity(Entity.ConsultationChain source)
        {
            AES.Decrypt(source.Description);
        }
    }
}
