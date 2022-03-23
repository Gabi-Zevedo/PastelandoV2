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
    public class SobremesaMap : IEntityTypeConfiguration<Sobremesa>
    {
        public void Configure(EntityTypeBuilder<Sobremesa> builder)
        {
            builder.HasKey(x => x.SobremesaId);

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Valor).IsRequired();

            builder.HasData(
                    new Sobremesa
                    {
                        SobremesaId = 1,
                        Nome = "Pastel Banana c/ açucar",
                        Valor = 8,
                    },
                    new Sobremesa
                    {
                        SobremesaId = 2,
                        Nome = "Pastel Romeu e Julieta",
                        Valor = 8,
                    },
                    new Sobremesa
                    {
                        SobremesaId = 3,
                        Nome = "Pastel de Churros",
                        Valor = 8,
                    },
                    new Sobremesa
                    {
                        SobremesaId = 4,
                        Nome = "Pastel Banana c/ Nutela",
                        Valor = 8,
                    },
                    new Sobremesa
                    {
                        SobremesaId = 5,
                        Nome = "Pastel de Ovomaltine",
                        Valor = 8,
                    },
                    new Sobremesa
                    {
                        SobremesaId = 6,
                        Nome = "Pastel Mineirin",
                        Valor = 8,
                    });


            builder.ToTable("Sobremesas");
        }
    }
}

