public class task2 {

public static void Main(string[] args) {

Console.WriteLine("Максимальное из трёх чисел.");
Console.WriteLine("___________________________");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Большее из этих чисел: " + Math.Max(num1,Math.Max(num2,num3)));

 
}


}
