using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UILib.Models;

namespace UILib.Maps;

public class MenuSubGroupMap : IEntityTypeConfiguration<MenuSubGroup>
{
    public void Configure(EntityTypeBuilder<MenuSubGroup> builder)
    {
        builder.HasMany(_x => _x.MenuItems)
            .WithOne(_y => _y.MenuSubGroup)
            .HasForeignKey(_z => _z.MenuSubGroupId);

        builder.HasData(SeedMenuData.MenuSubGroups);
    }
}