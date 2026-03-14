using CoffeeLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeLib.Maps;

public class AtHomeCoffeeMap : IEntityTypeConfiguration<AtHomeCoffee>
{
    public void Configure(EntityTypeBuilder<AtHomeCoffee> builder)
    {
        builder.HasOne(_x => _x.MenuItem)
            .WithOne(_y => _y.AtHomeCoffee)
            .HasForeignKey<MenuItem>(_z => _z.AtHomeCoffeeId);
    }
}