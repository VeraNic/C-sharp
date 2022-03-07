public class Sem3Dop1
{
static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(
            "Знакомство с языками программирования. Семинар 3. Дополнительные задачи."
        );
        Console.WriteLine("Задача 1. На ввод подаётся номер четверти.");
        Console.WriteLine("Создаются 3 случайные точки в этой четверти. ");
        Console.WriteLine(
            "Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат."
        );
        Console.WriteLine("________________________________________________________");
        Console.WriteLine("");

        Console.Write("Введите номер коодинатной четверти (1, 2, 3 или 4): ");
        int quadrant = Convert.ToInt32(Console.ReadLine());
        int cx;
        int cy;
        switch (quadrant)
        {
            case 1:
                cx = 1;
                cy = 1;
                break;
            case 2:
                cx = -1;
                cy = 1;
                break;
            case 3:
                cx = -1;
                cy = -1;
                break;
            case 4:
                cx = 1;
                cy = -1;
                break;
            default:
                cx = 0;
                cy = 0;
                break;
        }
        int d = 10;
        Random random = new Random();
        int x1 = cx * random.Next(d);
        int y1 = cy * random.Next(d);
        int x2 = cx * random.Next(d);
        int y2 = cy * random.Next(d);
        int x3 = cx * random.Next(d);
        int y3 = cy * random.Next(d);

        Console.Write("Созданы три случайные точки в выбранной вами четверти: ");
        Console.Write("А1 (" + x1 + "; " + y1 + "), ");
        Console.Write("А2 (" + x2 + "; " + y2 + "), ");
        Console.WriteLine("А3 (" + x3 + "; " + y3 + ").");
        Console.WriteLine("");
        
        double OA1 = rast(x1, y1, 0, 0);
        double OA2 = rast(x2, y2, 0, 0);
        double OA3 = rast(x3, y3, 0, 0);
        double A1A2 = rast(x1, y1, x2, y2);
        double A2A3 = rast(x2, y2, x3, y3);
        double A1A3 = rast(x1, y1, x3, y3);

        double OA1A2A3 = OA1 + A1A2 + A2A3;
        Console.Write("Варианты маршрутов: OA1A2A3 = " + Math.Round(OA1A2A3, 2));
        double OA1A3A2 = OA1 + A1A3 + A2A3;
        Console.Write(". OA1A3A2 = " + Math.Round(OA1A3A2, 2));
        double OA2A1A3 = OA2 + A1A2 + A1A3;
        Console.Write(". OA2A1A3 = " + Math.Round(OA2A1A3, 2));
        double OA2A3A1 = OA2 + A2A3 + A1A3;
        Console.Write(". OA2A3A1 = " + Math.Round(OA2A3A1, 2));
        double OA3A1A2 = OA3 + A1A3 + A1A2;
        Console.Write(". OA3A1A2 = " + Math.Round(OA3A1A2, 2));
        double OA3A2A1 = OA3 + A2A3 + A1A2;
        Console.WriteLine(". OA3A2A1 = " + Math.Round(OA3A2A1, 2) + ".");
        Console.WriteLine("");

        double bestway1 = Math.Min(OA1A2A3, OA1A3A2);
        double bestway2 = Math.Min(OA2A1A3, OA2A3A1);
        double bestway3 = Math.Min(OA3A1A2, OA3A2A1);
        double bestway = Math.Min(bestway1, bestway2);
        bestway = Math.Min(bestway, bestway3);

        if (bestway == OA1A2A3) Console.Write("Cамый оптимальный маршрут: O - A1 - A2 - A3, ");
        if (bestway == OA1A3A2) Console.Write("Cамый оптимальный маршрут: O - A1 - A3 - A2, ");
        if (bestway == OA2A1A3) Console.Write("Cамый оптимальный маршрут: O - A2 - A1 - A3, ");
        if (bestway == OA2A3A1) Console.Write("Cамый оптимальный маршрут: O - A2 - A3 - A1, ");
        if (bestway == OA3A1A2) Console.Write("Cамый оптимальный маршрут: O - A3 - A1 - A2, ");
        if (bestway == OA3A2A1) Console.Write("Cамый оптимальный маршрут: O - A3 - A2 - A1, ");
        Console.Write("его длина равна " + Math.Round(bestway, 2) + ".");
    }

    public static double rast(int xA, int yA, int xB, int yB)
    {
        return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
    }
}
