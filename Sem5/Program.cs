//Надайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] CreateArray (int size, int minValue, int maxValue) {
//     int [] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(minValue, maxValue+1);
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

// int FindPosSum (int [] array) {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sum += array[i];
//     }
//     return sum;
// }

// int FindNegSum (int [] array) {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0) sum += array[i];
//     }
//     return sum;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите начало массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите конец массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateArray(size, min, max);
// ShowArray(array);
// Console.WriteLine($"Сумма положительных элментов массива: {FindPosSum(array)} ");
// Console.WriteLine($"Сумма отрицательных элментов массива: {FindNegSum(array)} ");


//Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int [] CreateArray (int size, int minValue, int maxValue) {
//     int [] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(minValue, maxValue+1);
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

// int ChangePos (int [] array) {
//     int el = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//        el = array[i] * -1;
//        Console.Write($"{el} ");
//     }
//     return el;
// }


// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите начало массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите конец массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateArray(size, min, max);
// ShowArray(array);
// ChangePos(array);


// 2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int [] CreateArray (int size, int minValue, int maxValue) {
    int [] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(minValue, maxValue+1);
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

bool FindEl (int [] array, int el) {
    bool flag = false;
    for (int i = 0; i < array.Length; i++)
    {
       if (el == array[i]) flag = true;
    }
    return flag;
}


System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите начало массива: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите конец массива: ");
int max = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите интересующий элемент: ");
int el = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(size, min, max);
ShowArray(array);
bool flag = FindEl(array, el);
if (flag) Console.WriteLine("Yes");
else Console.WriteLine("No");