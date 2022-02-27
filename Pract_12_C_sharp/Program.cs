// void Parsing(string str)
// {
//     Console.WriteLine("Введите трёхзначное число: ");
//     string num = Console.ReadLine();

//     return num;
// }
// int n = int.Parse(Console.ReadLine());
// Parsing(n);

Console.WriteLine("___________________________");
Console.WriteLine("Программа удаления второй цифры из трёхзначного числа");
Console.WriteLine("___________________________");

Console.Write("Введите трёхзначное число: ");
int n;
while (true)
{
    n = int.Parse(Console.ReadLine());
    if (n < 100 || n > 999)
    {
        Console.WriteLine("Введено не трёхзначное число!");
        Console.WriteLine("");
        Console.Write("Повторите ввод: ");
    }
    else
    {
        break;
    }
}
int n1 = n / 100;
int n2 = n % 10;

Console.WriteLine(n1 * 10 + n2);

// int num = int.Parse(System.Console.ReadLine());
// System.Console.WriteLine($"{num},  {(num.ToString())[1]}");