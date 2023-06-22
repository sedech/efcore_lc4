using efcore_lc4.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efcore_lc4.Configuration
{
    public class ActorConfiguration
    {
        public ActorConfiguration(EntityTypeBuilder<Actor>entityBuilder) 
        {
            entityBuilder.HasKey(u => u.Id);
            entityBuilder.Property(u => u.ActorName).IsRequired().HasMaxLength(250);
            entityBuilder.Property(u => u.ActorBirthdate).IsRequired();
            entityBuilder.Property(u => u.ActorPicture).IsRequired().HasMaxLength(250);
            
            entityBuilder.HasMany(u => u.Movies).WithMany(m => m.Actors)
                .UsingEntity<ActorMovie>(
                 j => j.HasOne(am=>am.Movie).WithMany(),
                 j => j.HasOne(am=>am.Actor).WithMany()
                );
        }
    }
}
