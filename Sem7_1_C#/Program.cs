static void Main Program()
{

Console.WriteLine("Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n. Выведите полученный массив на экран.");


int m = 3;
int n = 5;

int [,] array = new int [m, n];

FillArray();

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        array[i,j] = i + j;
        Console.Write(array[i,j] + " ");
      }  
      Console.WriteLine();
    }
}