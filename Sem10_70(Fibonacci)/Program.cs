static void Fibonacci(int first, int second, int count)
    {
        if (count == 0)
        {
            Console.WriteLine();
            return;
        }
        else
        {
            Console.Write(first + " ");
            (first, second) = (second, first + second);
            Fibonacci(first, second, --count);
        }
    }
