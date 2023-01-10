// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] CreateArray (int num){
    int [] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        System.Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array; 
}

void ShowArray (int [] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void CountPos (int [] array) {
     int count = 0;
     for (int i = 0; i < array.Length; i++)
     {
         if (array[i] > 0) count++;
     }
     System.Console.WriteLine($"Положительных чисел: {count}");
}

System.Console.Write("Сколько нужно чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(num);
ShowArray(array);
CountPos(array);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// void FindIntersection (double k1, double b1, double k2, double b2)
// {
//     double x = (b2 - b1)/(k1 - k2);
//     double y = k1 * x + b1;
//     System.Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
// }

// System.Console.Write("Введите k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// FindIntersection (k1, b1, k2, b2);