using UILib.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace UILib.Maps
{
    public class SeedHomeData 
    {
        public static HomeList HomeList = new HomeList { Id = 1, Active = true };
        public static HomeRow HomeRow =  new HomeRow { Id = 1, HomeListId = HomeList.Id };
        public static HomeRow[] HomeRows = new HomeRow[] { HomeRow };
        public static HomeItem HomeItem = new HomeItem { Id = 1, Text="Hello World", HomeRowId = HomeRow.Id };
        public static HomeItem[] HomeItems = new HomeItem[] { HomeItem };
    }
}