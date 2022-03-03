Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число.");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.Write("Введите натуральное трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

while (number < 100 || number > 999)
{
    Console.Write("Введённое значение не соответствует условию! Повторите ввод: ");
number = int.Parse(Console.ReadLine());
}
int digital1 = number % 10;
int digital2 = number / 10 % 10;
int digital3 = number / 100;

int result = digital1 * 100 + digital2 * 10 + digital3;

Console.Write("Перевёрнутое число: " + result);
