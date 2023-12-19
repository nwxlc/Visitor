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

    public void Accept(Visitor visitor)
    {
        List<MenuComponent> components = new List<MenuComponent>();
        MenuComponent root = _root;

        while (root != null || components.Count > 0)
        {
            while (root != null)
            {
                components.Add(root);
                root = root.IsNext() ? root.Next() : null;
            }

            int lastIndex = components.Count - 1;
            root = components[lastIndex];
            components.RemoveAt(lastIndex);

            root.Accept(visitor);
            root = root.IsNext() ? root.Next() : null;
        }
        
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