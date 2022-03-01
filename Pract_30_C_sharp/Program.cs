Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("30. Показать кубы чисел, заканчивающихся на четную цифру");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");
Console.Write("Введите N (от 1 до 255): ");
byte N = Convert.ToByte(Console.ReadLine());
Console.WriteLine("");
byte i = 1;
//for (int i = 1; i <= N; ++i)
while (2 * i <= N)
{
    string text = "--------+----------\n";
    text = text + "   " + (2*i) + " \t| " + (i * i * i * 8);
    Console.WriteLine(text);
    i = ++i;
}
Console.WriteLine("--------+----------");
