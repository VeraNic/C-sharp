Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine(
    "Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе."
);
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.Write("Введите число: ");
string number = Console.ReadLine();
long sum = 0;
int d = number.Length;
for (int i = 0; i < d; i++)
{
    string symbol = number.Substring(i, 1);
    byte digit = Convert.ToByte(symbol);
    sum = sum + digit;
    d = number.Length;
}
Console.Write("Сумма цифр в числе " + number + " равна " + sum +  ".");
