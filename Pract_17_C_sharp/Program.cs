Console.WriteLine("");
Console.WriteLine("___________________________");
Console.WriteLine("По двум заданным числам проверять является ли одно квадратом другого");
Console.WriteLine("___________________________");
Console.WriteLine("");
Console.Write("Введите первое число: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double n2 = Convert.ToDouble(Console.ReadLine());

if (n1 == n2 * n2) Console.Write("Первое число является квадратом второго. ");
if (n2 == n1 * n1) Console.Write("Второе число является квадратом первого. ");
if (n1 != n2 * n2 && n2 != n1 * n1) Console.Write("Ни одно из чисел не является квадратом другого.");