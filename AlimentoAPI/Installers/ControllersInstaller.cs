using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Web.Http;
using System.Web.Mvc;
using Castle.MicroKernel;

namespace AlimentoAPI.Installers
{
    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {

            container.Register(Classes.FromThisAssembly()
            .BasedOn<ApiController>()
            .LifestyleTransient());

            container.Register(Classes.FromThisAssembly()
            .BasedOn<IController>()
            .LifestyleTransient());

        }
        /*
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
            .BasedOn<ApiController>()
            .LifestylePerWebRequest());

            container.Register(Classes.FromThisAssembly()
            .BasedOn<IController>()
            .LifestyleTransient());

        }
         */
    }
}