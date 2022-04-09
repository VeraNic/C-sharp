Console.Clear();
Console.WriteLine("________________________________________________________\n" + "Знакомство с языками программирования. Семинар 8. \n" + 
"\nЗадача 62: Заполните спирально массив 4 на 4 числами от 1 до 16. \n" + "________________________________________________________\n");

int n = 4; // Количество строк, столбцов массива n x n
int number = 1; // первый элемент массива

Print2(SpiralArray(n, number));

Console.WriteLine("\n"); Console.ReadKey();

static int[,] SpiralArray(int n, int number)
{
int[,]array = new int[n,n];
int count = 0; // счётчик пройденных витков спирали
int row; int column; // строка и столбец текущего элемента массива
while (number < n*n + 1)
{
    for (column = count; column < n - count; column++) array[count, column] = number++; // верхняя горизонталь витка спирали, слева направо
    for (row = count + 1; row < n - count; row++) array[row, n - count - 1] = number++; // правая вертикаль витка спирали, сверху вниз
    for (column = n - count - 2; column > count; column--) array[n - count - 1, column] = number++; // нижняя горизонталь витка спирали, справа налево
    for (row = n - count - 1; row > count; row--) array[row,count] = number++; // левая вертикаль витка спирали, снизу вверх
count++;
}
return array;
}

static void Print2(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + "\t");
        }
        Console.WriteLine();
    }
}
