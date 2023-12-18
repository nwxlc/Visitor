namespace Visitor;

internal abstract class MenuComponent
{
    protected string name;

    public MenuComponent(string name)
    {
        this.name = name;
    }
    
    public void Accept(Visitor visitor)
    {
        visitor.Visit(this);
    }
    
    public virtual void Add(MenuComponent component) { }
 
    public virtual void Remove(MenuComponent component) { }
 
    public virtual void Print()
    {
        Console.WriteLine(name);
    }
}