Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 5. Дополнительные задачи."); Console.WriteLine();
Console.WriteLine("Задача 2. На вход подаются два числа случайной длины. ");
Console.WriteLine("Найдите произведение каждого разряда первого числа на каждый разряд второго. Ответ запишите в массив.");
Console.WriteLine("________________________________________________________"); Console.WriteLine();

Console.Write("Два числа случайной длины: "); Console.ForegroundColor = ConsoleColor.Yellow;
string number1 = number();
string number2 = number();
Console.WriteLine(number1 + "; " + number2); Console.ForegroundColor = ConsoleColor.White; Console.Write("");

multiplication(number1, number2); Console.ForegroundColor = ConsoleColor.White;

Console.Read();

static string number()
{
    int limit = 22; //максимальная длина случайного числа
    string digits = "0123456789";
    Random rand = new Random();
    int len = rand.Next(1, limit);
    string n = "";
    for (int i = 0; i < len; i++)
    {
        string d = digits.Substring(rand.Next(0, 10), 1);
        n = n + d;
    }
    return n;//случайное число длиной от 1 до limit   
}

void multiplication(string n1, string n2)
{
Console.WriteLine("");
Console.Write("Массив произведений разрядов этих чисел: "); Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("{");

int len1 = n1.Length;
int len2 = n2.Length;
int[] array = new int[len1 * len2]; 
int i = 0;
    for (int j = 0; j < len1; j++)
    {
     for (int k = 0; k < len2; k++)
        {
        int d1 = Convert.ToInt32(n1.Substring(j, 1));
        int d2 = Convert.ToInt32(n2.Substring(k, 1));
        array[i] = d1 * d2; 
        Console.Write(array[i]); 
        if (i < (len1-1) * (len2-1)-1) Console.Write("; ");
        }
    }i++;
Console.WriteLine("}"); 
}


