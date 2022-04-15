int n = 10;

textTask();
Console.Write(n + " >> ");
AllDivisors(n);
Console.WriteLine("\n");
Console.ReadKey();

void AllDivisors(int i, int divisor = 1)
{
    if (i == 1)
        return;

    divisor++;
    if (i % divisor == 0)
    {
        Console.Write(divisor);
        if (divisor < i)
            Console.Write(", ");
        else
            Console.Write(". ");

        i /= divisor;
        divisor = 1;
    }
    AllDivisors(i, divisor);
}

void textTask()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(new string('_', Console.WindowWidth));
    Console.WriteLine(
        "Знакомство с языками программирования. Урок 10. Практическое задание\n"
            + "\n3. Дано натуральное число n > 1. Вывести все простые множители данного числа. \n"
            + "10 >> 5, 2.\n"
            + "12 >> 2, 2, 3."
    );
    Console.WriteLine(new string('_', Console.WindowWidth) + "\n");
    Console.ResetColor();
}
