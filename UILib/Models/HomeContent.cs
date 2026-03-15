using System.Net;

namespace UILib.Models;

public class HomeContent
{
    public int Id { get; set; }
    public ICollection<HomeRow> HomeRows { get; set; } = new List<HomeRow>();
    public DateTime StartDate { get; set; }
    public bool Active { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }

}
