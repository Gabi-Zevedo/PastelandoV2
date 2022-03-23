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
    public class MassaMap : IEntityTypeConfiguration<Massa>
    {
        public void Configure(EntityTypeBuilder<Massa> builder)
        {
            builder.HasKey(x => x.MassaId);

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Valor).IsRequired();

            builder.HasData(
                    new Massa
                    {
                        MassaId = 1,
                        Nome = "Original",
                        Valor = 14,
                    },
                    new Massa
                    {
                        MassaId = 2,
                        Nome = "Pimenta",
                        Valor = 4.50,
                    },
                    new Massa
                    {
                        MassaId = 3,
                        Nome = "Cacau",
                        Valor = 6.50,
                    });


            builder.ToTable("Massas");
        }
    }
}
