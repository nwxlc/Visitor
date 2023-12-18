namespace Visitor;

internal abstract class Visitor
{
    protected int count;
    
    public abstract void Visit(MenuComponent menuComponent);

    public int GetCount()
    {
        return count;
    }
}