using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaPastelando.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPastelando.DAL.Mapping
{
    public class ComplementoMap : IEntityTypeConfiguration<Complemento>
    {
        public void Configure(EntityTypeBuilder<Complemento> builder)
        {
            builder.HasKey(x => x.ComplementoId);

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Valor).IsRequired();

            builder.Property(x => x.ValorAdicional).IsRequired();

            builder.HasData(
                    new Complemento
                    {
                        ComplementoId = 1,
                        Nome = "Cebola",
                        Valor = 0,
                        ValorAdicional = 3,
                    },
                    new Complemento
                    {
                        ComplementoId = 2,
                        Nome = "Tomate",
                        Valor = 0,
                        ValorAdicional = 3,
                    },
                    new Complemento
                    {
                        ComplementoId = 3,
                        Nome = "Cheddar",
                        Valor = 0,
                        ValorAdicional = 3,
                    },
                    new Complemento
                    {
                        ComplementoId = 4,
                        Nome = "Catupiry",
                        Valor = 0,
                        ValorAdicional = 3,
                    },
                    new Complemento
                    {
                        ComplementoId = 5,
                        Nome = "Cream Cheese",
                        Valor = 2,
                        ValorAdicional = 3,
                    },
                    new Complemento
                    {
                        ComplementoId = 6,
                        Nome = "Azeitona",
                        Valor = 0,
                        ValorAdicional = 3,
                    });


            builder.ToTable("Complementos");
        }

    }
}

