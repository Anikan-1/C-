// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//(Math.Pow использовать нельзя!!!)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Exponent(int a, int b){
// int res = a;
// for (int i = 1; i < b; i++)
// {
//     res *= a;
// }
// System.Console.WriteLine($"Число {a} в степени {b} равно {res}");
// return res;
// }

// System.Console.Write("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Exponent(a, b);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//(Массивы и строки использовать нельзя!!!)
// 452 -> 11
// 82 -> 10
// 9012 -> 12




// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] Array(int num)
// {
// int [] arr = new int [num];
// for (int i = 0; i < arr.Length; i++)
// {
// System.Console.Write("Введите элемент массива: ");
// int el = Convert.ToInt32(Console.ReadLine());
// arr[i] = el;
// }

// return arr;
// }
// void ShowArray (int[] arr)
// {
// for (int i = 0; i < arr.Length; i++)
// {
// System.Console.Write($"{arr[i]} ");
// }
// }

// System.Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowArray(Array(num));