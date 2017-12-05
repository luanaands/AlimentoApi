using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Models.Mapping
{
    public class EventoMap : EntityTypeConfiguration<Evento>
    {
        public EventoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Table & Column Mappings
            this.ToTable("evento");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.publico).HasColumnName("publico");
            

            this.HasRequired(s => s.estoque)
                .WithRequiredPrincipal(ad => ad.evento);

            this.HasRequired<Arrecadado>(s => s.arrecadado)
                   .WithMany(s => s.eventos)
                   .HasForeignKey(s => s.idArrecadado);

            this.HasRequired<Instituicao>(s => s.instituicao)
                   .WithMany(s => s.eventos)
                   .HasForeignKey(s => s.idInstituicao);

        }
    }
}