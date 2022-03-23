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
    public class RecheioMap : IEntityTypeConfiguration<Recheio>
    {
        public void Configure(EntityTypeBuilder<Recheio> builder)
        {
            builder.HasKey(x => x.RecheioId);

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Valor).IsRequired();

            builder.Property(x => x.ValorAdicional).IsRequired();

            builder.HasData(
                    new Recheio
                    {
                        RecheioId = 1,
                        Nome = "Mussarela",
                        Valor = 0,
                        ValorAdicional = 3,
                    },
                    new Recheio
                    {
                        RecheioId = 2,
                        Nome = "Minas",
                        Valor = 0,
                        ValorAdicional = 3,
                    },
                    new Recheio
                    {
                        RecheioId = 3,
                        Nome = "Presunto",
                        Valor = 0,
                        ValorAdicional = 3,
                    },
                    new Recheio
                    {
                        RecheioId = 4,
                        Nome = "Calabresa",
                        Valor = 0,
                        ValorAdicional = 3,
                    },
                    new Recheio
                    {
                        RecheioId = 5,
                        Nome = "Carne",
                        Valor = 2,
                        ValorAdicional = 3,
                    },
                    new Recheio
                    {
                        RecheioId = 6,
                        Nome = "Frango",
                        Valor = 0,
                        ValorAdicional = 3,
                    });

            builder.ToTable("Recheios");
        }
    }
}
