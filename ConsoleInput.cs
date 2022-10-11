namespace DeleteConsole
{
    internal class ConsoleInput
    {
        public static int GetInfo(string variableName)
        {
            Console.WriteLine($"Введите {variableName}: ");

            int number;
            while (int.TryParse(Console.ReadLine(), out number) == false)
            {

            }

            return number;
        }
    }
}
