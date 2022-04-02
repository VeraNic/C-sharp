Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 6. Дополнительные задачи."); Console.WriteLine();
Console.WriteLine("Задача 3. Дано число N. Используя рекурсию, определите, что оно является степенью числа 3.");
Console.WriteLine("________________________________________________________"); Console.WriteLine();

check(number());

static void check(int n)
{   
    if (n % 3 == 0 && n >= 3) return check(n / 3); 
    else return (n % 3 == 0);
}

static int number() 
{   
    Console.WriteLine("Введите число: N = ");
    int N = Convert.ToInt32(ReadLine());
    return N;
}



