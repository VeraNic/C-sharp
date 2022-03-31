Console.Clear();
Console.WriteLine("________________________________________________________");
Console.WriteLine("Знакомство с языками программирования. Семинар 6. Дополнительные задачи."); Console.WriteLine();
Console.WriteLine("Задача 2. На вход подаётся поговорка 'без труда не выловишь и рыбку из пруда'."); 
Console.WriteLine("Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.");
Console.WriteLine("________________________________________________________");
Console.WriteLine();

string phrase = "без труда не выловишь и рыбку из пруда";
printColorLetters(phrase);

int counter = 0;
Console.Write("Количество гласных букв: " + countingVowels(phrase, counter)); Console.WriteLine(); Console.ReadLine();

static void printColorLetters(string s)
{  
    var x = new HashSet<string>() {"a", "е", "ё", "и", "о", "у", "э", "ю", "я"};
    
        for (int i = 0; i < s.Length; i++)
    {
        if (x.Contains(s.Substring(i, 1))) Console.ForegroundColor = ConsoleColor.Red;
        else Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(s.Substring(i, 1));
    }
    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(); Console.WriteLine();
}

static int countingVowels(string s, int counter) 
{   
    var x = new HashSet<string>() {"a", "е", "ё", "и", "о", "у", "э", "ю", "я"};
    
    if (x.Contains(s.Substring(0, 1))) counter++;
       
    if (s.Length > 1) return countingVowels(s.Substring(1, s.Length - 1), counter); 
    else return counter;
}
