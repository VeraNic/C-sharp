public class Sem3Dop6
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(
            "Задача 6. На вход подаётся число n > 4, указывающее длину пароля. Создайте метод, генерирующий пароль заданной длины. В пароле обязательно использовать цифру, букву и специальный знак."
        );
        Console.WriteLine("________________________________________________________");
        Console.WriteLine("");
        string digits = "0123456789";
        string symbols = "!#$%&'()*+,-./:;<=>?@[]^_'{|}~";
        string lowercase_letters = "abcdefghijklmnopqrstuvwxyz";
        string capital_letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        Console.Write("Введите длину пароля: ");
        int n = int.Parse(Console.ReadLine());
        while (n < 5)
        {
            Console.WriteLine("Введите число, в котором больше 4 цифр: ");
            n = int.Parse(Console.ReadLine());
        }
        Random random = new Random();
        int nd = random.Next(9); //Случайный выбор номера цифры из списка
        int ns = random.Next(31); //Случайный выбор номера спецсимвола из списка
        int nl = random.Next(25); //Случайный выбор номера буквы из списка

        string parol =
            capital_letters.Substring(nl, 1) + symbols.Substring(ns, 1) + digits.Substring(nd, 1); //Добавляем в пароль первые обязательные 3 символа: букву, спецсимвол, цифру

        int choiceCat; //Переменная для случайного выбора одной из 4 категорий символов
        for (int i = 0; i < n - 3; i++)//Подбор остальных знаков пароля, после первых трёх, выбранных из обязательных категорий
        {
            choiceCat = random.Next(4); //Случайный выбор категории символов
            switch (choiceCat)
            {
                case 1:
                    nl = random.Next(25); //Случайный выбор номера заглавной буквы из списка
                    parol = parol + capital_letters.Substring(nl, 1);
                    break;
                case 2:
                    parol = parol + lowercase_letters.Substring(nl, 1);
                    nl = random.Next(25); //Случайный выбор номера строчной буквы из списка
                    break;
                case 3:
                    ns = random.Next(31); //Случайный выбор номера спецсимвола из списка
                    parol = parol + symbols.Substring(ns, 1);
                    break;
                case 4:
                    nd = random.Next(9); //Случайный выбор номера цифры из списка
                    parol = parol + digits.Substring(nd, 1);
                    break;
                default:
                    parol = parol + "0";
                    break;
            }
        }
        Console.WriteLine("Сгенерированный пароль: " + parol);
    }
}
