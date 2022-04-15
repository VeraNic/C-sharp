int[] A = {1, 3, 5, 7};
int[] B = {4, 5, 6, 7};
int i = 2;
int j = 0;

print(A);
print(B);
Console.WriteLine();
Change(A, B, i, j);
print(A);
print(B);

void Change(int[] A, int[] B, int i, int j)
{
int temp = A[i];
A[i] = B[j];
B[j] = temp;
}

void print(int[] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        Console.Write(A[i] + " ");
    }
    Console.WriteLine();
}

/////////////////////////////////№ 78
int f1 = 1;
int f2 = 1;
int num = 8;

void f(num)
{
if (num > f(n) && num < f(n+1)) Console.Write(f(n) + " " + f(n+1))

}

static int f(int x)
{
    
    if (i >= x)
}