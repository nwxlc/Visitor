namespace Visitor;

internal class CountSectionVisitor : Visitor
{
    private int _countSection;
    
    public void Visit(MenuComponent menuComponent)
    {
        if (menuComponent.GetType() is MenuSection)
        {
            _countSection++;
        }
    }

    public int GetCount()
    {
        return _countSection;
    }
    
}