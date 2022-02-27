Console.WriteLine("");
Console.WriteLine("________________________________________________________");
Console.WriteLine("18. Проверить истинность утверждения ¬(X V Y) = ¬X & ¬Y");
Console.WriteLine("________________________________________________________");
Console.WriteLine("");
Console.WriteLine("X Y |F");
Console.WriteLine("----+--");
bool X = true;
bool Y = true;
bool F1 = (!(X || Y) == (!X && !Y));
byte n = Convert.ToByte(F1);
Console.WriteLine("1 1 |" + n); 

X = true;
Y = false;
bool F2 = (!(X || Y) == (!X && !Y));
n = Convert.ToByte(F2);
Console.WriteLine("1 0 |" + n); 

X = false;
Y = true;
bool F3 = (!(X || Y) == (!X && !Y));
n = Convert.ToByte(F3);
Console.WriteLine("0 1 |" + n); 

X = false;
Y = false;
bool F4 = (!(X || Y) == (!X && !Y));
n = Convert.ToByte(F4);
Console.WriteLine("0 0 |" + n); 

Console.WriteLine("");
if (F1 && F2 && F3 && F4) Console.Write("Это утверждение истинно для всех значений истинности X и Y.");
else Console.WriteLine("Это утверждение ложно.");
Console.WriteLine("");
Console.WriteLine("");
// // Вариант решения задачи для вводимых пользователем значений истинности X и Y.
// Console.Write("Введите значение истинности высказывания Х, 0 или 1: ");
//  int i = -1;
//        bool result = false;
//         while (result == false)
//         {
//             Console.WriteLine("Введите, пожалуйста, 0 или 1! ");
//             string s = Console.ReadLine();
//                         result = int.TryParse(s, out i);
//             if (s.Equals("0") || s.Equals("1") ) result = true;
//             else result = false;
//         }
// Console.WriteLine(i);
// bool X = Convert.ToBoolean(i);
// 
// Console.Write("Введите значение истинности высказывания Y, 0 или 1: ");
// i = -1;
//         result = false;
//         while (result == false)
//         {
//             Console.WriteLine("Введите, пожалуйста, 0 или 1! ");
//             string s = Console.ReadLine();
//                         result = int.TryParse(s, out i);
//             if (s.Equals("0") || s.Equals("1") ) result = true;
//             else result = false;
//         }
// Console.WriteLine(i);
// bool Y = Convert.ToBoolean(i);

// if (!(X || Y) == (!X && !Y)) Console.Write("Это утверждение истинно.");
// else Console.Write("Это утверждение ложно.");

 