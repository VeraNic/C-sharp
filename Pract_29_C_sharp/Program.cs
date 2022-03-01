Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("29. Написать программу вычисления произведения чисел от 1 до N");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");
Console.Write("Введите число: N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("");

int number = 1;
int factorial = 1;
while (number <= N)
{
    factorial = factorial * number;
    number++;
}
Console.Write("Произведение чисел от 1 до N равно " + factorial);
