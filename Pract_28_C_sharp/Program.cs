Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("28. Подсчитать сумму цифр в числе");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int sum = 0;
int quotient = num;
int digit = 0;
while (quotient > 0)
{
    digit = quotient % 10;
    sum = sum + digit;
    quotient = quotient / 10;
}
Console.Write("Сумма цифр в числе " + num + " равна " + sum);
