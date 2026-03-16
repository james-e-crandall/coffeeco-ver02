using UILib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UILib.Maps
{
    public class HomeItemTypeMap : IEntityTypeConfiguration<HomeItemType>
    {
        public void Configure(EntityTypeBuilder<HomeItemType> builder)
        {

            builder.HasMany(hi => hi.HomeItems)
                .WithOne(hr => hr.HomeItemType)
                .HasForeignKey(hi => hi.HomeItemTypeId);

            // Add all other configurations for the Blog entity here
            builder.HasData(
                SeedHomeData.HomeItemTypes);

        }
    }
}