Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 5. Дополнительные задачи."); Console.WriteLine();
Console.WriteLine("Задача 3. Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений. ");
Console.WriteLine("Подсчитайте их количество. ");
Console.WriteLine("________________________________________________________"); Console.WriteLine();

count();
////////////////////////// ДОРЕШИВАЮ...
static void main count()
{
    int result = 0;
for (int i = 1; i < 1000000; i++)
{
    if (sumdigits(i) * 3 == multdigits(n)) result++;
}
return result;
}

static void sumdigits(int n)
{

}

static void multdigits(int n)
{

}

