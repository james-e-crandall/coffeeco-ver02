namespace UILib.Models;

public class MenuGroup
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Menu Menu { get; set; } = null!;
    public int MenuId { get; set; }
    public ICollection<MenuSubGroup> MenuSubGroups { get; set; } = new List<MenuSubGroup>();
}