Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 февраля 2022 года.");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

Console.WriteLine("Введите год, номер месяца и день рождения человека:");
Console.Write("год: ");
int year = int.Parse(Console.ReadLine()); 
Console.Write("месяц: ");
int month = int.Parse(Console.ReadLine());
Console.Write("день: ");
int day = int.Parse(Console.ReadLine());
int age;

if ((month == 2 && day > 1) || month > 2)
{
    age = 2022 - year -1;
}
else
{
age = 2022 - year;
}
Console.WriteLine("Возраст человека, полных лет - " + age + ". ");

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
