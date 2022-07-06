/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.*/

int[] CreateArray (int size)
{
    int [] array = new int [size];
    
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next (100,1000);
    
    return array;
}

int EvenNumber (int[] array)
{

    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    
    return count;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array[i] + " ");

    Console.WriteLine ();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] OurArray = CreateArray (size);

ShowArray (OurArray);
Console.Write("Even number of your array is " + EvenNumber(OurArray));



//Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray (int size)
{
    int [] array = new int [size];
    
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next (-99,100);
    
    return array;
}

int SumOddNumbers (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0) sum += array [i];		
    
    return sum;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array[i] + " ");

    Console.WriteLine ();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] OurArray = CreateArray (size);

ShowArray(OurArray);

Console.Write("Sum of odd numbers is: " + SumOddNumbers(OurArray));



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray (int size)
{
    double[] array = new int [size];
    
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next (1,10) + rand.NextDouble();
    
    return array;
}

double DiffBetweenNum (double[] array)
{
    double max = -1;
	double min = 11;

    for (int i = 0; i < array.Length; i++)
        
        if (array[i] > max) max = array[i];
		
		if (array[i] < min) min = array[i];
    
    double dif = max - min;
	
	return dif;
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array[i] + " ");

    Console.WriteLine ();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] OurArray = CreateArray (size);

ShowArray(OurArray);

Console.Write("Difference between max and min your array is: " + DiffBetweenNum(OurArray));
