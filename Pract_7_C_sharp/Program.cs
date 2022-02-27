public class task7
{
    public static void Main(string[] args)
    {
        Console.WriteLine("___________________________");
        Console.WriteLine("Вывод чисел от -N до N.");
        Console.WriteLine("___________________________");

        Console.Write("Введите целое число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        
    

        for (int i = 0; i <= n; ++i)
        {
            Console.Write(i + " ");
        }
    }
}