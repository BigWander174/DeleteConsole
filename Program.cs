using DeleteConsole;

Console.WriteLine("Введите операцию: ");

string operation = Console.ReadLine();

var parser = new Parser(operation);

var cyclebuilder = new CycleBuilder(parser);

cyclebuilder.Work();