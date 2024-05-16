using chap4studio;

MenuItem menuItem1 = new MenuItem(1.00, "delicious", "dessert", false);
MenuItem menuItem2 = new MenuItem(3.00, "tasty", "appetizer", true);

List<MenuItem> menuItems = [menuItem1];

Menu menu = new Menu(menuItems);

Console.WriteLine(menu.LastUpdated);
menu.AddMenuItem(menuItem2);
menu.LastUpdated = 
Console.WriteLine(menu.MenuItems);
Console.WriteLine(menu.LastUpdated);