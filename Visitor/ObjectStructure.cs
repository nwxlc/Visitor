namespace Visitor;

internal class ObjectStructure
{
    private MenuComponent _root;

    public ObjectStructure(MenuComponent root)
    {
        ArgumentNullException.ThrowIfNull(root);
        _root = root;
    }
    
    public void Accept(Visitor visitor)
    {
        List<MenuComponent> components = new List<MenuComponent>();
        MenuComponent? root = _root;

        while (root?.IsNext() ?? false)
        {
            var menuComponent = root.Next();
            visitor.Visit(menuComponent);
            //
            // while (root != null)
            // {
            //     components.Add(root);
            //     root = root.IsNext() ? root.Next() : null;
            // }
            //
            // int lastIndex = components.Count - 1;
            // root = components[lastIndex];
            // components.RemoveAt(lastIndex);
            //
            // root.Accept(visitor);
            // root = root.IsNext() ? root.Next() : null;
        }
    }
}