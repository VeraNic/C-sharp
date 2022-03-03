Console.WriteLine("");
Console.WriteLine("___________________________");
Console.WriteLine(
    "Дано число, обозначающее день недели. Выяснить, является он выходным."
);
Console.WriteLine("___________________________");
Console.WriteLine("");
Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n == 7)
    Console.Write("Этот день недели является выходным.");
else
    Console.Write("Этот день недели не является выходным.");
