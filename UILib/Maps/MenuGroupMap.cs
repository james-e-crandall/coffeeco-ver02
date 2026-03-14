using CoffeeLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UILib.Maps;

public class MenuGroupMap : IEntityTypeConfiguration<MenuGroup>
{
    public void Configure(EntityTypeBuilder<MenuGroup> builder)
    {
        builder.HasMany(_x => _x.MenuSubGroups)
            .WithOne(_y => _y.MenuGroup)
            .HasForeignKey(_z => _z.MenuGroupId);

        builder.HasData(SeedMenuData.MenuGroups);
    }
}