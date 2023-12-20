using Visitor;

var waffles = new MenuItem("\tВафли с клубникой", false);
var borsch = new MenuItem("\tБорщ", false);
var barbecue = new MenuItem("\tШашлык из курицы", false);
var pancakes = new MenuItem("\tБлинчики с черникой", true);

var meatSection = new MenuSection("Мясо:");
meatSection.Add(barbecue);

var soupsSection = new MenuSection("Супы:");
soupsSection.Add(borsch);

var dessertsSection = new MenuSection("Десерты:");
dessertsSection.Add(pancakes);
dessertsSection.Add(waffles);

var menu = new Menu("\tРесторан");
menu.Add(meatSection);
menu.Add(soupsSection);
menu.Add(dessertsSection);

menu.Print();

CountVeganVisitor countVeganVisitor = new CountVeganVisitor();

var objectStructure = new ObjectStructure(menu);
objectStructure.Accept(countVeganVisitor);

Console.WriteLine($"Число блюд для травоядных: {countVeganVisitor.GetCount()}");

