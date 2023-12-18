namespace Visitor;


internal class MenuItem : MenuComponent
{
    private bool _isVegan;

    public MenuItem(string name, bool isVegan)
        : base(name)
    {
        _isVegan = isVegan;
    }

    public bool IsVegan()
    {
        return _isVegan;
    }
    
    public override void Add(MenuComponent component)
    {
        throw new Exception("Блюдо нельзя добавить");
    }

    public override void Remove(MenuComponent component)
    {
        throw new Exception("Блюдо нельзя удалить");
    }
}