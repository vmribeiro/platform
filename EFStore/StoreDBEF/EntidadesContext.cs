using Microsoft.Data.Entity;
using StoreDBEF.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDBEF
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<InfoUsuario> InfosUsuarios { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Conexão pela UDL
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Store;Data Source=PLTW07W04823\MSSQLSERVERVMRIB");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasOne(u => u.InfoUsuario);
            modelBuilder.Entity<InfoUsuario>().HasMany(iu => iu.Telefones);
            modelBuilder.Entity<Telefone>().HasOne(t => t.InfoUsuario);
            base.OnModelCreating(modelBuilder);
        }
    }
}
