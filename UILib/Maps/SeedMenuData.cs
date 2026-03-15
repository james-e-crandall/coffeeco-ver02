using UILib.Models;

namespace UILib.Maps;

public static class SeedMenuData
{

    public static Menu Menu1 = new Menu { Id = 1, Name="Menu Hello World" };

    public static Menu[] Menus = new Menu[]
    {
        Menu1,
    };

    public static MenuGroup MenuGroup1 = new MenuGroup { Id = 1, Name="MenuGroup Hello World", MenuId = 1 };

    public static MenuGroup[] MenuGroups = new MenuGroup[]
    {
        MenuGroup1
    };

    public static MenuSubGroup MenuSubGroup1 = new MenuSubGroup { Id = 1, Name="MenuSubGroup", MenuGroupId = 1 };

    public static MenuSubGroup[] MenuSubGroups = new MenuSubGroup[]
    {
        MenuSubGroup1
    };

    public static MenuItem MenuItem1 = new MenuItem { Id = 1, MenuSubGroupId = 1,  };
    public static MenuItem MenuItem2 = new MenuItem { Id = 2, MenuSubGroupId = 1,  };
    public static MenuItem MenuItem3 = new MenuItem { Id = 3, MenuSubGroupId = 1,  };

    public static MenuItem[] MenuItems = new MenuItem[]
    {
        MenuItem1,
        MenuItem2,
        MenuItem3
    };

}