Console.WriteLine("___________________________");
Console.WriteLine("14. Определение третьей цифры числа.");
Console.WriteLine("___________________________");
Console.WriteLine("");

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine()); 
num = Math.Abs(num);

string str ="";
str = Convert.ToString(num);

if (str.Length < 3)
{
    Console.WriteLine("Во введённом числе нет третьей цифры.");
}
else Console.WriteLine($"Третья цифра числа равна {str[2]}");