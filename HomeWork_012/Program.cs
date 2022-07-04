//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateArray (int size)
{
    int [] array = new int [size];

    Console.Write ("Input number for creating array: ");
    int num = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < size; i++)
        array [i] = num;

    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine( array [i] + " ");
    
    Console.WriteLine();
}

Console.Write ("Input size of your array: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateArray (size);

ShowArray (myArray);