Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99."); 
Console.WriteLine("Определите самый часто встречающийся элемент в массиве."); 
Console.WriteLine("Если таких элементов несколько, вывести их все.");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");

int dim = 100;// - МОЖНО ПРОВЕРИТЬ РАБОТУ НА МЕНЬШЕМ КОЛИЧЕСТВЕ ЭЛЕМЕНТОВ МАССИВА)

Console.Write("Массив из " + dim + " элементов, заданный случайными числами от 1 до " + (dim - 1) + ": ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("[");

int[] array = new int[dim];
Random rand = new Random();
for (int i = 0; i < dim; i++)
{
    array[i] = rand.Next(1, dim);
    Console.Write(array[i]); if (i < dim - 1) Console.Write("; ");
}
Console.WriteLine("]"); Console.WriteLine();  

Console.ForegroundColor = ConsoleColor.White;


string moda = Convert.ToString(array[1]);
int[] array1 = new int[dim];//Второй массив для записи уникальных элементов первого
array1[0] = array[0];
int countdif = 0; // Количество найденных уникальных элементов 
int max = 0; // Наибольшая частота повторов очередного элемента
int count = 1; // Текущая подсчитанная частота очередного элемента
byte e = 0;// будет равно 1, если кол-во эл-в, равных данному, уже было подсчитано

for (int i = 0; i < dim; i++)
{
    for (int j = 0; j < countdif; ++j)// Проверка новизны очередного элемента массива
    {
        if (array[i] == array1[j]) e = 1;
    }
    if (e == 0)//Если такой элемент еще не встречался в массиве, будем считать число его повторов и сравнивать с max
    {
        array1[countdif] = array[i];//записываем найденный уникальный элемент во второй массив на первое свободное место слева
        countdif +=1;//увеличиваем количество найденных уникальных элементов на 1
        
        for (int j = i +1; j < dim; j++)// Подсчёт количества повторов элемента array[i] в массиве
            if (array[i] == array[j]) count +=1;
        
        if (count == max) 
        moda = moda + "; '" + Convert.ToString(array[i]) + "'";
        if (count > max) 
        {
            max = count;
            moda = "'" + Convert.ToString(array[i]) + "'";             
        }
    }
    count = 1;
    e = 0;
}
Console.ForegroundColor = ConsoleColor.White; Console.WriteLine();
Console.Write("Cамые часто встречающиеся элементы в массиве: "); 
Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine (moda);
// Console.ForegroundColor = ConsoleColor.White; Console.Write("Количество повторов: ");
// Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(max); 
