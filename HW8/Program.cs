// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
//строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
    Console.WriteLine();
}

// int [,] SortRows (int [,] array){
//     int imax = 0;
//     int jmax = 0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             int max = array[j,k];
//             for (int i = k; i < array.GetLength(1); i++)
//             {
//                 if (array[j, i] > max)
//                 {
//                     int temp = array[j,i];
//                     array[j,i] = max;
//                     array[jmax,imax] = temp;
//                     max = temp;
//                 }
//             }
//             imax++;
//         }
//         imax = 0;
//         jmax++;
// }
// return array;
// }

// Console.WriteLine("Введите количество строк");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = Create2dArray(row,cols,min,max);
// Show2dArray(array);
//  Console.WriteLine();
// int [,] changeArray = SortRows(array);
// Show2dArray(changeArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void FindRow(int[,] array)
// {
//     int max = 0;
//     int maxRow = 0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//     int sum = 0;
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//            sum += array[j,i];
//         }
//         if (sum > max)
//         {
//         max = sum;
//         maxRow = j;
//         }
//     }
//     Console.WriteLine($"Максимальная сумма в {maxRow} строке");
// }
// Console.WriteLine("Введите количество строк");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// if (row == cols && row >0)
// {
// int[,] array = Create2dArray(row, cols, min, max);
// Show2dArray(array);
// Console.WriteLine();
// FindRow(array);
// }
// else
// Console.WriteLine("error");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Matrix(int[,] arr1, int[,] arr2)
// {
// int[,]array = new int[arr1.GetLength(0),arr1.GetLength(1)];
// for (int j = 0; j < arr1.GetLength(0); j++)
// {
//     for (int i = 0; i < arr1.GetLength(0); i++)
//     {
//         int sum = arr1[j,0] * arr2[0, i];
//             for (int k = 1; k < arr1.GetLength(0); k++)
//             {
//                sum = sum +  arr1[j,k] * arr2[k,i];
//             }
//         array[j,i] = sum;
//     }
// }
// return array;
// }
// Console.WriteLine("Введите количество строк");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// if (row == cols && row != 0)
// {
// int[,] arr1 = Create2dArray(row, cols, min, max);
// int[,] arr2 = Create2dArray(row, cols, min, max);
// Show2dArray(arr1);
// Console.WriteLine();
// Show2dArray(arr2);
// int[,] arr = Matrix(arr1,arr2);
// Console.WriteLine();
// Show2dArray(arr);
// }
// else
// Console.WriteLine("error");


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int Find3dArray(int[,,] array, int num)
// {
//     int count = 0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//            for (int k = 0; k < array.GetLength(2); k++)
//            {
//             if (array[j,i,k]==num)
//             count++;
//            }
            
//         }
//     }
//     return count;
// }

// int[,,] Create3dArray(int row, int cols, int lines, int min, int max)
// {
//     int[,,] array = new int[row, cols, lines];
//     for (int j = 0; j < row; j++)
//     {
//         for (int i = 0; i < cols; i++)
//         {
//             for (int k = 0; k < lines; k++)
//             {
//                 array[j, i, k] = new Random().Next(min, max);
//                 while(Find3dArray(array,array[j,i,k]) > 1)
//                 {
//                 array[j, i, k] = new Random().Next(min, max);
//                 }
//             }
//         }
//     }
//     return array;
// }

// void Show3dArray (int[,,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[j,i,k]}({j},{i},{k}) ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// int[,,] array = Create3dArray(2, 2, 2, 10, 100);
// Show3dArray(array);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiral(int row, int cols, int count)
{
int[,] array = new int[row,cols];
   for (int a = 0; a < cols; a++)
   {
        array[0, a] = count;
        count++;
    }
    for (int b = 1; b < row; b++)
    {
        array[b, 3] = count;
        count++;
    }
    for (int c = 2; c >= 0; c--)
    {
        array[3,c] = count;
        count++;
    }
    for (int d = 2; d >0; d--)
    {
        array[d,0] = count;
        count++;
    }
    for (int e = 1; e < 3; e++)
    {
        array[1,e] = count;
        count++;
    }
    for (int f = 2; f > 0; f--)
    {
        array[2, f] = count;
        count++;
    }
    return array;
}
int rows = 4;
int col = 4;
Console.WriteLine("Введите начальное число");
int num = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateSpiral(rows, col, num);
Show2dArray(array);