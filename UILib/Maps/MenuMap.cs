using CoffeeLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UILib.Maps;

public class MenuMap : IEntityTypeConfiguration<Menu>
{
    public void Configure(EntityTypeBuilder<Menu> builder)
    {
        builder.HasMany(_x => _x.MenuGroups)
            .WithOne(_y => _y.Menu)
            .HasForeignKey(_z => _z.MenuId);

        builder.HasData(SeedMenuData.Menus);
    }
}