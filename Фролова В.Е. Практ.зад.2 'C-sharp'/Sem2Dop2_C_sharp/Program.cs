Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine(
    "Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 февраля 2022 года."
);
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.WriteLine("Введите год, номер месяца и день рождения человека:");
Console.Write("год: ");
int year = int.Parse(Console.ReadLine());
Console.Write("месяц: ");
int month = int.Parse(Console.ReadLine());
Console.Write("день: ");
int day = int.Parse(Console.ReadLine());
int age = AgeCalculation(year, month, day);

Console.WriteLine("Возраст человека, полных лет - " + age + ". ");

int AgeCalculation(int y, int m, int d)
{
    int age;
    if ((m == 2 && d > 1) || m > 2)
    {
        return age = 2022 - y - 1;
    }
    else
    {
        return age = 2022 - y;
    }
}

// Уточнение вывода, сколько дней, месяцев, лет прошло
// int agem = month;
// int agey = year;
// if (day > 1)
// {
//    int aged = 32 - day;
//    int agem = month - 1;
// }
// else aged = 1 - day;

// if (month > agem)
// {
//    int aged = 32 - day;
//    int agem = month - 1;
// }
// else aged = 1 - day;
