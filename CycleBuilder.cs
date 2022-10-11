namespace DeleteConsole
{
    internal class CycleBuilder
    {
        private List<int[]> _cycles =  new List<int[]>();
        private int _t;
        private string _rule;
        private int _length;

        public CycleBuilder(Parser settings)
        {
            _cycles.Add(settings.FirstLine);
            _t = settings.ShiftCount;
            _rule = settings.Rule;
            _length = _cycles.First().Length;
        }

        public void Work()
        {
            Build();
            Show();
        }

        private void Show()
        {
            foreach (var cycle in _cycles)
            {
                foreach (var element in cycle)
                {
                    Console.Write(element);
                }

                Console.WriteLine();
            }
        }

        private void Build()
        {
            for (int i = 1; i < _t + 1; i++)
            {
                _cycles.Add(GetNewLine(i - 1));
            }
        }

        private int[] GetNewLine(int previousLineIndex)
        {
            var result = new int[_length];

            FillLeftValue(ref result, previousLineIndex, 0);
            FillRightValue(ref result, previousLineIndex, _length - 1);
            FillCalculatedValue(ref result, _length - 2, previousLineIndex);
            return result;
        }

        private void FillCalculatedValue(ref int[] result, int length, int previousLineIndex)
        {
            for (int i = 1; i < length; i++)
            {
                result[i] = Calculate(previousLineIndex, i);
            }
        }

        private int Calculate(int lineIndex, int i)
        {
            int multiplier = 4;
            int ruleIndex = 0;
            for (int t = i - 1; t < i + 2; t++)
            {
                ruleIndex += _cycles[lineIndex][t] * multiplier;
                multiplier /= 2;
            }

            return Convert.ToInt32(_rule[ruleIndex].ToString());
        }

        private void FillRightValue(ref int[] result, int v, int index)
        {
            if (int.Parse(Converter.ToDecimal(_rule)) == 170)
            {
                result[index] = 0;
            }
            else
            {
                result[index] = _cycles[v][index - 1];
            }
        }

        private void FillLeftValue(ref int[] result, int v, int index)
        {
            if (int.Parse(Converter.ToDecimal(_rule)) == 170)
            {
                result[index] = _cycles[v][index + 1];
            }
            else
            {
                result[index] = 0;
            }
        }
    }
}
