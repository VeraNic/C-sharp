public class task1 {

public static void Main(string[] args) {

Console.WriteLine("Сравним 2 числа.");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()); 

if (num1 == num2) Console.Write("Эти числа равны: " + num1 + " = " + num2);
else if (num1 < num2) Console.Write("Большее из этих чисел: " + num2 + ". Меньшее из этих чисел: " + num1);
else Console.Write("Большее из этих чисел: " + num1 + ". Меньшее из этих чисел: " + num2);
}
}