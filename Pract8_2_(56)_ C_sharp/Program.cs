Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(new string('_', Console.WindowWidth)); 
Console.WriteLine("Знакомство с языками программирования. Семинар 8. \n" + 
"\nЗадача 56: Задайте прямоугольный двумерный массив. \n" + "Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine(new string('_', Console.WindowWidth) + "\n"); Console.ResetColor();

Random rnd = new Random();
int rows = rnd.Next(2, 15);                      
int columns = rnd.Next(2, 15);
Console.WriteLine($"Random parameters of the array: rows = {rows}, columns = {columns}\n");

// Begin
double[,] array = new double[rows, columns];

FillArray2(array);
int numberRoW = RowArray2(array, out numberRoW); 

PrintArray2(array); Console.WriteLine(new string('_', 10 * columns)); Console.WriteLine();
Console.WriteLine("The row " + numberRoW + "has the smallest sum: \n"); Console.ForegroundColor = ConsoleColor.Green; Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
PrintRowArray2(array, numberRoW); Console.ResetColor();
Console.ReadKey();
// End

void FillArray2(double[,] matrix2)
{   for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            matrix2[i, j] = Math.Round((rnd.NextDouble() * 200 - 100), 2); 
}

void PrintArray2(double[,] matrix2)
{for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            Console.Write("{0, 10}", (array[i, j]).ToString("0.00"));
            Console.WriteLine("\n");
        } 
    Console.WriteLine();
}

int RowArray2(double[,] matrix2, out int numberRoW)
{   int j; numberRoW = int.MinValue;
    double sum = 0; double minSum = double.MaxValue;
    for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (j = 0; j < matrix2.GetLength(1); j++) 
                sum += matrix2[i, j]; 
            if (sum < minSum) 
            {
                minSum = sum;
                numberRoW = i;
            }
        } 
    Console.WriteLine(); return numberRoW;
}

void PrintRowArray2(double[,] matrix2, int row)
{   
    for (int j = 0; j < matrix2.GetLength(1); j++)
        Console.Write("{0, 10}", (matrix2[row, j]).ToString("0.00"));
    Console.WriteLine("\n");
}
