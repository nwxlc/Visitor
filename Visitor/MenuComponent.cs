namespace Visitor;

internal abstract class MenuComponent
{
    protected string name;
    protected List<MenuComponent> _menuComponents = new List<MenuComponent>();
    private int i = 0;
    
    public MenuComponent(string name)
    {
        this.name = name;
    }

    public abstract void Accept(Visitor visitor);
    public abstract void Add(MenuComponent component);
    public abstract void Remove(MenuComponent component);

    public virtual void Print()
    {
        Console.WriteLine(name);
    }
    
    public bool IsNext()
    {
        return _menuComponents.Count >= i;
    }
    
    public MenuComponent Next()
    {
        if (!_menuComponents[i].IsNext())
        {
            i++;
        }

        if (_menuComponents.Count == i)
        {
            i++;
            return this;
        }

        return _menuComponents[i].IsNext()
            ? _menuComponents[i].Next()
            : throw new Exception("Дошли до конца");
    }
}