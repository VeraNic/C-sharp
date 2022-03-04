Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("Задача 3. Иван в январе года открыл счет в банке, вложив 1000 руб. ");
Console.WriteLine("Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы.");
Console.WriteLine("Определить размер депозита через n месяцев.");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");
double a = 1000;
double p = 0.015;  
Console.WriteLine("Начальная сумма вклада: " + a);
Console.WriteLine("Месячная процентная ставка: " + p); Console.WriteLine("");

Console.Write("Срок вклада, в месяцах: ");
byte n = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Размер депозита через " + n + " месяцев: " + a * Math.Pow((1 + p),n));
