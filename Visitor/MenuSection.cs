namespace Visitor;

internal class MenuSection : MenuComponent
{
    public MenuSection(string name)
        :base(name)
    {}
    
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
        Console.WriteLine(name);
 
        foreach (MenuComponent component in _menuComponents)
        {
            component.Print();
        }
    }
    
    public override void Accept(Visitor visitor)
    {
        visitor.Visit(this);
    }
}