// Задать двумерный масси m,n заполнить случайныи целыми ячислами

// int [,] Create2dArray(int rows, int cols, int min, int max){
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }

// void Show2dArray (int [,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
    
// }

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите min элемент: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите max элемент: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = Create2dArray(m,n,min,max);
// Show2dArray(array);

// Задать двумерный масси m,n. Каждый элемент массива находится по формуле m+n

// int [,] Create2dArray(int rows, int cols){
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = i + j;
//         }
//     }
//     return array;
// }

// void Show2dArray (int [,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
    
// }

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] array = Create2dArray(m,n);
// Show2dArray(array);

// Задать двумерный массив
// Найти элементы, у которых оба индекса четные и заменить элементы на их квадраты

// int [,] Create2dArray(int rows, int cols, int min, int max){
//     int [,] array = new int [rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }

// void Show2dArray (int [,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] FindQuaters(int [,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            if (i%2 == 0 && j%2 == 0){
//             array[i,j] = array[i,j]*array[i,j];
//            }
//         }
//     }
//     return array;
// }

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите min элемент: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите max элемент: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = Create2dArray(m,n,min,max);
// Show2dArray(array);
// FindQuaters(array);
// Console.WriteLine();
// Show2dArray(array);


// ЗАДАЙТЕ ЛВУМЕРНЫЙ МАССИВ
//  Найдите сумму элементов, находящихся на главной диагонали
// с индексами (0;0),(1,1) итд

int [,] Create2dArray(int rows, int cols, int min, int max){
    int [,] array = new int [rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

void Show2dArray (int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void SumEl(int [,] array){
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (i == j){
            sum += array[i,j];
           }
        }
    }
    System.Console.WriteLine("Сумма элементов главной диагонали: " + sum);
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элемент: ");
int max = Convert.ToInt32(Console.ReadLine());
int [,] array = Create2dArray(m,n,min,max);
SumEl(array);
Show2dArray(array);