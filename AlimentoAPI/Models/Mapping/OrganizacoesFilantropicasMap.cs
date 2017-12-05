using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Models.Mapping
{
    public class OrganizacoesFilantropicasMap : EntityTypeConfiguration<OrganizacoesFilantropicas>
    {
        public OrganizacoesFilantropicasMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties

            // Table & Column Mappings
            this.ToTable("organizacoesfilantropicas");
            this.Property(t => t.cnpj).HasColumnName("cnpj");
            this.Property(t => t.contato).HasColumnName("telefone");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.nome).HasColumnName("razaosocial");
            this.Property(t => t.nomeRepresentante).HasColumnName("nomerepresentante");
            this.Property(t => t.quantidadePessoas).HasColumnName("quantidadepessoas");

        }
    }
}