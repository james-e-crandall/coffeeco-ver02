using CoffeeLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeLib.Maps;

public class FoodMap : IEntityTypeConfiguration<Food>
{
    public void Configure(EntityTypeBuilder<Food> builder)
    {
        builder.HasOne(_x => _x.MenuItem)
            .WithOne(_y => _y.Food)
            .HasForeignKey<MenuItem>(_z => _z.FoodId);
    }
}