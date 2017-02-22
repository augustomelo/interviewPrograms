using SistemaRestaurante.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SistemaRestaurante.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Contexto")
        {
        }

        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}