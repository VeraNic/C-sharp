int quantity = 15;

int rows, columns, layers;
rows = columns = layers = int.MaxValue; 
Random rnd = new Random();
while (rows * columns * layers > 30)         // ограничение случайного количества строк, столбцов, слоёв 
{                                            // трёхмерного массива максимальным количеством  элементов
rows = rnd.Next(1, quantity);                       
columns = rnd.Next(1, quantity);                    
layers = rnd.Next(1, quantity);
}

double n = int.MaxValue; double m = int.MaxValue;
while (n >= m)
{
n = Math.Round((rnd.NextDouble() * 200 - 100), 2);                       
m = Math.Round((rnd.NextDouble() * 200 - 100), 2);
}

textTask();
Console.WriteLine($"n = {n}\nm = {m}\n");
Console.WriteLine($"Random parameters of the array: layers = {layers}, rows = {rows}, columns = {columns}\n");
double[,,] array3 = new double[layers, rows, columns];
FillArray3(array3, n, m);
PrintArray3(array3);
Console.ReadKey(); 

void FillArray3(double[,,] matrix3, double x1, double x2)
{   
    for (int k = 0; k < matrix3.GetLength(0); k++)
        for (int i = 0; i < matrix3.GetLength(1); i++)
            for (int j = 0; j < matrix3.GetLength(2); j++)
            {
                matrix3[k, i, j] = rnd.NextDouble() * (m - n) + n;
            }    
}

void PrintArray3(double[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.Write("{0, 10}", (matrix[k, i, j]).ToString("0.00"));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void textTask()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(new string('_', Console.WindowWidth));
    Console.WriteLine(
        "Знакомство с языками программирования. Урок 11. C#: от простого к практике. Практическое задание\n"
            + "\nЗадача 1. На вход подуются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m]."
    ); 
    Console.WriteLine(new string('_', Console.WindowWidth) + "\n");
    Console.ResetColor();
}
