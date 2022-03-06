//Определить третью цифру, или сообщить, что ее нет
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int count = 0;
int i = num;
while (i > 0)
{
    i = i / 10;
    count++;
}
int delitel = (int)(Math.Pow(10,count - 3));

int digit3 = (num / delitel) % 10;

Console.Write("Третья цифра числа равна " + digit3);
