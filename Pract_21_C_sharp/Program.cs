Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("21. Программа проверяет, является ли пятизначное число палиндромом.");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

int n = 0;
while (n < 10000 || n > 99999)
{
    Console.Write("Введите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("");
}
if ((n / 10000 == n % 10) && ((n / 1000 - (n / 10000) * 10) == ((n % 100) - n % 10) / 10))
    Console.WriteLine("Это палиндром.");
else
    Console.WriteLine("Это не палиндром. ");
Console.WriteLine("Крайние цифры: " + n / 10000 + " " + n % 10);
Console.WriteLine(
    ("Вторые по краям цифры: " + (n / 1000 - (n / 10000) * 10) + " " + ((n % 100) - n % 10) / 10)
);
Console.WriteLine("");
Console.WriteLine("");
