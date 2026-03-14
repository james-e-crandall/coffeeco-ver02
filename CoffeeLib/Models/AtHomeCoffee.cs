namespace CoffeeLib.Models;

public class AtHomeCoffee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public MenuItem MenuItem { get; set;  } = null!;
    public int MenuItemId { get; set; }
}