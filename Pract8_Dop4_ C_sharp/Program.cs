Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine(new string('_', Console.WindowWidth)); 
Console.WriteLine("Знакомство с языками программирования. Семинар 8. Дополнительные задачи.\n" + 
"\nЗадача 4. Заполните двумерный массив 3х3 числами от 1 до 9 змейкой.");
// 1  6  7
// 2  5  8
// 3  4  9

Console.WriteLine(new string('_', Console.WindowWidth) + "\n"); Console.ResetColor();

int n = 3; // Количество строк, столбцов массива n x n
int number = 1; // первый элемент массива

//Begin
Print2(SnakeArray2(n, number));
Console.WriteLine("\n"); Console.ReadKey();
//End.

int[,] SnakeArray2(int n, int number)
{
int[,]array = new int[n,n];
int row = 0; int column = 0; // строка и столбец текущего элемента массива
while (column < n)
{
    if (column % 2 == 0) for (row = 0; row < n; row++) array[row, column] = number++; // чётная вертикаль, сверху вниз
    else for (row = n - 1; row >= 0; row--) array[row, column] = number++; // нечётная вертикаль, снизу вверх 
column++;
}
return array;
}

void Print2(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}
