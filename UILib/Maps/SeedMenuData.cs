using CoffeeLib.Models;

namespace UILib.Maps;

public static class SeedMenuData
{

    public static Menu Menu1 = new Menu { Id = 1, Name="Fan Favorites" };
    public static Menu Menu2 = new Menu { Id = 2, Name="Drinks" };
    public static Menu Menu3 = new Menu { Id = 3, Name="Food" };
    public static Menu Menu4 = new Menu { Id = 4, Name="At Home Coffee" };

    public static Menu[] Menus = new Menu[]
    {
        Menu1,
        Menu2,
        Menu3,
        Menu4
    };

    public static MenuGroup MenuGroup1 = new MenuGroup { Id = 1, Name="Protein Beverages", MenuId = 2 };
    public static MenuGroup MenuGroup2 = new MenuGroup { Id = 2, Name="Hot Coffee", MenuId = 2 };
    public static MenuGroup MenuGroup3 = new MenuGroup { Id = 3, Name="Cold Coffee", MenuId = 2 };

    public static MenuGroup[] MenuGroups = new MenuGroup[]
    {
        MenuGroup1,
        MenuGroup2,
        MenuGroup3,
    };

    public static MenuSubGroup MenuSubGroup1 = new MenuSubGroup { Id = 1, Name="Brewed Coffee", MenuGroupId = 2 };
    public static MenuSubGroup MenuSubGroup2 = new MenuSubGroup { Id = 2, Name="Americano", MenuGroupId = 2 };
    public static MenuSubGroup MenuSubGroup3 = new MenuSubGroup { Id = 3, Name="Latte", MenuGroupId = 2 };

    public static MenuSubGroup[] MenuSubGroups = new MenuSubGroup[]
    {
        MenuSubGroup1,
        MenuSubGroup2,
        MenuSubGroup3,
    };

    //  public static DrinkJoin DrinkJoin1 = new DrinkJoin { Id = 1, MenuSubGroupId = 1, DrinkId = 1 };
    //  public static DrinkJoin DrinkJoin2 = new DrinkJoin { Id = 2, MenuSubGroupId = 1, DrinkId = 2 };
    //  public static DrinkJoin DrinkJoin3 = new DrinkJoin { Id = 3, MenuSubGroupId = 1, DrinkId = 3 };
    // public static DrinkJoin[] DrinkJoins = new DrinkJoin[]
    // {
    //     DrinkJoin1,
    //     DrinkJoin2,
    //     DrinkJoin3,
    // };
}