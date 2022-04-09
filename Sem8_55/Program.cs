// Задача 55
Random rnd = new Random();
int cols = rnd.Next(2,10);
int rows = rnd.Next(2,10);
int[,] array = new int[rows,cols];
int[,] arrvv = new int[cols,rows];

FillArr(array);
PrintArr(array);
int min = array[0, 0];
MathArr();
int t = cols;
cols = rows;
rows = t;
PrintArr(arrvv);

static void MathArr(int cols, int[,] array, int rows, int min, out int m, out int n)
{    
    for (int j=0; j < cols; j++)
    { 
        for (int i=0; i < rows; i++)
        {
            if (min > array[i,j]) min = array[i,j];
            m = i; n = j;
        }
    }
}



void FillArr(int[,] arr)
{
    Console.WriteLine("+= Заполняем массив =+");
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < cols; j++)
        {
            arr[i,j] = rnd.Next(20);
        }
    }
}

void PrintArr(int[,] arr)
{
    Console.WriteLine("+= Вывод в консоль массива =+");
    
    for (int i=0; i < rows; i++)
    {
        for (int j=0; j < cols; j++)
        {
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine(" ");
}