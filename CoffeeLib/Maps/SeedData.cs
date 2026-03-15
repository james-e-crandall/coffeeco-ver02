using CoffeeLib.Models;

namespace CoffeeLib.Maps;

public static class SeedData
{
    public static AtHomeCoffee AtHomeCoffee1 = new AtHomeCoffee { Id = 1, Name="Hello World AtHomeCoffee",  };
    public static AtHomeCoffee[] GetAtHomeCoffees = new AtHomeCoffee[]
    {
        AtHomeCoffee1
    };

    public static Drink Drink1 = new Drink { Id = 1, Name="Hello World Drink",  };
    public static Drink[] Drinks = new Drink[]
    {
        Drink1
    };

    public static Food Food1 = new Food { Id = 1, Name="Hello World Food",  };
    public static Food[] Foods = new Food[]
    {
        Food1
    };
    
    public static MenuItem MenuItem1 = new MenuItem { Id = 1, AtHomeCoffeeId = 1,  };
    public static MenuItem MenuItem2 = new MenuItem { Id = 2, DrinkId = 1,  };
    public static MenuItem MenuItem3 = new MenuItem { Id = 3, FoodId = 1,  };

    public static MenuItem[] MenuItems = new MenuItem[]
    {
        MenuItem1,
        MenuItem2,
        MenuItem3
    };

}