using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using AlimentoAPI.Repositorio.Implementacao;

namespace AlimentoAPI.Installers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<InstituicaoRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<EventoRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<AlimentoRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<OrganizacoesFilantropicasRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<EstoqueRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<DoacaoRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<ArrecadadoRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
        }
    }
}