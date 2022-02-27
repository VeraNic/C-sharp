public class task10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("___________________________");
        Console.WriteLine("Вывод второй цифры введённого трёхзначного числа.");
        Console.WriteLine("___________________________");

        string str = "";
        Console.Write("Введите целое трёхзначное число: ");
        while (true)
        {
            str = Console.ReadLine();
            if (str.Length != 3)
            {
                Console.WriteLine("Введено не трёхзначное число!");
                Console.WriteLine("Введите целое трёхзначное число: ");
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"Вторая цифра равна {str[1]}"); // Console.WriteLine("Вторая цифра равна " + str[1]); 
            
        // Console.Write("str={0}, {1}", str, ); - собирает строку, пригодится для БД. Environment.UserName - имя User'a
    }
}
