
using efcore_lc4.Configuration;
using efcore_lc4.Model;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace efcore_lc4.Context
{
    public class Lc4Context : DbContext
    {
        public Lc4Context() 
        { 
        
        }

        public Lc4Context(DbContextOptions<Lc4Context> options) : base(options) 
        {
        
        }

        public virtual DbSet<Actor>  Actors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        public virtual DbSet<ActorMovie> ActorsMovie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SEDECH\\SQLEXPRESS;Database=Ciness;TrustServerCertificate=True;User=sa;Password=cayetano");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ActorConfiguration(modelBuilder.Entity<Actor>());
            new MovieConfiguration(modelBuilder.Entity<Movie>());
        }

    }

}
