// Задача 64: Задайте значение N. Напишите программу, которая найдет факториал числа N рекурсивным методом.

int Factorial (int n)
{
    if (n > 0)
    return n * Factorial (n-1);
    
    else return 1; 
}

 Console.Write("Input number ");
 int n = Convert.ToInt32(Console.ReadLine());

 Console.Write($"Factorial {n} is " +Factorial (n));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers (int n, int m)
{
    if(n > m) return SumNumbers (n -1, m) + n;

    else return n;
}

Console.Write("Input 'n' ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 'm' ");
int m = Convert.ToInt32(Console.ReadLine());

 Console.Write($"Sum numbers between {n} and {n}  is " + SumNumbers (m, n));
