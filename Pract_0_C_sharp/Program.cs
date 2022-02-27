public class task0 
{
public static void Main(string[] args) 
{
Console.WriteLine("___________________________");
Console.WriteLine("Вывод квадрата введённого с клавиатуры числа.");
Console.WriteLine("___________________________");

Console.Write("Введите число: ");

double N = Convert.ToDouble(Console.ReadLine()); 

Console.Write(N * N);

}
}