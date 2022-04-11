int n = 4; 
int rows = n;
int columns = n;

textTask();
double[,] array = new double[rows, columns];
FillArray2(array); Console.WriteLine("The array: \n"); 
PrintArray2(array); Console.WriteLine(new string('_', 10 * columns)); Console.WriteLine("");
ChangeArray2(array);
Console.WriteLine("The changed array: \n"); Console.ForegroundColor = ConsoleColor.Green; 
PrintArray2(array); Console.ResetColor();
Console.ReadKey();

void textTask()
{
Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(new string('_', Console.WindowWidth)); 
Console.WriteLine("Знакомство с языками программирования. Семинар 8. Дополнтельные задачи.\n" + 
"\nЗадача 54: 1. Дан двумерный массив. Заменить в нём элементы первой строки элементами главной диагонали. А элементы последней строки, элементами побочной диагонали.");
Console.WriteLine(new string('_', Console.WindowWidth) + "\n"); Console.ResetColor();
}

void FillArray2(double[,] matrix2)
{   Random rnd = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            matrix2[i, j] = Math.Round((rnd.NextDouble() * 200 - 100), 2); 
}

void PrintArray2(double[,] matrix2)
{for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            Console.Write("{0, 10}", (matrix2[i, j]).ToString("0.00"));
            Console.WriteLine("\n");
        } 
    Console.WriteLine();
}

void ChangeArray2(double[,] matrix2)
{   (matrix2[0, n -1], matrix2[n - 1, n - 1]) = (matrix2[n - 1, n - 1], matrix2[0, n -1]); // обмен значений правых концов диагоналей
    for (int j = 1; j < n - 1; j++)
        {
        matrix2[0, j] = matrix2[j, j];
        matrix2[n - 1, n - j -1] = matrix2[j, n - j -1];
        }
}
