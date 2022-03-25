Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. ");
Console.WriteLine("Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); 
int counter = 0;

Console.Write("Массив, заполненный случайными положительными трёхзначными числами: ");
Console.Write("[");
int[] array = new int[length];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
    Console.Write(array[i]); if (i < length - 1 ) Console.Write("; ");
    if (array[i] % 2 == 0) counter +=1;
}
Console.WriteLine("]"); Console.WriteLine("");
Console.WriteLine("Количество чётных чисел в массиве: " + counter);