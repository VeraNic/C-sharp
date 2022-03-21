Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine(
    "Задача 25. Напишите цикл, который принимает на вход два натуральных числа (А и В) и возводит число А в степень В."
);
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.Write("Введите натуральное число - основание степени: A = ");
long A = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите натуральное число - показатель степени: B = ");
long B = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("");

long power = A;
for (int i = 1; i < B; i++)
{
    power *= A;
}
Console.Write("А в степени В равно " + power);
Console.WriteLine("");
