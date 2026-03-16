


---------

Add HomeItemType

1.
Migration 20260315

Add 
public int HomeItemTypeId { get; set; } 
to 



2.
Migration 20260315a
2003155a2
Add
HomeItemTypeMap

add to SeedHomeData

add to HomeItem
public HomeItemType HomeItemType { get; set; } = null!;

        public static HomeItemType HomeItemType = new HomeItemType { Id = 0, Type = "Hello World" };
        public static HomeItemType[] HomeItemTypes = new HomeItemType[] { HomeItemType };

3.
Migration 20260315b

add
public class HomeItemType

HomeItemTypeMap

builder.HasMany(hi => hi.HomeItems)
    .WithOne(hr => hr.HomeItemType)
    .HasForeignKey(hi => hi.HomeItemTypeId);



