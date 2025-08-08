using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Datos.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tipos_Usuarios> Tip_Usuarios { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
           .HasMany(u => u.Tip_Usuarios)
           .WithMany(p => p.Usuarios)
           .UsingEntity(j => j.ToTable("Usuarios_Permisos"));



        }

    }
}
