// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateArray (int m, int n)
{
    double[,] array = new double [m,n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i,j] = new Random().Next (1,9) + new Random().NextDouble();

    return array;
}

void Show2dArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array [i,j] + " ");

         Console.WriteLine();
    }
        
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] myArray = CreateArray (m,n);
Show2dArray (myArray);


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArray (int m, int n)
{
    int[,] array = new int [m,n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i,j] = new Random().Next (1,10);

    return array;
}

double Average (int[,] array)
{
    int sum = 0;
    double aver = 0;

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = array[i,j] + array[i=1,j];
            aver = sum/array.GetLength(0);
        }
    
    return aver;
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array [i,j] + " ");

         Console.WriteLine();
    }
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateArray (m,n);
Show2dArray (newArray);

Console.Write("Average of column is: " + Average(newArray));


/* Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.*/

int[,] CreateArray (int m, int n)
{
    int[,] array = new int [m,n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i,j] = new Random().Next (1,10);

    return array;
}

void Findnumber (int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    
        for (int j = 0; j < array.GetLength(1); j++)
        
            if (array[i,j] == num) 
                Console.WriteLine("Your number have position " + i + j);
        
            else Console.WriteLine("Your number is NOT exist here.");
                 
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array [i,j] + " ");

         Console.WriteLine();
    }
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number for researching in array: ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateArray (m,n);
Show2dArray (newArray);
Findnumber(newArray, num);
