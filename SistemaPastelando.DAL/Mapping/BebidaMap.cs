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
    public class BebidaMap : IEntityTypeConfiguration<Bebida>
    {
        public void Configure(EntityTypeBuilder<Bebida> builder)
        {
            builder.HasKey(x => x.BebidaId);

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Valor).IsRequired();

            builder.HasData(
                    new Bebida
                    {
                        BebidaId = 1,
                        Nome = "Coca-cola 2L",
                        Valor = 9.50,                        
                    },
                    new Bebida
                    {
                        BebidaId = 2,
                        Nome = "Coca-cola 350ml",
                        Valor = 4.50,                        
                    },
                    new Bebida
                    {
                        BebidaId = 3,
                        Nome = "Coca-cola 600ml",
                        Valor = 6.50,                        
                    },
                    new Bebida
                    {
                        BebidaId = 4,
                        Nome = "Guaravita",
                        Valor = 2.50,                        
                    },
                    new Bebida
                    {
                        BebidaId = 5,
                        Nome = "Guaraná 2L",
                        Valor = 8.50,                        
                    },
                    new Bebida
                    {
                        BebidaId = 6,
                        Nome = "Guaraná 350L",
                        Valor = 4.50,                        
                    });

            builder.ToTable("Bebidas");
        }
    }
}
