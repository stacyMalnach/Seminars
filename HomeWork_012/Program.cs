﻿//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray (int size)
{
    int[] array = new int [size];

    for (int i = 0; i < size; i++)
        array[i] = new Random ().Next(1,100);
    
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write( array[i] + " ");
    
    Console.WriteLine();
}

ShowArray (CreateArray (8));