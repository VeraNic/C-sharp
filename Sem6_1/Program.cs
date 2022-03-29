Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 6. "); Console.WriteLine();
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры М чисел. ");
Console.WriteLine("Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("________________________________________________________"); Console.WriteLine();

task41();

void task41()
{
Console.Write("Введите количество чисел: М = ");
int M = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("");

Console.Write("Введите " + M);
int wm = M % 10;
switch (wm)
        {
            case 1:
                Console.WriteLine(" положительное или отрицательное число: ");
                break;
            case 2:
                Console.WriteLine(" положительных или отрицательных числа: ");
                break;
            case 3:
                Console.WriteLine(" положительных или отрицательных числа: ");
                break;
            case 4:
                Console.WriteLine(" положительных или отрицательных числа: ");
                break;
            
            default: Console.WriteLine(" положительных или отрицательных чисел: ");
                break;
        }

int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write(i + 1  + ") "); int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0) count++;    
}
Console.WriteLine("________________________________________________________");
Console.WriteLine("Количество чисел больше 0: " + count);
}
Console.ReadLine();
