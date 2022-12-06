// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

void Dist (int x, int y, int z, int x1, int y1, int z1) {
    double d = Math.Sqrt(Math.Pow((x1-x),2)+Math.Pow((y1-y),2)+Math.Pow((z1-z),2));
    Console.WriteLine($"Расстояние: {Math.Round(d,2)}");
}

int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");

Dist(x, y, z, x1, y1, z1);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubeTab (int x) {
// int a = 1;
// int count = 0;
//    while (count < x){
//     Console.WriteLine(a*a*a);
//     a++;
//     count++;
//    }
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// CubeTab(n);