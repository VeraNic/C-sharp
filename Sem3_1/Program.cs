Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("По номеру четверти плоскости, определить диапазон координат Х и У, причем X <> 0 и Y <> 0");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.Write("Введите номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random ();
Console.WriteLine("");
if (n == 1) 
{
    Console.WriteLine("Диапазон: x > 0, y > 0. Примеры координат точек:");
    for (int i = 0; i < 10; i++)
    {
    Console.WriteLine("x = " + rand.Next(1, 100) + ", y = " + rand.Next(1, 100));
    }
}
if (n == 2) 
{
    Console.WriteLine("Диапазон: x < 0, y > 0. Примеры координат точек:");
    for (int i = 0; i < 10; i++)
    {
    Console.WriteLine("x = " + -1 * rand.Next(1, 100) + ", y = " + rand.Next(1, 100));
    }
}
if (n == 3) 
{
    Console.WriteLine("Диапазон: x < 0, y < 0. Примеры координат точек:");
    for (int i = 0; i < 10; i++)
    {
    Console.WriteLine("x = " + -1 * rand.Next(1, 100) + ", y = " + -1 * rand.Next(1, 100));
    }
}
if (n == 4) 
{
    Console.WriteLine("Диапазон: x > 0, y < 0. Примеры координат точек:");
    for (int i = 0; i < 10; i++)
    {
    Console.WriteLine("x = " + rand.Next(1, 100) + ", y = " + -1 * rand.Next(1, 100));
    }
}
