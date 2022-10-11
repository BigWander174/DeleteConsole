namespace DeleteConsole
{
    internal class Parser
    {
        private int _number;
        private int _shiftCount;
        private int _rule;

        public Parser(string operation)
        {
            int indexOfDirection = GetDirectionIndex(operation);

             var shift = operation[indexOfDirection];

            _number = Convert.ToInt32(operation.Substring(0, indexOfDirection));

            _shiftCount = Convert.ToInt32(operation.Substring(indexOfDirection + 2));

            _rule = Constants.shift[shift];
        }

        public int ShiftCount => _shiftCount;
        public string Rule => _rule.ToEightBitBinary();

        public int[] FirstLine =>
            _number.ToEightBitBinary().Select(symbol => Convert.ToInt32(symbol.ToString())).ToArray();

        private int GetDirectionIndex(string operation)
        {
            if (operation.Contains("<<"))
            {
                return operation.IndexOf('<');
            }
            else
            {
                return operation.IndexOf('>');
            }
        }
    }
}
