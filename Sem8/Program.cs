// задать двумерный массив, поменять любые две строки местами

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

// int [,] ChangeArrayRows (int [,] array){
//     Console.WriteLine("Введите номер первой строки");
//     int row1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите номер второй строки");
//     int row2 = Convert.ToInt32(Console.ReadLine());

//     if (row1 >=0 && row2 >=0 && row1<array.GetLength(0) && row2<array.GetLength(0) && row1 != row2){
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1,j];
//             array[row1,j] = array[row2,j];
//             array[row2,j] = temp;
//         }
//          return array;
//     }
//     else {
//         Console.WriteLine("Неверный ввод");
//         ChangeArrayRows(array);
//         return array;
//     }
// }

// int row = 4;
// int cols = 3;
// int min = 1;
// int max = 15;
// int [,] array = Create2dArray(row,cols,min,max);
// Show2dArray(array);
// int [,] changeArray = ChangeArrayRows(array);
// Show2dArray(changeArray);


// задать двумерный массив, заменить строки столбцами, в случае невозможности вывести ошибку

// int [,] ChangeArrayRowsCols (int [,] array){

//     if (array.GetLength(1) == array.GetLength(0)){
//       for (int i = 0; i < array.GetLength(0); i++)
//       {
//         for (int j = i+1; j < array.GetLength(1); j++)
//         {
//             int temp = array[i,j];
//             array[i,j] = array[j,i];
//             array[j,i] = temp;
//         }
//       } 
//          return array;
//     }
//     else {
//         Console.WriteLine("Неверный ввод");
//         return array;
//     }
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
// int [,] changeArray = ChangeArrayRowsCols(array);
// Show2dArray(changeArray);

// Задать двумерный массив
// Заменить элементы на 0 в строке и столбце, где находится минимальный элемент массива

// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая заменит сначения строк и 
// стобцов на нули на пересечении которых расположен наименьший элемент массива.



int[,] ChangeZero (int[,] array){
int min = array[0,0];
int imin = 0;
int jmin = 0;
bool flag = false;
while(flag == false)
{
    for (int j= 0; j < array.GetLength (1); j++)
    {
        for (int i = 0; i <array.GetLength (0); i++)
        {
            if ( array[j,i] <= min && array[j,i] != 0)
            {
            min= array[j,i];
            imin=i;
            jmin=j;
            }
        }
    }
    for (int j = 0; j < array.GetLength (1); j++)
    {
        for (int i = 0; i < array.GetLength (1); i++)
        {
            if (i == imin || j== jmin)
            {
                array[j,i] = 0;
            }
        }
    }
    flag =true;
    for (int j= 0; j < array.GetLength (1); j++)
    {
        for (int i = 0; i <array.GetLength (0); i++)
        {
            if (array[j,i] == min)
            {
                flag = false;
            }
        }
    }
}
    return array;
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2dArray(m, n, min, max);
Show2dArray(array);
System.Console.WriteLine();
int[,] change = ChangeZero(array);
Show2dArray(change);