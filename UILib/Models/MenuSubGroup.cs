namespace CoffeeLib.Models;

public class MenuSubGroup
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public MenuGroup? MenuGroup { get; set; } = null!;
    public int MenuGroupId { get; set; }
    //public List<DrinkJoin> DrinkJoins { get; } = [];
}