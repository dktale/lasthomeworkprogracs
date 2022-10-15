// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с 
//помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int Prompt(string message)
// {
// System.Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }
// int NaturalNum(int number)
// {
// if (number == 0)
// {
// return 0;
// }
// System.Console.Write($"{number}, ");
// return  NaturalNum(number-1);

// }
// int number = Prompt("Введите число >");
// System.Console.Write(NaturalNum(number));

// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int Prompt(string message)
// {
// System.Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }

// int SumNumbers(int number, int b)
// {
//     if (number == 0 || b == 0) 
//     return 0;
//     if (number < b || number > b)
//     {       
//         return (number + SumNumbers(number + 1, b)); 
//     }
//     if (number==b)
//     {
//         Console.Write($"Количество чисел: {number},  Сумма чисел в промежутке = ");
//     }
//             return number;

// }

// int number = Prompt("Введите число >");
// int b = Prompt("Введите число(обязательно больше первого числа) >");
// System.Console.WriteLine(SumNumbers(number, b));

// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29




// int Prompt(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

// int m = Prompt("Введите число >");
// int n = Prompt("Введите число >");

// System.Console.WriteLine(Akkerman(m, n)); ;

// Все сделал!