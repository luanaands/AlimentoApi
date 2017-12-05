using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace AlimentoAPI.Models.Mapping
{
    public class EstoqueMap : EntityTypeConfiguration<Estoque>
    {
        public EstoqueMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Table & Column Mappings
            this.ToTable("estoque");
            this.Property(t => t.id).HasColumnName("id");

        

        }
    }
}