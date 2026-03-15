using UILib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UILib.Maps
{
    public class HomeContentMap : IEntityTypeConfiguration<HomeContent>
    {
        public void Configure(EntityTypeBuilder<HomeContent> builder)
        {

            builder.HasMany(h => h.HomeRows)
                .WithOne(hr => hr.HomeContent)
                .HasForeignKey(hr => hr.HomeContentId);

            // Add all other configurations for the Blog entity here
            builder.HasData(
                SeedHomeData.HomeList);

        }
    }
}
