int findIteam = 5;

int rows, columns; // Случайное количество строк/столбцов двумерного массива, 
Random rnd = new Random(); // вмещающихся в окно вывода
if (Console.WindowHeight - 13 < 3) rows = 2;
    else rows = rnd.Next(2, Console.WindowHeight - 13); 
if (Console.WindowWidth / 2 - 1 < 3) columns = 2;
    else columns = rnd.Next(2, Console.WindowWidth / 2 - 1); 

textTask();
Console.WriteLine($"Количество строк двумерного массива: {rows}, количество столбцов: {columns}. \n");
int[,] array2 = new int[rows, columns];
GetArray2(array2);
PrintArray2(array2);
findItemArray2(array2, findIteam);
Console.ReadKey(); 

void findItemArray2(int[,] matrix2, int iteam, int quantityFindIteam = 0)
{   
    for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            if (matrix2[i, j] == iteam) quantityFindIteam++;
    Console.WriteLine($"{new string('_', 2*matrix2.GetLength(1) - 1)}\n\nКоличество элементов массива, равных {iteam}: {quantityFindIteam}");
    Console.WriteLine($"Сумма элементов массива, равных {iteam}: {quantityFindIteam * iteam}\n");
}

void GetArray2(int[,] matrix2)
{   
    Random rnd = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
                matrix2[i, j] = rnd.Next(1, 10);  
}

void PrintArray2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
                Console.Write(matrix2[i, j] + " ");
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
            + "\nЗадача 2. Двумерный массив заполнен случайными натуральными числами от 1 до 10. Найдите количество элементов, значение которых больше 5, и их сумму. "
    ); 
    Console.WriteLine(new string('_', Console.WindowWidth) + "\n");
    Console.ResetColor();
}
