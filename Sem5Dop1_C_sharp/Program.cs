Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 5. Дополнительные задачи."); Console.WriteLine();
Console.WriteLine("Задача 1. Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число.");
Console.WriteLine("Напишите программу, которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.");
Console.WriteLine("________________________________________________________"); Console.WriteLine();

int length = 15;
int[] array = new int[length];
int number;

FillArray(array);
Console.Write("Введите трёхзначное натуральное число: "); number = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
Check(array, number);
Console.Read();

void FillArray(int[] table)
{
    Console.Write("Массив из случайных цифр на 15 элементов: ");
    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("{");
    Random rand = new Random();

    for (int i = 0; i < length; i++)
    {
        table[i] = rand.Next(0, 10);
        System.Console.Write(table[i]); if (i < length - 1 ) Console.Write("; ");
    }
    Console.WriteLine("}"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;
}

async void Check(int[] table, int num) 
{
    string st = "";
    string sn = Convert.ToString(num);
    bool e = false;
    for (int i = 0; i < length; i++)
    {
        st += Convert.ToString(table[i]);
    }
    Console.Write("Ответ: "); Console.ForegroundColor = ConsoleColor.Yellow;
    if (st.Contains(sn))
    Console.WriteLine("да");
    else Console.WriteLine("нет");
    Console.ForegroundColor = ConsoleColor.White;
}
