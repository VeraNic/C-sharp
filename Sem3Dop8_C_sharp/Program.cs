public class Sem3Dop8
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(
            "Задача 8. Массив из ста элементов заполняется случайными числами от 1 до 100. Удалить из массива все элементы, содержащие число 3. Вывести в консоль новый массив и количество удалённых элементов."
        );
        Console.WriteLine("________________________________________________________");
        Console.WriteLine("");
        int[] Array100 = new int[100];
        int counter3 = 0;
        int i;
        int j;
        Random rand = new Random();
        Console.WriteLine("Массив из ста случайных чисел от 1 до 100: ");
        for (i = 0; i < 100; i++)
        {
            Array100[i] = rand.Next(100);
            Console.Write(i + ") " + Array100[i] + "; ");
            if (Array100[i] == 3)
                counter3++;
        }
        Console.WriteLine("");
        Console.WriteLine("- из данного массива удаляются все элементы, равные ЧИСЛУ 3. ");
        Console.WriteLine("");
        Console.WriteLine("Новый массив: ");
        int[] ArrayN = new int[100 - counter3];
        j = 0;
        int counterd3 = 0;
        for (i = 0; i < 100; i++)
            if (Array100[i] != 3)
            {
                ArrayN[j] = Array100[i];
                Console.Write(j + ") " + ArrayN[j] + "; ");

                if ((ArrayN[j] / 10) == 3 || (ArrayN[j] % 10) == 3)
                    counterd3++;
                j++;
            }
        Console.WriteLine("");
        Console.WriteLine("- количество удалённых элементов: " + counter3 + ". ");
        Console.WriteLine("");

        Console.WriteLine("Из массива удаляются элементы, содержащие ЦИФРУ 3. ");
        Console.WriteLine("Новый массив:");
        int[] ArrayD = new int[100 - counter3 - counterd3];
        i = 0;
        j = 0;
        for (j = 0; j < 100 - counter3; j++)
            if (ArrayN[j] / 10 != 3 && ArrayN[j] % 10 != 3)
            {
                ArrayD[i] = ArrayN[j];
                Console.Write(i + ") " + ArrayD[i] + "; ");
                i++;
            }
        Console.WriteLine("");
        Console.WriteLine("- количество удалённых элементов: " + counterd3 + ". ");
        Console.WriteLine("");
    }
}
