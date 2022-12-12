// Написать программу? принимающее число А, которая будет выдавать сумму от 1 до А

// int SumNumbers (int num) {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//         sum += i;
//     return sum;
// }

// System.Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = SumNumbers(num);
// System.Console.WriteLine($"Summa from 1 to {num} = {sum}");

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int NumDigits (int num){
//    if (num == 0) {
//     return 1;
//    }
//    else {
//     int count = 0;
//     while (num > 0) {
//         count++;
//         num /= 10;
//     }
//     return count;
//    }
// }

// System.Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int digit = NumDigits(num);
// System.Console.WriteLine($"В числе {num} - {digit} цифр");


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int ProizvNumbers (int num) {
//     if (num < 0) {
//         num *= -1;
//   }
    
//     int proizv = 1;
//     for (int i = 1; i <= num; i++)
//         proizv *= i;
//     return proizv;
    
// }

// System.Console.Write("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int proizv = ProizvNumbers(num);
// System.Console.WriteLine($"Proizvedenie from 1 to {num} = {proizv}");

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] Array(int num)
{
int [] arr = new int [num];
for (int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(5,16);
}

return arr;
}
void ShowArray (int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
System.Console.Write($"{arr[i]} ");
}
}

System.Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowArray(Array(num));