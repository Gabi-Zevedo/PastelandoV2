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
        public DbSet<Cardapio> Cardapios { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }


        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CardapioMap());
        }
    }
}
