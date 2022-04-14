int n = 6; 
int rows = n;
int columns = n;

// Begin 
textTask();
double[,] array = new double[rows, columns];
FillArray2(array); Console.WriteLine("The array: \n"); 
PrintArray2(array); Console.WriteLine(new string('_', 10 * columns)); Console.WriteLine("");
ChangeArray2(array);
Console.WriteLine("The changed array: \n"); Console.ForegroundColor = ConsoleColor.Green; 
PrintArray2(array); Console.ResetColor();
Console.ReadKey();
// End.

void textTask()
{Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(new string('_', Console.WindowWidth)); 
Console.WriteLine("Знакомство с языками программирования. Семинар 8. Дополнтельные задачи.\n" + 
"\Задача 3. Найти минимальный по модулю элемент. Удалить столбец и диагонали, содержащие его.");
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

double[,] ChangeArray2(double[,] matrix2, out )
{   int x; int y; // Координаты элемента с минимальным модулем
    double minABS = matrix2[0, 0];
    for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            if (minABS > matrix2[i, j]) 
            {
                minABS = matrix2[i, j];
                x = i; y = j;
            }    
    double[,] сhangedArray = new double[rows - , columns]; // https://bstudy.net/htm/img/4/12146/97.png
    for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            if (matrix2[i, j]) 




    
}
 