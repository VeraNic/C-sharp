Random rnd = new Random();
int M = rnd.Next(1, 21); 
int N = rnd.Next(1, 21);

textTask(); 
 
if (M > N) 
{
    Console.Write($"M = {M}; N = {N}. -> "); Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"M > N, the solution is impossible. "); Console.ResetColor();
    while (M > N) 
    {
        M = rnd.Next(1, 11); 
        N = rnd.Next(1, 11);
    } 
}

Console.Write($"M = {M}; N = {N}. -> "); Console.ForegroundColor = ConsoleColor.Green;
PrintNumbers3(M, N);
if (M == N && M % 3 != 0) Console.WriteLine($"no numbers. ");
Console.WriteLine("\n"); Console.ResetColor(); Console.ReadKey();

void PrintNumbers3(int i, int n)
{   if (i < n + 1) 
    {
        if (i % 3 == 0) 
        {
        Console.Write(i); if (n - i >= 3) Console.Write(", ");
        }
        PrintNumbers3(i + 1, n);
    }
}

void textTask()
{Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(new string('_', Console.WindowWidth)); 
Console.WriteLine("Знакомство с языками программирования. Семинар 9.\n" + 
"\nЗадача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа, кратные 3-ём в промежутке от M до N.\n" +
"M = 1; N = 9. -> 3, 6, 9 \n" + "M = 13; N = 20. -> 15, 18 \n");
Console.WriteLine(new string('_', Console.WindowWidth) + "\n"); Console.ResetColor();
}
