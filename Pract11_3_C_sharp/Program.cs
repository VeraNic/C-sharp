multipleVerification();

void multipleVerification()
{
    textTask();
    Console.Write("Введите номер года: ");
    int year = Int32.Parse(Console.ReadLine());
    CheckYear(year);
    Console.ReadKey(); 
    multipleVerification();
}

void CheckYear(int y, string result = "не является високосным")
{
    if (y % 4 != 0) 
        {
            Console.Write($"\n- {result}\n\n");
            return;
        }
    if (y >= 400 && y % 100 == 0) 
    CheckYear(y/100);                             //РЕКУРСИЯ 
    else
        if (y % 4 == 0)
            {
                result = "является високосным";
                Console.Write($"\n- {result}\n\n");
            }
}

void textTask()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(new string('_', Console.WindowWidth));
    Console.WriteLine(
        "Знакомство с языками программирования. Урок 11. C#: от простого к практике. Практическое задание\n"
            + "\nЗадача 3. Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет. "
    ); 
    Console.WriteLine(new string('_', Console.WindowWidth) + "\n");
    Console.ResetColor();
}
