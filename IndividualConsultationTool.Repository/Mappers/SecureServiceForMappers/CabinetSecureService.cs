using Ninject;
using IndividualConsultationTool.Common.Infrastructure;

namespace IndividualConsultationTool.Repository.Mappers.SecureServiceForMappers
{
    public class CabinetSecureService : EntitySecureService<Entity.Cabinet>
    {
        private Common.Secure.ICrypt AES;

        public CabinetSecureService()
        {
            var kernel = Factory.GetInstance();
            var AES = kernel.Get<Common.Secure.ICrypt>();
        }


        /// <summary>
        /// Nothing to decrypt yet
        /// </summary>
        /// <param name="source"></param>
        public void DecryptEntity(Entity.Cabinet source)
        {

        }


        /// <summary>
        /// Nothing to encrypt yet
        /// </summary>
        /// <param name="source"></param>
        public void EncryptEntity(Entity.Cabinet source)
        {

        }
    }
}
