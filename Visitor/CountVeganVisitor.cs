namespace Visitor;

internal class CountVeganVisitor : Visitor
{
    private int _countVegan;
    
    public void Visit(MenuComponent menuComponent)
    {
        if (menuComponent is MenuItem menuItem && menuItem.IsVegan())
        {
            _countVegan++;
        }
    }

    public int GetCount()
    {
        return _countVegan;
    }
}