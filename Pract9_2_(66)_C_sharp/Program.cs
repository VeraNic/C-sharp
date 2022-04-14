int M = 1; int M1 = 4; 
int N = 15; int N1 = 8;

textTask(); 
Console.Write($"M = {M}; N = {N} -> {SumNumbers(M, N)}\n");
Console.Write($"M = {M1}; N = {N1} -> {SumNumbers(M1, N1)}\n");
Console.WriteLine("\n"); Console.ResetColor(); Console.ReadKey();

static int SumNumbers(int i, int n) // RECURSION
{   int sum = i;
    if (i < n) 
    {
        sum += SumNumbers(i + 1, n);
    }
    return sum;
}

void textTask()
{Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(new string('_', Console.WindowWidth)); 
Console.WriteLine("Знакомство с языками программирования. Семинар 9.\n" + 
"\nЗадача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. \n" +
"M = 1; N = 15 -> 120 \n" + "M = 4; N = 8. -> 30");
Console.WriteLine(new string('_', Console.WindowWidth) + "\n"); Console.ResetColor();
}
