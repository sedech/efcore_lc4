using efcore_lc4.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efcore_lc4.Configuration
{
    public class MovieConfiguration
    {
        public MovieConfiguration(EntityTypeBuilder<Movie> entityBuilder)
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.MovieName).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.MovieGenre).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.MovieDuration).IsRequired();
            entityBuilder.Property(u => u.MovieBudget).IsRequired();

            entityBuilder.HasMany(u => u.Actors).WithMany(u => u.Movies)
               .UsingEntity<ActorMovie>(
               j => j.HasOne(am => am.Actor).WithMany(),
               j => j.HasOne(am => am.Movie).WithMany()
            );
        }    
    }
}
