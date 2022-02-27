public class task9
{
    public static void Main(string[] args)
    {
        Console.WriteLine("___________________________");
        Console.WriteLine("Вывод последней цифры введённого числа.");
        Console.WriteLine("___________________________");

        Console.Write("Введите целое трёхзначное число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Последняя цифра введённого числа равна " + Math.Abs(n % 10));
    }
}