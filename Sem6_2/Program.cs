Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 6. ");
Console.WriteLine();
Console.WriteLine("Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, ");
Console.WriteLine(
    "заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем."
);
Console.WriteLine("________________________________________________________");
Console.WriteLine();

Console.WriteLine("Введите коэффициенты уравнений прямых y = k1 * x + b1, y = k2 * x + b2: ");
getCoefficients(out double k1, out double b1, out double k2, out double b2);
analysis(k1, b1, k2, b2, out string res); Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow; 
Console.WriteLine(res); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(); Console.ReadLine();

static void getCoefficients(out double k1, out double b1, out double k2, out double b2)
{
    Console.Write("k1 = ");
    k1 = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("b1 = ");
    b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("k2 = ");
    k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b2 = ");
    b2 = Convert.ToDouble(Console.ReadLine());
}

static void analysis(double k1, double b1, double k2, double b2, out string result)
{
    if (k1 == k2 && b1 == b2)
        result = "Прямые совпадают dj всех своих точках. ";
    else if (k1 == k2)
        result = "Точки пересечения нет, прямые параллельны. ";
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        result =
            "Точка пересечения прямых: (" + x + "; " + y + ") ";
    }
}
