// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Создайте программу, показывающую текущее время.

string[] arrStr0 = {" @@@ ", "@   @", "@   @", "@   @", "@   @", "@   @", " @@@ "};
string[] arrStr1 = {"  @  ", " @@  ", "@ @  ", "  @  ", "  @  ", "  @  ", "@@@@@"};
string[] arrStr2 = {" @@@ ", "@   @", "@  @ ", "  @  ", " @   ", "@    ", "@@@@@"};
string[] arrStr3 = {" @@@ ", "@   @", "@  @ ", "    @", "    @", "@   @", " @@@ "};
string[] arrStr4 = {"@   @", "@   @", "@   @", "@@@@@", "    @", "    @", "    @"};
string[] arrStr5 = {"@@@@@", "@    ", "@@@@ ", "    @", "    @", "@   @", " @@@ "};
string[] arrStr6 = {" @@@ ", "@   @", "@@@@ ", "@   @", "@   @", "@   @", " @@@ "};
string[] arrStr7 = {"@@@@@", "    @", "   @ ", "  @  ", " @   ", "@    ", "@    "};
string[] arrStr8 = {" @@@ ", "@   @", " @@@ ", "@   @", "@   @", "@   @", " @@@ "};
string[] arrStr9 = {" @@@ ", "@   @", "@   @", "@   @", " @@@@", "@   @", " @@@ "};
string[] arrStrColon = {"     ", "  @  ", "  @  ", "     ", "  @  ", "  @  ", "     "};

string StrTimeNow;
StrTimeNow = getTimeNow();
Console.WriteLine(StrTimeNow);

string[][] ArrNumberTime = new string[5][];

for(int i = 0; i < 5; i++)
{
    //char simb = StrTimeNow[i];
    switch (StrTimeNow[i])
    {
        case '0':
        ArrNumberTime[i] = arrStr0;
        break;
        case '1':
        ArrNumberTime[i] = arrStr1;
        break;
        case '2':
        ArrNumberTime[i] = arrStr2;
        break;
        case '3':
        ArrNumberTime[i] = arrStr3;
        break;
        case '4':
        ArrNumberTime[i] = arrStr4;
        break;
        case '5':
        ArrNumberTime[i] = arrStr5;
        break;
        case '6':
        ArrNumberTime[i] = arrStr6;
        break;
        case '7':
        ArrNumberTime[i] = arrStr7;
        break;
        case '8':
        ArrNumberTime[i] = arrStr8;
        break;
        case '9':
        ArrNumberTime[i] = arrStr9;
        break;
        case ':':
        ArrNumberTime[i] = arrStrColon;
        break;
        default:
        Console.WriteLine("Ошибка");
        break;
    }
}

for (int j = 0; j < 7; j++)
{
    for (int i = 0; i < 5; i++)
    {
        Console.Write(ArrNumberTime[i][j] + " ");
    }
    Console.WriteLine("");
}

string getTimeNow()
        {
            //Текущие дата/время хранятся в свойстве Now класса DateTime
            string args;
            args = DateTime.Now.ToString("HH:mm:ss");
 
            //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss")); //Выводим только время
 
            //Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy")); //Выводим дату, выводится название месяца а не его номер
            //Console.WriteLine(args);
 
            //Чтобы программа сразу же не закрылась
            //Console.ReadKey();
            return args;
        }
