// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// void SecondDigit(int a){
//     int dec = a/10%10;
//     Console.WriteLine(dec);
// }

// Console.WriteLine("Введите трехзначное число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Результат - ");
// SecondDigit (num1);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void ThirdDigit(int a){

    if (a <= 99)
    {
        Console.WriteLine("В числе нет третьей цифры");
    }
    else
    {
        while (a >= 1000)
        {
            a /= 10;
        }
        a = a % 10;
        Console.WriteLine(a);
    }
}

Console.WriteLine("Введите число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Результат - ");
ThirdDigit (num2);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// void Weekend(int a){
//     if (a == 6 ^ a == 7) {
//         Console.WriteLine("Выходной день");
//     }
//     else {
//         Console.WriteLine("Рабочий день");
//     }
// }

// Console.WriteLine("Введите номер дня недели");
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Результат - ");
// Weekend (num3);
