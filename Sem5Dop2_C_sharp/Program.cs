Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 4. Дополнительные задачи.");Console.WriteLine();
Console.WriteLine("Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц. ");
Console.WriteLine("Размер массива должен совпадать с квадратом количества единиц в нём.");
Console.WriteLine("________________________________________________________"); Console.WriteLine();

Random rand = new Random();
int count1 = rand.Next(1, 10); //Случайное количество единиц в массиве
int length = count1 * count1; //Размер массива равен квадрату единиц
int count0 = length - count1; //Количество нулей равно разности размера массива и количества единиц

Console.WriteLine("Cлучайное количество (от 1 до 100) нулей и единиц в массиве: " + count0 + " и " + count1 + ".");
Console.WriteLine("Размер массива: " + length + "."); Console.Write("");

Massive(count1, count0);

///////////////////////////////////////////////////////////////////////////

void Massive(int c1, int c0)
{
Console.Write("Массив: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("[");
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    if (c0 > 0 & c1 > 0)
    {
        array[i] = rand.Next(0, 2);
        if (array[i] == 0) c0 = c0 - 1;
        if (array[i] == 1) c1 = c1 - 1; 
    }
    else if (c0 == 0) array[i] = 1;
            else array[i] = 0;
    
    if (array[i] == 1) Console.ForegroundColor = ConsoleColor.Green;
    if (array[i] == 0) Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(array[i]); Console.ForegroundColor = ConsoleColor.Yellow;
    if (i < length - 1 ) Console.Write("; ");
}
Console.WriteLine("]"); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.White;
}
