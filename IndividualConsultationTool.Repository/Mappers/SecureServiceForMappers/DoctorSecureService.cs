using IndividualConsultationTool.Common.Infrastructure;
using Ninject;

namespace IndividualConsultationTool.Repository.Mappers.SecureServiceForMappers
{
    public class DoctorSecureService : EntitySecureService<Entity.Doctor>
    {
        private Common.Secure.ICrypt AES;

        public DoctorSecureService()
        {
            var kernel = Factory.GetInstance();
            var AES = kernel.Get<Common.Secure.ICrypt>();
        }


        /// <summary>
        /// Decrypt most important information about doctor (password and surname)
        /// </summary>
        /// <param name="source"></param>
        public void DecryptEntity(Entity.Doctor source)
        {
            AES.Decrypt(source.Password);
            AES.Decrypt(source.Surname);
        }


        /// <summary>
        /// Encrypt most important information about doctor (password and surname)
        /// </summary>
        /// <param name="source"></param>
        public void EncryptEntity(Entity.Doctor source)
        {
            AES.Decrypt(source.Password);
            AES.Decrypt(source.Surname);
        }
    }
}
