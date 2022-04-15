const int minValue = 100;
const int maxValue = 999;
const int minSize = 3;
const int maxSize = 7;
void FillArray(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue +1 );
        }
    }
}
void Print2DArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }    
}
void PrintDiagonal (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            else
            {
                Console.Write($"  \t");
            }
        }
        Console.WriteLine();
    }    
}
Console.Clear();
Random rand = new Random();
int size = rand.Next(minSize, maxSize + 1);
int[, ] matrix = new int[size, size];
FillArray(matrix);
Print2DArray(matrix);
Console.WriteLine();
PrintDiagonal(matrix);
