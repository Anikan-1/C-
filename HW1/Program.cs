// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b) {
Console.WriteLine($"Число {a} больше числа {b}");
}
else if (a<b) {
    Console.WriteLine($"Число {a} меньше числа {b}");
}
else if (a==b) {
    Console.WriteLine($"Число {a} равно числу {b}");
}
else {
     Console.WriteLine($"Ошибка ввода числа");
}

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c1 = Convert.ToInt32(Console.ReadLine());

int max = a1;

if (max<b1) {
max = b1;
Console.WriteLine($"Максимальное число {max}");
}
else if (max<c1) {
    max = c1;
    Console.WriteLine($"Максимальное число {max}");
}
else {
     Console.WriteLine($"Максимальное число {max}");
}

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int a2 = Convert.ToInt32(Console.ReadLine());

if (a2%2 == 0) {
Console.WriteLine($"Число {a2} четное");
}
else if (a2%2 != 0) {
    Console.WriteLine($"Число {a2} нечетное");
}
else {
     Console.WriteLine($"Ошибка ввода числа");
}

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int a3 = Convert.ToInt32(Console.ReadLine());
int b3 = 2;

while (b3<=a3)
{
    if (b3%2 == 0){
    Console.Write(b3 + " ");
    b3++;
    }
    else {
        b3++;
    }
}
