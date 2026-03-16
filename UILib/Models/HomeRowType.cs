using System.ComponentModel.DataAnnotations;

namespace UILib.Models;

public class HomeRowType
{
    public int Id { get; set; }
    [Required]
    public required string Type { get; set; }
    public ICollection<HomeRow> HomeRows { get; set; } = new List<HomeRow>();
}