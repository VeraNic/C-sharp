Console.Clear();
Console.WriteLine("Знакомство с языками программирования. Семинар 3. Дополнительные задачи.");
Console.WriteLine("Задача 1. На ввод подаётся номер четверти.");
Console.WriteLine("Создаются 3 случайные точки в этой четверти. ");
Console.WriteLine(
    "Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат."
);
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.WriteLine("Введите номер коодинатной четверти (1, 2, 3 или 4): ");
byte quadrant = Convert.ToByte(Console.ReadLine());

Random rand = new Random();

Console.WriteLine("Координаты трёх случайных точек в этой четверти: ");
Console.WriteLine("А1: (" + x1 + ", " + y1 + ")");
Console.WriteLine("А2: (" + x2 + ", " + y2 + ")");
Console.WriteLine("А3: (" + x3 + ", " + y3 + ")");

int absc(byte q)
{
    switch (q)
    {
        case 1:
             
            break;
        case 2:
             
            break;
        case 3:
            
            break;
        case 4:
            
            break;        
        default:
            Console.Write("Дня недели с таким номером не существует!");
            break;
    }
}




// double rast = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
// Console.Write("d = " + rast);
