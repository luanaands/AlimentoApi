using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Models.Mapping
{
    public class DoacaoMap : EntityTypeConfiguration<Doacao>
    {
        public DoacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
           


            // Table & Column Mappings
            this.ToTable("doacao");
            this.Property(t => t.id).HasColumnName("id");

            
            this.HasRequired<Arrecadado>(s => s.arrecadado)
                         .WithMany(s => s.doacoes)
                         .HasForeignKey(s => s.idArrecadado);
            this.HasRequired<OrganizacoesFilantropicas>(s => s.organizacao)
                         .WithMany(s => s.doacoes)
                         .HasForeignKey(s => s.idOrganizacaoFila);

        }
    }
}