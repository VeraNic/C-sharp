Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("27. Определить количество цифр в числе");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("");
int count = 0;
int i = num;
while (i > 0)
    { 
    i =i/10;
    count++;
    }
Console.Write("Количество цифр в числе " + num + " равно " + count);

