Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(new string('_', Console.WindowWidth)); 
Console.WriteLine("Знакомство с языками программирования. Семинар 8. \n" + 
"\nЗадача 54: Задайте двумерный массив." + 
"\nНапишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива."); Console.WriteLine(new string('_', Console.WindowWidth) + "\n"); Console.ResetColor();

int rows, columns;
rows = columns = int.MaxValue; 
Random rnd = new Random();
rows = rnd.Next(2, 20);                      
columns = rnd.Next(2, 20);
Console.WriteLine($"Random parameters of the array: rows = {rows}, columns = {columns}\n");


double[,] array = new double[rows, columns];
FillArray2(array);
PrintArray2(array); Console.WriteLine(new string('_', 10 * columns)); Console.WriteLine("");
SortArray2(array);
Console.WriteLine("The array with the rows ordered in descending order: \n"); Console.ForegroundColor = ConsoleColor.Green; 
PrintArray2(array); Console.ResetColor();
Console.ReadKey();


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

void SortArray2(double[,] matrix2)
{for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1) - 1; j++)
            for (int k = 0; k < matrix2.GetLength(1) - 1; k++)
                if (matrix2[i, k] < matrix2[i, k + 1]) 
                    (matrix2[i, k], matrix2[i, k + 1]) = (matrix2[i, k + 1], matrix2[i, k]);
}