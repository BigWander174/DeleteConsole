namespace DeleteConsole
{
    internal class Constants
    {
        public const int AmountOfBits = 8;

        public static Dictionary<char, int> shift = new Dictionary<char, int>()
        {
            { '<', 170 },
            { '>', 240 }
        };
    }
}
