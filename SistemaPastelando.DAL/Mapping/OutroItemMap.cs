using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemaPastelando.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPastelando.DAL.Mapping
{
    class OutroItemMap : IEntityTypeConfiguration<OutroItem>
    {
        public void Configure(EntityTypeBuilder<OutroItem> builder)
        {
            builder.HasKey(x => x.OutroItemId);

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Valor).IsRequired();

            builder.HasData(
                    new OutroItem
                    {
                        OutroItemId = 1,
                        Nome = "Pastel de Vento",
                        Valor = 6,
                    });


            builder.ToTable("OutrosItens");
        }
    }
}

