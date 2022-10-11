namespace DeleteConsole
{
    internal static class Validator
    {
        public static int GetValidRule(int rule)
        {
            int maximumNumber = (int)Math.Pow(2, Constants.AmountOfBits);

            return (rule > maximumNumber) ? maximumNumber : rule;
        }

        //public static int GetValidT(int T)
        //{
        //    int maximumCycles = Convert.ToInt32((_le - 1) / 2);

        //    return (T > maximumCycles) ? maximumCycles : T;
        //}
    }
}
