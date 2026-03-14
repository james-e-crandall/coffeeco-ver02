using CoffeeLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeLib.Maps;

public class MenuItemMap : IEntityTypeConfiguration<MenuItem>
{
    public void Configure(EntityTypeBuilder<MenuItem> builder)
    {
        builder.HasMany(_x => _x.MenuItemAvailablitys)
            .WithOne(_y => _y.MenuItem)
            .HasForeignKey(_z => _z.MenuItemId);

        //builder.HasData(SeedData.MenuItems);
    }
}