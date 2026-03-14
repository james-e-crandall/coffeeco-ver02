using CoffeeLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeLib.Maps;

public class DrinkMap : IEntityTypeConfiguration<Drink>
{
    public void Configure(EntityTypeBuilder<Drink> builder)
    {
        builder.HasOne(_x => _x.MenuItem)
            .WithOne(_y => _y.Drink)
            .HasForeignKey<MenuItem>(_z => _z.DrinkId);

        builder.HasData(SeedData.Drinks);
    }
}