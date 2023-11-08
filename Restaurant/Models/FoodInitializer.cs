namespace Restaurant.Models
{
    public class FoodInitializer
        : System.Data.Entity.DropCreateDatabaseAlways<FoodDB>
    {
        protected override void Seed(FoodDB context)
        {
            //MENU ITEMS----------------------------------------------------------------------
            context.Categories.Add(new Category
            {
                Name = "Steaks",
                Foods = new System.Collections.Generic.List<Food>()
                {
                    new Food{Name="Ribs", Price=19.99m, FoodArtUrl="../../Images/Steaks/Ribs.png"},
                    new Food{Name="Beef", Price=24.99m, FoodArtUrl="../../Images/Steaks/Beef.png" },
                    new Food{Name="Ribeye", Price=29.99m, FoodArtUrl="../../Images/Steaks/Ribeye.png"}
                }
            });
            context.Categories.Add(new Category
            {
                Name = "Soups",
                Foods = new System.Collections.Generic.List<Food>()
                {
                    new Food{Name="Tomato Soup", Price=2.99m, FoodArtUrl="../../Images/Soups/TomatoSoup.png"},
                    new Food{Name="Pea Soup", Price=2.99m, FoodArtUrl="../../Images/Soups/PeaSoup.png"},
                    new Food{Name="Mushroom Soup", Price=2.99m, FoodArtUrl="../../Images/Soups/MushroomSoup.png"}
                }
            });
            context.Categories.Add(new Category
            {
                Name = "Seafood",
                Foods = new System.Collections.Generic.List<Food>()
                {
                    new Food{Name="Florida Clams", Price=58.99m, FoodArtUrl="../../Images/Seafood/FloridaClams.png"},
                    new Food{Name="Jumbo Scallops Wild Mushroom Risotto", Price=39.99m, FoodArtUrl="../../Images/Seafood/JumboScallops.png"},
                    new Food{Name="Fish Tacos", Price=47.25m, FoodArtUrl="../../Images/Seafood/FishTaco.png"}
                }
            });
            context.Categories.Add(new Category
            {
                Name = "Pizzas",
                Foods = new System.Collections.Generic.List<Food>()
                {
                    new Food{Name="Pepperoni Pizza", Price=34.99m, FoodArtUrl="../../Images/Pizzas/PepperoniPizza.png"},
                    new Food{Name="Veggie Pizza", Price=22.50m, FoodArtUrl="../../Images/Pizzas/VeggiePizza.png"},
                    new Food{Name="Margherita Pizza", Price=30m, FoodArtUrl="../../Images/Pizzas/MargheritaPizza.png"}
                }
            });
            context.Categories.Add(new Category
            {
                Name = "Cold Drinks",
                Foods = new System.Collections.Generic.List<Food>()
                {
                    new Food{Name="Cola", Price=14.99m},
                    new Food{Name="Ayran", Price=7.99m},
                    new Food{Name="Fruit Juice(Orange, Lemon, Strawberry, Apple)", Price=5.50m},
                    new Food{Name="Mineral Water", Price=3.99m},
                    new Food{Name="Soda", Price=8.99m}
                }
            });
            context.Categories.Add(new Category
            {
                Name = "Hot Drinks",
                Foods = new System.Collections.Generic.List<Food>()
                {
                    new Food{Name="Hot Chocolate", Price=7.99m},
                    new Food{Name="Salep", Price=5.50m},
                    new Food{Name="Milk", Price=3.99m},
                }
            });
            context.Categories.Add(new Category
            {
                Name = "Coffees",
                Foods = new System.Collections.Generic.List<Food>()
                {
                    new Food{Name="Latte(Normal(Caramel)/Iced(Caramel))", Price=3.99m},
                    new Food{Name="Americano", Price=5.50m},
                    new Food{Name="Turkish Coffee", Price=7.99m},
                }
            });
            context.Categories.Add(new Category
            {
                Name = "Teas",
                Foods = new System.Collections.Generic.List<Food>()
                {
                    new Food{Name="Green Tea", Price=2.99m},
                    new Food{Name="Fruit Tea(Orange, Apple, Lemon, Strawberry, Blackberry, Blueberry)", Price=5.50m},
                    new Food{Name="Black Tea", Price=3.99m},
                }
            });
            //TABLE ITEMS-----------------------------------------------------------------------
            context.Tables.Add(new Table { TableNumber = 1 });
            context.Tables.Add(new Table { TableNumber = 2 });
            context.Tables.Add(new Table { TableNumber = 3 });
            context.Tables.Add(new Table { TableNumber = 4 });
            context.Tables.Add(new Table { TableNumber = 5 });
            context.Tables.Add(new Table { TableNumber = 6 });
            context.Tables.Add(new Table { TableNumber = 7 });
            context.Tables.Add(new Table { TableNumber = 8 });
            context.Tables.Add(new Table { TableNumber = 9 });
            context.Tables.Add(new Table { TableNumber = 10 });
            context.Tables.Add(new Table { TableNumber = 11 });
            context.Tables.Add(new Table { TableNumber = 12 });
            context.Tables.Add(new Table { TableNumber = 13 });
            context.Tables.Add(new Table { TableNumber = 14 });
            context.Tables.Add(new Table { TableNumber = 15 });
            context.Tables.Add(new Table { TableNumber = 16 });
            context.Tables.Add(new Table { TableNumber = 17 });
            context.Tables.Add(new Table { TableNumber = 18 });
            context.Tables.Add(new Table { TableNumber = 19 });
            context.Tables.Add(new Table { TableNumber = 20 });
            context.Tables.Add(new Table { TableNumber = 21 });
            context.Tables.Add(new Table { TableNumber = 22 });
            context.Tables.Add(new Table { TableNumber = 23 });
            context.Tables.Add(new Table { TableNumber = 24 });
            context.Tables.Add(new Table { TableNumber = 25 });
            context.Tables.Add(new Table { TableNumber = 26 });
            context.Tables.Add(new Table { TableNumber = 27 });
            context.Tables.Add(new Table { TableNumber = 28 });
            context.Tables.Add(new Table { TableNumber = 29 });
            context.Tables.Add(new Table { TableNumber = 30 });

            base.Seed(context);
        }
    }
}