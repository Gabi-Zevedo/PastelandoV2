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
    public class CardapioMap : IEntityTypeConfiguration<Cardapio>
    {
        public void Configure(EntityTypeBuilder<Cardapio> builder)
        {
            builder.HasKey(c => c.ItemId);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Tipo).IsRequired();
            builder.Property(c => c.Valor).IsRequired();
            builder.Property(c => c.ValorAdicional).IsRequired();

        }
    }
}
