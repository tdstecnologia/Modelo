using AspNetCoreMvcCrudPostgreSQL.Dominio;
using AspNetCoreMvcCrudPostgreSQL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcCrudPostgreSQL.Repository
{
    public class AppContexto : DbContext
    {
        public AppContexto(DbContextOptions<AppContexto> opcoes) : base(opcoes)
        {
        }

        public DbSet<Curso> CursoDao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Curso>()
            .Property(c => c.Turno)
            .HasConversion(
            v => v.ToString(),
            v => (DomTurno)Enum.Parse(typeof(DomTurno), v));
        }
    }
}
