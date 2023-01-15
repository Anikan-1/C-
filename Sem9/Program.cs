//Задать значение N, вывести все натуральные числа от 1 до N



// void ShowNumb (int n){
//     if (n>1) ShowNumb(n-1);
//     Console.Write(n + " ");
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowNumb(num);


//Задать 2 числа, вывести все числв от N до M

// void ShowNumbMN (int n, int m){
//     Console.Write(Math.Min(n,m) + " ");
//     if (Math.Max(n,m) != Math.Min(n,m)) ShowNumbMN(Math.Max(n,m),Math.Min(n,m)+1);
// }

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// ShowNumbMN(num1,num2);


//Написать программу, принимающая число и считает сумму цифр числа 1234 = 

// int SumNumb(int num){
//     if (num<0) num *= -1;
//     if(num>0) return SumNumb(num/10) + num%10;
//     else return 0;
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = SumNumb(num);
// System.Console.WriteLine(sum);

// Программа принимает на вход два числа A и В, и возводит А в степень B


double Stepen (int a, int b){
    if (b<0) return Stepen(a, b+1) / a;
    if (b>0) return Stepen(a, b-1) * a;
    else return 1.0;
}

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
double numPower = Stepen(num1,num2);
System.Console.WriteLine(numPower);