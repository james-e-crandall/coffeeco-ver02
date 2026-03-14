using CoffeeLib.Maps;
using CoffeeLib.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeLib.Data;

public class CoffeeContext(DbContextOptions<CoffeeContext> options) : DbContext(options)
{
    public DbSet<AtHomeCoffee> AtHomeCoffees { get; set; }

    public DbSet<Drink> Drinks { get; set; }

    
    public DbSet<Food> Foods { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new AtHomeCoffeeMap());
        modelBuilder.ApplyConfiguration(new DrinkMap());
        modelBuilder.ApplyConfiguration(new FoodMap());
        modelBuilder.ApplyConfiguration(new MenuItemMap());
        
    }
    
}

