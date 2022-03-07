public class Sem3Dop7
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(
            "Задача 7. Из центра координат к точке А(x, y) проведён отрезок АО. Напишите программу, определяющую наименьший угол наклона отрезка AO к оси X."
        );
        Console.WriteLine("________________________________________________________");
        Console.WriteLine("");
        Console.WriteLine("Введите координаты точки А:");
        Console.Write("x = "); double x = double.Parse(Console.ReadLine());
        Console.Write("y = "); double y = double.Parse(Console.ReadLine());

        double tg = Math.Abs(y/x);
        //Console.WriteLine("tg AOX = " + Math.Round(tg, 1));
        double angle = Math.Atan(tg);
        double gradus = (angle * 180) / Math.PI;

        Console.Write("Меньший угол наклона отрезка AO к оси X составляет ");
        if (Math.Round((angle * 180) / Math.PI - gradus) != 0) Console.Write("приближённо ");
        Console.Write((Math.Round(gradus, 1) + " градусов, или " + (Math.Round(angle, 1)) + " радиан."));
        





    }
}
