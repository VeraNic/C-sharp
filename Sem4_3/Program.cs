Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine(
    "Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел"
);
Console.WriteLine("и выводит отсортированный по модулю массив.");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.WriteLine("Массив из 8 случайных целых чисел: ");
Console.WriteLine("-------------------------------------------------");

int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-8, 9);
    string number = Convert.ToString(array[i]);
    Console.Write("|" + number.PadLeft(4, ' ') + " ");
}
Console.WriteLine("|");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("");

Console.WriteLine("Отсортированный по модулю массив:");
Console.WriteLine("-------------------------------------------------");
int temp;
for (int i = 1; i < array.Length; i++)
    for (int j = 1; j < array.Length; j++)
    {
        if (Math.Abs(array[j - 1]) > Math.Abs(array[j]))
        {
            temp = array[j - 1];
            array[j - 1] = array[j];
            array[j] = temp;
        }
    }
for (int i = 0; i < array.Length; i++)
{
    string number = Convert.ToString(array[i]);
    Console.Write("|" + number.PadLeft(4, ' ') + " ");
}
Console.WriteLine("|");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("");
