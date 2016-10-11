using IndividualConsultationTool.Common.Infrastructure;
using Ninject;

namespace IndividualConsultationTool.Repository.Mappers.SecureServiceForMappers
{
    public class PatientSecureService : EntitySecureService<Entity.Patient>
    {
        private Common.Secure.ICrypt AES;

        public PatientSecureService()
        {
            var kernel = Factory.GetInstance();
            var AES = kernel.Get<Common.Secure.ICrypt>();
        }


        /// <summary>
        /// Decrypt patient's firstname and surname
        /// </summary>
        /// <param name="source"></param>
        public void DecryptEntity(Entity.Patient source)
        {
            AES.Decrypt(source.FirstName);
            AES.Decrypt(source.Surname);
        }


        /// <summary>
        /// Encrypt patient's firstname and surname
        /// </summary>
        /// <param name="source"></param>
        public void EncryptEntity(Entity.Patient source)
        {
            AES.Decrypt(source.FirstName);
            AES.Decrypt(source.Surname);
        }
    }
}

