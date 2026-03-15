using UILib.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace UILib.Maps
{
    public class SeedHomeData 
    {
        public static HomeContent HomeList = new HomeContent { Id = 1, Active = true };
        public static HomeRow HomeRow =  new HomeRow { Id = 1, HomeContentId = HomeList.Id };
        public static HomeRow[] HomeRows = new HomeRow[] { HomeRow };
        public static HomeItem HomeItem = new HomeItem { Id = 1, Text="Hello World", HomeRowId = HomeRow.Id };
        public static HomeItem[] HomeItems = new HomeItem[] { HomeItem };
    }
}