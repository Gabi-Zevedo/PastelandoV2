using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaPastelando.BLL.Models;
using SistemaPastelando.DAL.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPastelando.DAL
{
    public class Context : IdentityDbContext<User, Role, string>
    {
        public DbSet<Recheio> Recheios { get; set; }
        public DbSet<Complemento> Complementos { get; set; }
        public DbSet<Massa> Massas { get; set; }
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<Sobremesa> Sobremesas { get; set; }
        public DbSet<OutroItem> OutrosItens { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }


        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RecheioMap());
            builder.ApplyConfiguration(new ComplementoMap());
            builder.ApplyConfiguration(new MassaMap());
            builder.ApplyConfiguration(new BebidaMap());
            builder.ApplyConfiguration(new SobremesaMap());
            builder.ApplyConfiguration(new OutroItemMap());

        }
    }
}
