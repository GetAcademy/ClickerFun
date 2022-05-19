namespace ClickerFun
{
    internal class CharCounter
    {
        int[] _counts;

        public CharCounter()
        {
            _counts = new int[250];
        }

        public void Show()
        {
            for (var i = 0; i < _counts.Length; i++)
            {
                if (_counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + _counts[i]);
                }
            }
        }

        public void Count(string? text)
        {
            foreach (var character in text ?? string.Empty)
            {
                _counts[(int)character]++;
            }
        }
    }
}
