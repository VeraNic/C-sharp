int m = 345;

textTask();
Console.Write(m);
mirror(m);
Console.WriteLine("\n"); 
Console.ReadKey();

void mirror(int n, int result = 0) // RECURSION
{
    if (n == 0) 
    {
        Console.Write(" >> " + result);
        return;
    }
    result = result*10 + n % 10;
    n /= 10;
    mirror(n, result);
}

void textTask()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(new string('_', Console.WindowWidth));
    Console.WriteLine(
        "Знакомство с языками программирования. Семинар 10.\n"
            + "\n1. Дано число n. Получите число, записанное в обратном порядке.\n"
            + "345 >> 543\n" + "81 >> 18"
    );
    Console.WriteLine(new string('_', Console.WindowWidth) + "\n");
    Console.ResetColor();
}
