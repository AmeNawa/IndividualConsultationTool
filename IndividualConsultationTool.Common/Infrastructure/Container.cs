using IndividualConsultationTool.Common.Secure;
using Ninject;
using Ninject.Modules;
using IndividualConsultationTool.Common.Const;

namespace IndividualConsultationTool.Common.Infrastructure
{ 
    public class Container : NinjectModule
    {
        public override void Load()
        {
            Bind<ICrypt>().To<AESCrypt>().WithConstructorArgument(securityOptions);
        }

        private readonly SecurityOptions securityOptions = new SecurityOptions
        {
            Password = SecureConst.Password,
            HashAlghorithm = "SHA1",
            Iterations = SecureConst.Iterations,
            KeySize = SecureConst.KeySize,
            Salt = SecureConst.Salt,
            Vector = SecureConst.Vector,
        };
    }
}