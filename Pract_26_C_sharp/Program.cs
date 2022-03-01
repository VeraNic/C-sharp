Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("26. Возведите число А в натуральную степень B, используя цикл");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");
Console.Write("Введите число А = ");
int A = int.Parse(Console.ReadLine()); 
// Console.WriteLine("");
Console.Write("Введите натуральное число В = ");
int B = int.Parse(Console.ReadLine()); 
Console.WriteLine("");

int counter = 1;
int pow = 1;
while (counter <= B)
    { 
    pow = pow * A;
    counter++;
    }
Console.Write("Число А в степени B " + " равно " + pow);
