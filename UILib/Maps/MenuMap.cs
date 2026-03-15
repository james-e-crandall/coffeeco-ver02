using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UILib.Models;

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