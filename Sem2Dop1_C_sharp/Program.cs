Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine(
    "Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным."
);
Console.WriteLine("________________________________________________________");
Console.WriteLine("");
Console.Write("Введите значения длин сторон трегольника.");
Console.Write("а = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
Console.Write("c = ");
int c = int.Parse(Console.ReadLine());

if (a + b <= c || a + c <= b || b + c <= a)
{
    Console.Write("Данная фигура не является треугольником.");
}
else
{
    if (a == b || a == c || b == c)
    {
        Console.Write("Треугольник является равнобедренным.");
    }
    else
    {
        Console.Write("Треугольник не является равнобедренным.");
    }
}
