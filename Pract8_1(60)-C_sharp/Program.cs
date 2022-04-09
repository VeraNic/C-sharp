Console.Clear();
Console.WriteLine("________________________________________________________\n" + "Знакомство с языками программирования. Семинар 8. \n" + 
"\nЗадача 60:  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая построчно выведет элементы и их индексы. \n" + "________________________________________________________\n");

PrintArray3(FillArray3());

static int [,,] FillArray3()
{
Random rnd = new Random();
int rows = rnd.Next(2, 10); int columns = rnd.Next(2, 10); int layers = rnd.Next(2, 10);
Console.WriteLine($"layers = {layers}, rows = {rows}, columns = {columns}\n");

int[,,] array = new int[columns, rows, layers];
    for (int k = 0; k < layers; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[k, i, j] = rnd.Next(10, 100);
            }
        }
    }
    return array;
}

void PrintArray3(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
           for (int j = 0; j < array.GetLength(1); j++)
        { 
            Console.Write($"{array[k, i, j]} ({k}, {i}, {k})\t");
        } 
        Console.WriteLine(" ");
    }
    Console.WriteLine("\n");
}
}
