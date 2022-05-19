using ClickerFun;

// Pause til 13:46

//var clickers = Enumerable
//    .Range(65, 26)
//    .Select(n => new Clicker((ConsoleKey) n));

var clickers = new Clicker[26];
for (var charNo = 65; charNo <= 90; charNo++)
{
    var index = charNo - 65;
    clickers[index] = new Clicker((ConsoleKey)charNo);
}

//var clickers =
//    new[]
//    {
//        new Clicker(ConsoleKey.A),
//        new Clicker(ConsoleKey.B),
//        new Clicker(ConsoleKey.C),
//        new Clicker(ConsoleKey.D),
//        new Clicker(ConsoleKey.E),
//    };

while (true)
{
    var consoleKeyInfo = Console.ReadKey();
    Console.Clear();
    foreach (var clicker in clickers)
    {
        clicker.Click(consoleKeyInfo.Key);
    }
    foreach (var clicker in clickers)
    {
        clicker.Show();
    }
}

//int countT = 0;
//int countU = 0;

//while (true)
//{
//    var consoleKeyInfo = Console.ReadKey();
//    Console.Clear();
//    if (consoleKeyInfo.Key == ConsoleKey.T)
//    {
//        countT++;
//    }
//    else if (consoleKeyInfo.Key == ConsoleKey.U)
//    {
//        countU++;
//    }
//    Console.WriteLine($"T: {countT}");
//    Console.WriteLine($"U: {countU}");
//}