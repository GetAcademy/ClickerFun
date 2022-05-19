namespace ClickerFun
{
    internal class CountCharsDemo
    {
        public void Run()
        {
            var charCounter = new CharCounter();
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                charCounter.Count(text);
                charCounter.Show();
            }

            //var range = 250;
            //var counts = new int[range];
            //string text = "something";
            //while (!string.IsNullOrWhiteSpace(text))
            //{
            //    text = Console.ReadLine();
            //    Count(text, counts);
            //    Show(range, counts);
            //}
        }
    }
}
