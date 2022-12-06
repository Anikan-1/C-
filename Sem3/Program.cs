
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void FindSquad (int x, int y) {
//     if (x==0 || y==0){
//         Console.WriteLine("Erorrr");
//     }
//     else if (x>0 && y>0){
//         Console.WriteLine("Точка в первой четверти");
//     }
//     else if (x>0 && y<0){
//         Console.WriteLine("Точка в четвертой четверти");
//     }
//     else if (x<0 && y>0){
//         Console.WriteLine("Точка во второй четверти");
//     }
//     else {
//         Console.WriteLine("Точка в третьей четверти");
//     }
// }

// Console.Write("Введите Х: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// FindSquad(x, y);

// Напишите программу, которая 
// по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void FindXY (int x) {
//     if (x == 1){
//         Console.WriteLine("X > 0 и Y > 0");
//     }
//     else if (x == 2){
//         Console.WriteLine("X < 0 и Y > 0");
//     }
//     else if (x==3){
//         Console.WriteLine("X < 0 и Y < 0");
//     }
//     else if (x == 4){
//         Console.WriteLine("X > 0 и Y < 0");
//     }
//     else {
//         Console.WriteLine("Error");
//     }
// }

// Console.Write("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());

// FindXY(num);

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

// void SquareTab (int x) {
// int a = 1;
// int count = 0;
//    while (count < x){
//     Console.WriteLine(a*a);
//     a++;
//     count++;
//    }
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SquareTab(n);

// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// AB = √(xb - xa)2 + (yb - ya)2

void Dist (int x, int x1, int y, int y1) {
    double d = Math.Sqrt(Math.Pow((x1-x),2)+Math.Pow((y1-y),2));
    Console.WriteLine($"Расстояние: {Math.Round(d,2)}");
}

Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату У: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату У1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Dist(x, x1, y, y1);
