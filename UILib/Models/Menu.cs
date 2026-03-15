namespace UILib.Models;

public class Menu
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<MenuGroup> MenuGroups { get; set; } = new List<MenuGroup>();
}