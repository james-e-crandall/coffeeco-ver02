using UILib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UILib.Maps
{
    public class HomeRowMap : IEntityTypeConfiguration<HomeRow>
    {
        public void Configure(EntityTypeBuilder<HomeRow> builder)
        {

            builder.HasMany(h => h.HomeItems)
                .WithOne(hi => hi.HomeRow)
                .HasForeignKey(hi => hi.HomeRowId);

            // Add all other configurations for the Blog entity here
            builder.HasData(
                SeedHomeData.HomeRows);

        }
    }
}
