namespace Visitor;

internal class Menu : MenuComponent
{
    // private List<MenuComponent> _menuComponents = new List<MenuComponent>();
    private string _name;
    private MenuComponent _root;

    public Menu(string name) : base(name)
    {
        _name = name;
    }

    public override void Accept(Visitor visitor)
    {
        foreach (var component in  _menuComponents)
        {
            component.Accept(visitor);
        }
    }

    public override void Add(MenuComponent component)
    {
        ArgumentNullException.ThrowIfNull(component);
        _menuComponents.Add(component);
    }
 
    public override void Remove(MenuComponent component)
    {
        ArgumentNullException.ThrowIfNull(component);
        _menuComponents.Remove(component);
    }
    
    public override void Print()
    {
        Console.WriteLine(_name);
        //nwolc
        foreach (MenuComponent component in _menuComponents)
        {
            component.Print();
        }
    }
}