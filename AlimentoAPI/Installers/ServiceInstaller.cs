using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using AlimentoAPI.Servico.Implementacao;
using AlimentoAPI.Servico.Interface;

namespace AlimentoAPI.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IInstituicaoServico>().ImplementedBy<InstituicaoServico>().LifeStyle.Transient);
            container.Register(Component.For<IEventoServico>().ImplementedBy<EventoServico>().LifeStyle.Transient);
            container.Register(Component.For<IEstoqueServico>().ImplementedBy<EstoqueServico>().LifeStyle.Transient);
            container.Register(Component.For<IArrecadadoServico>().ImplementedBy<ArrecadadoServico>().LifeStyle.Transient);
            container.Register(Component.For<IDoacaoServico>().ImplementedBy<DoacaoServico>().LifeStyle.Transient);
            container.Register(Component.For<IOrganizacoesFilantropicasServico>().ImplementedBy<OrganizacoesFilantropicasServico>().LifeStyle.Transient);
            container.Register(Component.For<IAlimentoServico>().ImplementedBy<AlimentoServico>().LifeStyle.Transient);

        }
    }
}