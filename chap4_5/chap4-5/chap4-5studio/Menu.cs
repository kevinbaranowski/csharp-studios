namespace chap4studio;

public class Menu
{
    private List<MenuItem> MenuItems { get; set; } = [];
    private DateTime LastUpdated { get; }

    public Menu(List<MenuItem> menuItems)
    {
        MenuItems = menuItems;
        LastUpdated = DateTime.Now;
    }
}