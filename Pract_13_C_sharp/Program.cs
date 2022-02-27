Console.WriteLine("___________________________");
Console.WriteLine("Проверка числа на кратность заданному.");
Console.WriteLine("___________________________");
Console.WriteLine("");
Console.Write("Чему равно заданное число? ");
int cons = int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
int var = int.Parse(Console.ReadLine());
Console.WriteLine("");

if (var % cons == 0)
{
Console.WriteLine("Число " + var + " кратно числу " + cons);
}
else
{
    Console.WriteLine("Число " + var + " не кратно числу " + cons + ". Остаток от деления равен " + var % cons);
}