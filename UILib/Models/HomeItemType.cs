using System.ComponentModel.DataAnnotations;

namespace UILib.Models;

public class HomeItemType
{
    public int Id { get; set; }
    [Required]
    public required string Type { get; set; }
    public ICollection<HomeItem> HomeItems { get; set; } = new List<HomeItem>();
}