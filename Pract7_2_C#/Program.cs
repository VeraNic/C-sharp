Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 7. "); Console.WriteLine();
Console.WriteLine("Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,");
Console.WriteLine("и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("________________________________________________________"); Console.WriteLine();

Console.WriteLine("Введите размер двумерного массива m x n: ");
Console.Write("- количество строк" + "\t" + "m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("- количество столбцов" + "\t" + "n = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckAdress(m, n, FillArray(m, n)));
Console.ForegroundColor = ConsoleColor.White;
Console.Write(""); Console.ReadLine();

static double[,] FillArray(int m, int n)
{
    double[,] arr = new double[m, n];
    Random random = new Random();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = Math.Round((random.NextDouble() * 200 - 100), 2);
            Console.Write("{0, 10}", (arr[i, j]).ToString("0.00"));
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
    return arr;
}

static string CheckAdress(int m, int n, double[,] array)
{
    Console.WriteLine("Введите позиции элемента в двумерном массиве: ");
    Console.Write("- номер строки" + "\t" + "m = ");
    int m0 = Convert.ToInt32(Console.ReadLine());
    Console.Write("- номер столбца" + "\t" + "n = ");
    int n0 = Convert.ToInt32(Console.ReadLine()); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("");

    if (m0 >= 0 && m0 <= m - 1 && n0 >= 0 && n0 <= n - 1)
        return "Значение этого элемента: " + Convert.ToString(array[m0, n0]);
    else
        return "Такого элемента нет. ";
}
