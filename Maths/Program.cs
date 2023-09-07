using Maths;

var menu = new Menu();

var date = DateTime.UtcNow;

var games = new List<string>();

string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");
    string name = Console.ReadLine();
    return name;
}

//Menu(name);
