// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] CreateArray (int size) {
//     int [] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(100,1000);
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

// int EvenNumbers (int [] array) {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]%2 == 0) count++;
//     }
//     return count;
// }


// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateArray(size);
// ShowArray(array);
// Console.WriteLine($"Количество четных элментов массива: {EvenNumbers(array)} ");

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



// int [] CreateArray (int size) {
//     int [] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(1,1000); // Немного ограничу размер, так как очень большие цифры выдает при пустом
// }
// return array;
// }

// void ShowArray (int [] array){
    // for (int i = 0; i < array.Length; i++)
    // {
    //     Console.Write($"{array[i]} ");
    // }
    // Console.WriteLine();
// }

// int SegmentNumbers (int [] array) {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99) count++;
//     }
//     return count;
// }


// int size = 123;
// int [] array = CreateArray(size);
// ShowArray(array);
// Console.WriteLine($"Количество элментов массива от 10 до 99: {SegmentNumbers(array)} ");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int [] CreateArray (int size) {
//     int [] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(1,1000); 
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

// int SumOdd (int [] array) {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i%2 > 0) sum+=array[i];
//     }
//     return sum;
// }


// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateArray(size);
// ShowArray(array);
// Console.WriteLine($"Сумма элементов на нечетных позициях: {SumOdd(array)} ");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

// double [] CreateArray (int size) {
//     double [] array = new double[size];
// for (int i = 0; i < size; i++)
// {
//    array[i] = Convert.ToDouble(new Random().Next(10,1000)/10.0);

// }
// return array;
// }


// void ShowArray (double [] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}  ");
//     }
//     Console.WriteLine();
// }

// void DiffMinMax (double [] array) {
//     double min = array[0];
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min) min = array[i];
//         if (array[i] > max) max = array[i];
//     }
//     System.Console.WriteLine($"Разница между минимальным и максимальным элементами = {Math.Round(max-min,2)}");
// }


// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double [] array = CreateArray(size);
// ShowArray(array);
// DiffMinMax(array);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArray (int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,101);
    }
    return array;
}

void ShowArray (int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int[] ProductNumEvenArray (int[] array)
{
    int[] arr = new int[array.Length / 2];
    int count = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        arr[count] = array[i] * array[array.Length - i - 1];
        count++;
    }
    return arr;
}
int[] ProductNumOddArray (int[] array)
{
    int[] arr = new int[array.Length / 2 + 1];
    int count = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        arr[count] = array[i] * array[array.Length - i - 1];
        count++;
    }
    arr [arr.Length - 1] = array[array.Length/2];
    return arr;
}
System.Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
if (array.Length %2 == 0) ShowArray(ProductNumEvenArray(array));
else ShowArray(ProductNumOddArray(array));