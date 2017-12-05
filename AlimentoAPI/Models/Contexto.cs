using AlimentoAPI.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Models
{
    public partial class Contexto : DbContext
    {
        public Contexto() : base("name=Contexto"){ }

        public virtual DbSet<Alimento> Alimento { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<Doacao> Doacao { get; set; }
        public virtual DbSet<Instituicao> Instituicao { get; set; }
        public virtual DbSet<OrganizacoesFilantropicas> OrganizacoesFilantropicas { get; set; }
        public virtual DbSet<Arrecadado> Arrecadado { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlimentoMap());
            modelBuilder.Configurations.Add(new ArrecadadoMap());
            modelBuilder.Configurations.Add(new DoacaoMap());
            modelBuilder.Configurations.Add(new EstoqueMap());
            modelBuilder.Configurations.Add(new EventoMap());
            modelBuilder.Configurations.Add(new InstituicaoMap());
            modelBuilder.Configurations.Add(new OrganizacoesFilantropicasMap());

            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
          //  modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}