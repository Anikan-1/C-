// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.

int Shifting (int num){
    if (num/2 == 0 && num > 0) return 1;
    if (num/2 == 0 && num < 0) return -1;
    if (num%2 == 1 || num%2 == -1)
    {
    Console.Write(Shifting (num/2));
    return 1;
    }
    else{
    Console.Write(Shifting(num/2));
    return 0;
    }
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num != 0)
Console.WriteLine(Shifting(num));
else
Console.WriteLine("Введите число");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumb(int num, int num2){
//     if (Math.Min(num,num2) < Math.Max(num,num2)){
//     return SumNumb(Math.Min(num,num2)+1,Math.Max(num,num2)) + Math.Min(num,num2);
//     }
//     else
//     return Math.Max(num,num2);
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int sum = SumNumb(num,num2);
// System.Console.WriteLine(sum);