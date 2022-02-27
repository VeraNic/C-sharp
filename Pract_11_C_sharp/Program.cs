Console.WriteLine("___________________________");
Console.WriteLine("Показать наибольшую цифру числа, введённого из отрезка [10, 99]");
Console.WriteLine("___________________________");

Console.Write("Введите число из отрезка [10, 99]: ");
int n;
while (true)
{
    n = int.Parse(Console.ReadLine());
    if (n < 10 || n > 99)
    {
        Console.WriteLine("");
        Console.WriteLine("Введено число не из отрезка [10, 99]!");
        Console.Write("Повторите ввод: ");
    }
    else
    {
        break;
    }
}
int n1 = n / 10;
int n2 = n % 10;

if (n1 > n2)
{
    Console.WriteLine(n1 + "- наибольшая цифра.");
}
else 
{Console.WriteLine(n2 + "- наибольшая цифра.");
}