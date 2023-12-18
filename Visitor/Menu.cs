namespace Visitor;

internal class Menu //: MenuComponent
{
    private List<MenuComponent> _menuComponents = new List<MenuComponent>();
    private string _name;

    public Menu(string name)
    {
        _name = name;
    }

    public void Accept(Visitor visitor)
    {
        foreach (MenuComponent menuComponent in _menuComponents)
            menuComponent.Accept(visitor);
    }
    
    public void Add(MenuComponent component)
    {
        ArgumentNullException.ThrowIfNull(component);
        _menuComponents.Add(component);
    }
 
    public void Remove(MenuComponent component)
    {
        ArgumentNullException.ThrowIfNull(component);
        _menuComponents.Remove(component);
    }
    
    public void Print()
    {
        Console.WriteLine(_name);
        //nwolc
        foreach (MenuComponent component in _menuComponents)
        {
            component.Print();
        }
    }
}