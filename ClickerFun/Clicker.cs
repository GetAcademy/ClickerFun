namespace ClickerFun
{
    internal class Clicker
    {
        private int _count;
        private readonly ConsoleKey _key;

        public Clicker(ConsoleKey key)
        {
            _count = 0;
            _key = key;
        }

        public void Click(ConsoleKey selectedKey)
        {
            if (selectedKey == _key)
            {
                _count++;
            }
        }

        public void Show()
        {
            Console.WriteLine(_key + ": " + _count);
        }
    }
}
