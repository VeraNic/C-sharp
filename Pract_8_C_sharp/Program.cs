public class task4 
{
public static void Main(string[] args) 
{
Console.WriteLine("___________________________");
Console.WriteLine("Вывод всех чётных чисел до введённого с клавиатуры.");
Console.WriteLine("___________________________");
Console.Write("Введите целое число: ");

int N = Convert.ToInt32(Console.ReadLine()); 
int counter = 1;

while (counter <= N)
{
if (counter % 2 == 0) 
{
    Console.Write(counter + " ");
}
counter ++;
}
}
}
