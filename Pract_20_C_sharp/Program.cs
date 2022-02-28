Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("20. Задать номер четверти, показать диапазоны для возможных координат");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");
Console.Write("Введите номер четверти (1, 2, 3, 4): ");
byte n = Convert.ToByte(Console.ReadLine());

switch (n)
{
    case 1:
        Console.Write("x > 0, y > 0");
        break;
    case 2:
        Console.Write("x < 0, y > 0");
        break;
    case 3:
        Console.Write("x < 0, y < 0");
        break;
    case 4:
        Console.Write("x > 0, y < 0");
        break;
    default:
        Console.Write("Координатной четверти с таким номером не существует!");
        break;
}
