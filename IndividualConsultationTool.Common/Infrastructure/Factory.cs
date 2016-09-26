using Ninject;

namespace IndividualConsultationTool.Common.Infrastructure
{
    public static class Factory
    {
        private static IKernel kernel;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IKernel GetInstance()
        {
            if (kernel == null)
            {
                kernel = new StandardKernel();
                kernel.Load(new Container());
            }
            return kernel;
        }
    }
}