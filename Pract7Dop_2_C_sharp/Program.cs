Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 7. Дополнительные задачи.");
Console.WriteLine();
Console.WriteLine("Задача 2. Двумерный массив размером 3х4 заполнен числами от 100 до 9999. ");
Console.WriteLine(
    "Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых больше их произведения. "
);
Console.WriteLine("Выведите оба массива.");
Console.WriteLine("________________________________________________________");

int x = 3;
int y = 4;
int min = 100;
int max = 9999;

int[,] array = FillArray(x, y, min, max);
Console.WriteLine("\nДвумерный массив размером 3х4, заполненный числами от 100 до 9999: \n");
Print2(array);

string check = CheckArray(array);

int[] a = check.Split(' '). // Перевод строки из чисел с пробелами в одномерный массив - 
          Where(x => !string.IsNullOrWhiteSpace( x )). // см. материал:
          Select(x => int.Parse(x)).ToArray(); // https://ru.stackoverflow.com/questions/451166/Конвертация-массива-string-в-массив-int-c-одной-строкой-кода 

Console.WriteLine("\nОдномерный массив всех чисел, сумма цифр которых больше их произведения: ");
Print1(a);

Console.WriteLine("");
Console.ReadKey();


static int[,] FillArray(int x, int y, int min, int max)
{
    int[,] matrix = new int[x, y];
    Random random = new Random();

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }
    return matrix;
}

static string CheckArray(int[,] matrix)
{
    int count = 0;
    string result = String.Empty;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            int sum = 0;
            int mult = 1;
            while (matrix[i, j] > 0)
            {
                sum += matrix[i, j] % 10;
                mult *= matrix[i, j] % 10;
                matrix[i, j] = matrix[i, j] / 10;
            }
            if (sum > mult)
            {
                count++;
                result += Convert.ToString(temp) + " "; //+ " (" + count + ". " + sum + "|" + mult + "); "; // TODO: можно проверить работу поиска нужных чисел
            }
        }
    }
    // Console.WriteLine(result); // TODO: проверка нахождения чисел
    return result;
}

static void Print1(int[] matrix)
{
    Console.Write("{");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(matrix[i]);
        if (i < matrix.GetLength(0) - 1) Console.Write("; ");
        else Console.Write("}");
    }
}

static void Print2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0, 8}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
