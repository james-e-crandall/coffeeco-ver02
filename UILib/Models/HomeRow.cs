namespace UILib.Models;

public class HomeRow
{
    public int Id { get; set; }
    public HomeContent HomeContent { get; set; } = null!;
    public int HomeContentId { get; set; }
    public ICollection<HomeItem> HomeItems { get; set; } = new List<HomeItem>();

}
