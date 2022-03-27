Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 4. Дополнительные задачи.");Console.WriteLine();
Console.WriteLine("Задача 1. На вход подаётся натуральное десятичное число."); 
Console.WriteLine("Проверьте, является ли оно палиндромом в двоичной записи.");
Console.WriteLine("________________________________________________________"); Console.WriteLine();

Console.Write("- Введите натуральное десятичное число: ");
int x = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(x, 2); 
Console.WriteLine();
Console.WriteLine("Это число в двоичной записи: " + s);
Console.WriteLine();

string answer = "Оно не является палиндромом в двоичной записи"; 
for (int i = 0; i < s.Length / 2; i++)
{
    if (s[i] == s[s.Length - 1 - i]) 
    {
        answer = "Оно является палиндромом в двоичной записи";
    }
     else break;
}
Console.Write(answer);