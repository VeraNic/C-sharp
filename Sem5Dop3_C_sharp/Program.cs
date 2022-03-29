Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 5. Дополнительные задачи.");
Console.WriteLine();
Console.WriteLine(
    "Задача 3. Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений. "
);
Console.WriteLine("Подсчитайте их количество. ");
Console.WriteLine("________________________________________________________");
Console.WriteLine();

Console.WriteLine(
    "Все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений: "
);
int result = 0;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();

for (int i = 1; i < 1000000; i++)
{
    if (sumdigits(i) * 3 == multdigits(i))
    {
        Console.Write(i + " ");
        result++;
    }
}
Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("________________________________________________________"); Console.WriteLine();
Console.Write(
    "Количество чисел от 1 до 1000000, сумма цифр которых в три раза меньше их произведений: "
);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(result);
Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;
Console.Read();

static int sumdigits(int number)
{
    string n = Convert.ToString(number);
    int sum = 0;
    for (int i = 0; i < n.Length; i++)
    {
        sum += Convert.ToInt32(n.Substring(i, 1));
    }
    return sum;
}

static int multdigits(int number)
{
    string n = Convert.ToString(number);
    int multiplication = 1;
    for (int i = 0; i < n.Length; i++)
    {
        multiplication *= Convert.ToInt32(n.Substring(i, 1));
    }
    return multiplication;
}
