Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 7. "); Console.WriteLine();
Console.WriteLine("Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("________________________________________________________"); Console.WriteLine();

Random random = new Random();
int m = random.Next(2,16);
int n = random.Next(2,16);

ArithmeticMeanOfColumns(m, n, FillArray(m, n)); 
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(""); Console.ReadLine();

static int[,] FillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random random = new Random();
    Console.WriteLine();
    Console.WriteLine("Двумерный массив из целых чисел: "); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.Next(-99, 100);
            Console.Write("{0, 10}", arr[i, j]);
        }
        Console.WriteLine();Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
    return arr;
}

void ArithmeticMeanOfColumns(int m, int n, int[,] array)
{
Console.WriteLine(new string('_',10*n)); Console.WriteLine(""); 
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: "); 
Console.WriteLine(""); Console.ForegroundColor = ConsoleColor.Yellow;

for (int i = 0; i < n; i++)
    {
        double arc = 0;
        for (int j = 0; j < m; j++)
        {
            arc += array[j, i];
        }
        arc = arc/2;
        Console.Write("{0, 10}", (arc).ToString("0.0"));
    }
    Console.ForegroundColor = ConsoleColor.White;
}

