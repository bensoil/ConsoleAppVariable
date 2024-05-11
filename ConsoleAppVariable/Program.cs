void PrintConsole()

{
    var a = 5;
    var b = 3M;
    var sum = a + b;
    Console.WriteLine($"{a} + {b}");
    Console.WriteLine($"= {sum}");

}

PrintConsole();

/*variablen sum måtte være decimal den også, for å kunne holde på var b som allerede var en decimal.*/