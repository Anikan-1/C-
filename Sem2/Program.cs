// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// void Test(){
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine($"Случайно число - {num}");
//     int sot = num/100;
//     int ed = num%10;
//    Console.Write(sot);
//    Console.WriteLine(ed);
// }

// Test ();


// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления

// void Test1(int a, int b){
//    if (b%a == 0)
//    {
//     Console.WriteLine($"Число {b} кратно числу {a} ");
//    }
//     else {
//         Console.WriteLine($"Остаток от деления {b%a}");
//     }
// }

// Console.WriteLine("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Результат - ");
// Test1 (num1, num2);

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет


void Test2(int a, int b){
   if (a == b*b)
   {
    Console.WriteLine($"Число {a} квадрат числа {b} ");
   }
   else if (b == a*a) {
    Console.WriteLine($"Число {b} квадрат числа {a} ");
   }
    else {
        Console.WriteLine("Числа не являются квадратами друг друга");
    }
}

Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Результат - ");
Test2 (num1, num2);