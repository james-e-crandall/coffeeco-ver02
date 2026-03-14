using CoffeeLib.Models;

namespace CoffeeLib.Maps;

public static class SeedData
{
    public static Drink Drink1 = new Drink { Id = 1, Name="Blonde Roast",  };
    public static Drink Drink2 = new Drink { Id = 2, Name="Medium Roast", };
    public static Drink Drink3 = new Drink { Id = 3, Name="Dark Roast" };
    public static Drink Drink4 = new Drink { Id = 4, Name="Decaf Roast" };
    public static Drink[] Drinks = new Drink[]
    {
        Drink1, Drink2, Drink3, Drink4
    };

}