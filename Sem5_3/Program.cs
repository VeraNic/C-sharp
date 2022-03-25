Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Задача 38: Задайте массив вещественных чисел. ");
Console.WriteLine("Найдите разницу между максимальным и минимальным элементами массива.");
Console.WriteLine("________________________________________________________"); Console.WriteLine("");

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); 

Console.Write("Массив вещественных чисел: ");
Console.Write("[");
double[] array = new double[length];
Random rand = new Random(DateTime.Now.Millisecond);
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((rand.NextDouble() * 99 - 50), 2);
    Console.Write(array[i]);
    if (i < length - 1 ) Console.Write("; ");
}
double max = array[0]; double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
}
Console.WriteLine("]"); Console.WriteLine("");
Console.Write("Разница между максимальным и минимальным элементами массива: " + max + " - ");
if (min < 0) Console.Write("("); Console.Write(min); if (min < 0) Console.Write(")"); 
Console.Write(" = " + Math.Round((max - min), 2));