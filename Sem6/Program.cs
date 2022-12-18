// Написать программу, переводящую десятичное в двоичное


// int Perevod (int num) {
//     int count = 0;
//     while (num != 0) {
//         num /= 2;
//         count++;
//     }
//     return count;
// }

// int [] CreateArray (int count, int num) {
//     int [] array = new int[count];
// for (int i = 0; i < count; i++)
// {
//     array[i] = num%2;
//     num /=2;
// }
// return array;
// }

// void ShowArray (int [] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] ReverseArray (int [] array){
//     int l = array.Length;
//     for (int i = 0; i < l/2; i++)
//     {
//         int temp = array [i];
//         array[i] = array[l-1-i];
//         array[l-1-i] = temp;
//     }
//     return array;
// }

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateArray(Perevod(num), num);
// ReverseArray(array);
// Console.WriteLine($"Число {num} в двоичной системе: ");
// ShowArray(array);


// string BinarySystem (int num) {
//     string result = string.Empty;
//     while (num != 0) {
//         result = num%2 + result;
//         num /= 2;
//     }
//     return result;
// }


// Программа принимает на вход 3 числа и проверяет, может ли существовать такой треугольник

// bool Treug (int num1, int num2, int num3) {
//     bool flag = false;
//     if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) {
//         flag = true;
//     }
//     return flag;
// }

// System.Console.Write("Введите число 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число 3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// bool flag = Treug(num1, num2, num3);
// if (flag) Console.WriteLine("Yes");
// else Console.WriteLine("No");


// Без рекурсии вывести первые N чисел Фибоначчи
// N = 5 - 0 1 1 2 3


int Fib(int N, int num1, int num2){
    int num3 = 0;
    System.Console.Write(num1 + " ");
    System.Console.Write(num2 + " ");
    for (int i = 0; i < N-2; i++)
    {
        num3 = num1 + num2;
        System.Console.Write(num3 + " ");
        num1 = num2;
        num2 = num3;
    }
    return num3;
}

System.Console.Write("Сколько нужно чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Fib(num, num1, num2);