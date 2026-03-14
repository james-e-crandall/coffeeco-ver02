namespace CoffeeLib.Models;

public class MenuItem
{
    public int Id { get; set; }
    public bool IsActive { get; set; }
    public AtHomeCoffee AtHomeCoffee { get; set; } = null!;
    public int AtHomeCoffeeId { get; set; }
    public Drink Drink { get; set; } = null!;
    public int DrinkId { get; set; }
    public Food Food { get; set; } = null!;
    public int FoodId { get; set; }
    public ICollection<MenuItemAvailablity> MenuItemAvailablitys { get; set;  } = new List<MenuItemAvailablity>(); 

}