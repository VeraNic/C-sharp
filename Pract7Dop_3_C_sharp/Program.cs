Console.Clear();
Console.WriteLine("________________________________________________________\n" +
"Знакомство с языками программирования. Семинар 7. Дополнительные задачи.\n" + 
"\nЗадача 3. Двумерный массив размером 5х5 заполнен случайными нулями и единицами. \n" +
"Игрок может ходить только по полям, заполненным единицами. Проверьте, существует ли путь из точки [0, 0] в точку [4, 4] (эти поля требуется принудительно задать равными единице).\n" +
"________________________________________________________\n");

int x = 5;
int y = 5;

int[,] array = FillArray(x, y, 0, 1);
array[0, 0] = 1;
array[4, 4] = 1;
Console.WriteLine("\nДвумерный массив размером 5х5, заполненный случайными нулями и единицами: \n");
Print2(array); 

Console.WriteLine("\n"); Console.ReadKey();




static int[,] FillArray(int x, int y, int min, int max)
{
    int[,] matrix = new int[x, y];
    Random random = new Random();

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }
    return matrix;
}

static void Print2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

