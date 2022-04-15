int m = 5;

textTask();
Console.Write("m = " + m + " >> ");
Sequence(m);
Console.WriteLine("\n"); 
Console.ReadKey();
 
void Sequence(int n, int i = 1, int count = 0)
{
    if (n == 0)
        return;
    n--;
    count++;
    if (count > i)
    {
        i++;
        count = 1;
    }
    Console.Write(i);
    if (i < n + i)
        Console.Write(", ");
    Sequence(n, i, count);
}

void textTask()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(new string('_', Console.WindowWidth));
    Console.WriteLine(
        "Знакомство с языками программирования. Урок 10. Практическое задание\n"
            + "\n1. Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... \n" + "Дано число m. Выведите первые m членов этой последовательности.\n"
            + "m = 5 >> 1, 2, 2, 3, 3"
    );
    Console.WriteLine(new string('_', Console.WindowWidth) + "\n");
    Console.ResetColor();
}