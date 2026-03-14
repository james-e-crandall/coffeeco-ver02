namespace CoffeeLib.Models;

public class MenuItemAvailablity
{
    public int Id { get; set; }
    public MenuItem MenuItem { get; set; } = null!;
    public int MenuItemId { get; set; }
    public bool IsAvailable { get; set;}
    public DateTime? EntryDate { get; set; }
}