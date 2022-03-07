Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("Дано натуральное число, в котором все цифры различны. ");
Console.WriteLine("Определить, какая цифра расположена в нем левее: ");
Console.WriteLine("максимальная или минимальная.");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.Write("Введите натуральное число, в котором все цифры различны: ");
long number = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("");

long digit = number % 10;
long maxdigit = number % 10;
long mindigit = number % 10;
string result = "Максимальная цифра расположена левее, чем минимальная.";

long i = number;
while (i > 0)
{
    digit = i % 10;
    if (digit < mindigit) 
    {
        mindigit = digit;
        result = "Минимальая цифра расположена левее, чем максимальная.";
    }
    if (digit > maxdigit) 
    {
        maxdigit = digit;
        result = "Максимальная цифра расположена левее, чем минимальная.";
    }
    i = i / 10;
}
Console.Write(result);