Console.WriteLine("Enter your number");
int N = Convert.ToInt32(Console.ReadLine());
PrintCubicTable(N);

void PrintCubicTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        double num_cube = Math.Pow(i, 3);
        Console.WriteLine("--------+-----------");
        string column1 = "| " + i;
        column1 = column1.PadRight(8);
        string column2 = "| " + num_cube;
        column2 = column2.PadRight(10);
        Console.WriteLine(column1 + column2 + " |");
    }
}

// public class Sem3Dop5
// {
//     static void Main(string[] args)
//     {
//         Console.Clear();
//         Console.WriteLine(
//             "Задача 5. Дан массив средних температур (массив заполняется случайно) за последние 10 лет. На ввод подают номер месяца и год начала и конца."
//         );
//         Console.WriteLine(
//             "Определить самые высокие и низкие температуры для лета, осени, зимы и весны в заданном промежутке. Если таких температур нет, сообщить, что определить не удалось."
//         );
//         Console.WriteLine("________________________________________________________");
//         Console.WriteLine("");

//         Random rand = new Random();

//         int[] ArrayDays = new int[10  * 365 + 2];


//         for (int i = 0; i < 3; i++)
//         {


//         }

//         Console.WriteLine("Массив из ста случайных чисел от 1 до 100: ");




//     }
// }
