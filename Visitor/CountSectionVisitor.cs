namespace Visitor;

internal class CountSectionVisitor : Visitor
{
    
    public override void Visit(MenuComponent menuComponent)
    {
        if (menuComponent.GetType() is MenuSection)
        {
            count++;
        }
    }
}