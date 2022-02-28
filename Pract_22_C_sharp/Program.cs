Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("22. Найти расстояние между точками в пространстве 2D/3D");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");
Console.WriteLine("Выберите размерность пространства:");
Console.WriteLine("2D - введите '2'");
Console.WriteLine("3D - введите '3'");
Console.Write("Ваш выбор: ");
byte D = Convert.ToByte(Console.ReadLine());
Console.WriteLine("");

if (D == 2)
{
    Console.WriteLine("Введите координаты первой точки: ");
    Console.Write("X1 = ");
    double X1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y1 = ");
    double Y1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите координаты второй точки: ");
    Console.Write("X2 = ");
    double X2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y2 = ");
    double Y2 = Convert.ToDouble(Console.ReadLine());
    
    double rast = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
    Console.Write("d = " + rast);
}

if (D == 3)
{
    Console.WriteLine("Введите координаты первой точки: ");
    Console.Write("X1 = ");
    double X1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y1 = ");
    double Y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Z1 = ");
    double Z1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите координаты второй точки: ");
    Console.Write("X2 = ");
    double X2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y2 = ");
    double Y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Z2 = ");
    double Z2 = Convert.ToDouble(Console.ReadLine());

    double rast = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
    Console.Write("d = " + rast);
}
