namespace UILib.Data;
using Microsoft.EntityFrameworkCore;
using UILib.Maps;
using UILib.Models;

public partial class UIContext : DbContext
{
    public UIContext(DbContextOptions<UIContext> options)
        : base(options) { }

    public DbSet<HomeItem> HomeItems { get; set; }
    public DbSet<HomeRow> HomeRows { get; set; }
    public DbSet<HomeContent> HomeContents { get; set; }
    public DbSet<HomeItemType> HomeItemTypes { get; set; }
    public DbSet<HomeRowType> HomeRowTypes { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); 

        modelBuilder.ApplyConfiguration(new HomeContentMap());
        modelBuilder.ApplyConfiguration(new HomeRowMap());
        modelBuilder.ApplyConfiguration(new HomeItemMap());
        modelBuilder.ApplyConfiguration(new HomeItemTypeMap());
        modelBuilder.ApplyConfiguration(new HomeRowTypeMap());

        modelBuilder.ApplyConfiguration(new MenuGroupMap());
        modelBuilder.ApplyConfiguration(new MenuMap());
        modelBuilder.ApplyConfiguration(new MenuSubGroupMap());
        
    }

    

}