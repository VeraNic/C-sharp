Console.Clear();
Console.WriteLine("Задача 4. Найти в какой четверти лежит точка пересечения из задачи 2 (если вектора пересекаются).");
Console.WriteLine("Задача 2. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD?");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.WriteLine("Введите координаты точки А: ");
Console.Write("x = ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("x = ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки C: ");
Console.Write("x = ");
double xC = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double yC = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки D: ");
Console.Write("x = ");
double xD = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double yD = Convert.ToDouble(Console.ReadLine());

double kAB = (yA - yB) / (xA - xB); // Из уравнения y = kx + b - для прямой АВ
double kCD = (yC - yD) / (xC - xD); // Из уравнения y = kx + b - для прямой CD
if (kAB == kCD)
{
    if (
        (Math.Min(xC, xD) <= Math.Max(xA, xB))
        && (Math.Min(xC, xD) >= Math.Min(xA, xB))
        && (Math.Min(yC, yD) >= Math.Min(yA, yB))
        && (Math.Min(yC, yD) <= Math.Max(yA, yB))
    )
    {
        Console.WriteLine("Отрезки AB и CD частично совпадают. ");
    }
    else
    {
        Console.WriteLine("Отрезки AB и CD не пересекаются. ");
    }
}
else
{
    double bAB = yA - kAB * xA; // Из равенства b = y - kx - для прямой АВ
    double bCD = yC - kCD * xC; // Из равенства b = y - kx - для прямой CD
    double x = (bCD - bAB) / (kAB - kCD); // После вычитания уравнения второй прямой из уравнения первой
    double y = kAB * x + bAB;
    if (
        (x >= Math.Min(xA, xB))
        && (x <= Math.Max(xA, xB))
        && (y >= Math.Min(yA, yB))
        && (y <= Math.Max(yA, yB))
    )
    {
        Console.Write("Отрезки AB и CD пересекаются ");
        if (x > 0 && y > 0) Console.Write("в I четверти. ");
        if (x < 0 && y > 0) Console.Write("во II четверти. ");
        if (x < 0 && y < 0) Console.Write("в III четверти. ");
        if (x > 0 && y < 0) Console.Write("в IV четверти. ");
        if (x == y && x == 0) Console.Write("в центре системы координат. ");
        else 
        {
            if (x == 0) Console.Write("на оси абсцисс. ");
            if (y == 0) Console.Write("на оси ординат. ");
        }
    }
    else
    {
        Console.WriteLine("Отрезки AB и CD не пересекаются. ");
    }
}
