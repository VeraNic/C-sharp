Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("25. Найти сумму чисел от 1 до А");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");
Console.Write("Введите натуральное число А = ");
int A = int.Parse(Console.ReadLine());

int counter = 1;
int sum = 0;
while (counter <= A)
    { 
    sum = sum + counter;
    counter++;
    }
Console.WriteLine("");
Console.Write("Сумма чисел от 1 до " + (counter - 1) + " равна " + sum);