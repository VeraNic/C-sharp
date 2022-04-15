int m = 3;
int n = 2;

textTask();
Console.Write($"n = {n}; m = {m} -> A(n, m) = {Ackerman(m, n)}\n");
Console.WriteLine("\n");
Console.ResetColor();
Console.ReadKey();

static int Ackerman(int n, int m) // RECURSION
{
    if (n == 0)
        return m + 1;
    if (n != 0 && m == 0)
        return Ackerman(n - 1, 1);
    if (n > 0 && m > 0)
        return Ackerman(n - 1, Ackerman(n, m - 1));
    return Ackerman(n, m);
}

void textTask()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(new string('_', Console.WindowWidth));
    Console.WriteLine(
        "Знакомство с языками программирования. Семинар 9.\n"
            + "\nЗадача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. \n"
            + "m = 2, n = 3 -> A(n,m) = 29"
    );
    Console.WriteLine(new string('_', Console.WindowWidth) + "\n");
    Console.ResetColor();
}
