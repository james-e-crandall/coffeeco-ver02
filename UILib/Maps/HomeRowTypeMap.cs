using UILib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UILib.Maps
{
    public class HomeRowTypeMap : IEntityTypeConfiguration<HomeRowType>
    {
        public void Configure(EntityTypeBuilder<HomeRowType> builder)
        {

            builder.HasMany(hi => hi.HomeRows)
                .WithOne(hr => hr.HomeRowType)
                .HasForeignKey(hi => hi.HomeRowTypeId);

            // Add all other configurations for the Blog entity here
            builder.HasData(
                SeedHomeData.HomeRowTypes);

        }
    }
}