using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UILib.Models;

namespace UILib.Maps;

public class MenuItemMap : IEntityTypeConfiguration<MenuItem>
{
    public void Configure(EntityTypeBuilder<MenuItem> builder)
    {
        builder.HasData(SeedMenuData.MenuItems);
    }
}