namespace UILib.Models;

public class MenuItem
{
    public int Id { get; set; }
    public bool IsActive { get; set; }
    public MenuSubGroup MenuSubGroup { get; set; } = null!;
    public int MenuSubGroupId { get; set; }
    public int CoffeeId { get; set; }

}