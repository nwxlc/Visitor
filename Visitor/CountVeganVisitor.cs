namespace Visitor;

internal class CountVeganVisitor : Visitor
{
    public override void Visit(MenuComponent menuComponent)
    {
        if (menuComponent is MenuItem menuItem && menuItem.IsVegan())
        {
            count++;
        }
    }
}