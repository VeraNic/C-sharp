Console.Clear(); 
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 7. Дополнительные задачи."); Console.WriteLine();
Console.WriteLine("Задача 1. Даны две матрицы, количество строк и столбцов которых может быть 3 или 4, заполнены числами от -9 до 9. Выполните умножение матриц.");
Console.WriteLine("Дополнительный материал по задаче: https://portal.tpu.ru/SHARED/k/KONVAL/Sites/Russian_sites/1/04.htm");
Console.WriteLine("________________________________________________________"); 

int x = 3;
int y = 4;

Random random = new Random();  // Задание размеров матриц случайным образом:
int m = random.Next(x, y + 1); // число строк матрицы 1,
int l = random.Next(x, y + 1); // число столбцов матрицы 1 = число строк матрицы 2,
int n = random.Next(x, y + 1); // число столбцов матрицы 2.

int[,] A = FillArray(m, l);
int[,] B = FillArray(l, n);

Console.WriteLine("Первая матрица A (" + m + "x" + l + "):\n"); Print(A);
Console.WriteLine("\nВторая матрица B (" + l + "x" + n + "):\n"); Print(B);

Console.WriteLine(new string('_', 8 * Math.Max(l, n)));

int[,] C = Multiplication(A, B);
Console.WriteLine("\nПроизведение матриц AB (" + m + "x" + n + "):\n"); Print(C);
Console.Read();

static int[,] FillArray(int x, int y)
{
    int[,] matrix = new int[x, y];
    Random random = new Random();
    Console.WriteLine(); 

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = random.Next(-9, 10);           
        }
    }
    return matrix;
}

static void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0, 8}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

static int[,] Multiplication(int[,] a, int[,] b)
{int[,] AB = new int[a.GetLength(0), b.GetLength(1)];

Parallel.For(0, a.GetLength(0), (i) =>
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        for (int k = 0; k < b.GetLength(0); k++)
        {
            AB[i,j] += a[i,k] * b[k,j];
        }
    }
});

return AB;
}
