public class task3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("___________________________");
        Console.WriteLine("Выод названия дня недели по его номеру.");
        Console.WriteLine("___________________________");

        Console.Write("Введите номер дня недели: ");
        int n = Convert.ToInt32(Console.ReadLine());

        switch (n)
        {
            case 1:
                Console.Write("Понедельник");
                break;
            case 2:
                Console.Write("Вторник");
                break;
            case 3:
                Console.Write("Среда");
                break;
            case 4:
                Console.Write("Четверг");
                break;
            case 5:
                Console.Write("Пятница");
                break;
            case 6:
                Console.Write("Суббота");
                break;
            case 7:
                Console.Write("Воскресенье");
                break;
            default: Console.Write("Дня недели с таким номером не существует!");
                break;
        }
    }
}
