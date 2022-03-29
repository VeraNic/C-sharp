// Console.WriteLine("Введите три числа: ");
// Console.Write("a  = "); double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("b  = "); double b = Convert.ToDouble(Console.ReadLine());
// Console.Write("c  = "); double c = Convert.ToDouble(Console.ReadLine());
// if (a < b + c & c < a+b & b<a+c) Console.Write("Да");
// else Console.Write("Нет");

// Console.WriteLine("Введите номер числа Фибоначчи: ");
// Console.Write("N  = ");double N = Convert.ToDouble(Console.ReadLine());
// double F1 = 0; double F2 = 1; 
// Console.WriteLine("F(0) = 0");
// Console.WriteLine("F(1) = 1");
// double F;
// int i = 1;
// while (i < N)
// {
//     F = F1 + F2;
//     F1 = F2;
//     F2 = F;
//     i++;
// Console.WriteLine("F(" + i + ") = " + F);
// }
  
Console.Write("- Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); 

Console.Write("Массив: "); 
double[] array = new double[length];
Random rand = new Random(DateTime.Now.Millisecond);
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((rand.NextDouble() * 200 - 100), 2);
    Console.Write(array[i]);
    if (i < length - 1 ) Console.Write("; ");
}
Console.WriteLine(" "); 
Console.Write("Копия массива: ");  
double[] array1 = new double[length];
 
for (int i = 0; i < length; i++)
{
    array1[i] = array[i];
    Console.Write(array[i] + " ");
}