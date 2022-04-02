// Задача 51: Задайте двумерный массив. Найдите сумму элементов диагонали.

Random rnd = new Random();
double sum = 0;
int m = 4, 
n = 3, 
sign_min = 0, 
sign_max = 10;
double[,] array = new double[m,n];

FillArray(); 
PrintArray();
Sum();


void Sum()
{
    for (int i=0; i < m; i++)
    {
        for (int j=0; j < n; j++)
        {
            if (i == j) sum += array[i, j];
        }
    }Console.WriteLine();
    Console.WriteLine(sum);
}

void FillArray()
{
    Console.WriteLine();
    for (int i=0; i < m; i++)
    {
        for (int j=0; j < n; j++)
        {
            array[i,j] = rnd.Next(sign_min, sign_max);
        }
    }
}

void PrintArray()
{
    Console.WriteLine("Двумерный массив: ");
    for (int i=0; i < m; i++)
    {
        for (int j=0; j < n; j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
