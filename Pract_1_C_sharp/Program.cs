public class task1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("___________________________");
        Console.WriteLine("Проверка, является ли первое число квадратом второго.");
        Console.WriteLine("___________________________");

        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 == num2 * num2)
        {
            Console.Write("Число " + num1 + " явлется квадратом числа " + num2);
        }
        else
        {
            Console.Write("Число " + num1 + " не явлется квадратом числа " + num2);
        }
    }
}