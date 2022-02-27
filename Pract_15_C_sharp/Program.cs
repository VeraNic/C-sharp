Console.WriteLine("");
Console.WriteLine("___________________________");
Console.WriteLine("15. Дано число. Проверить кратно ли оно 7 и 23");
Console.WriteLine("___________________________");
Console.WriteLine("");
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write("Данное число кратно 7 и 23");
}
else Console.Write("Данное число не кратно 7 и 23");
Console.WriteLine("");