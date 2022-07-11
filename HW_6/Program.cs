//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray ()
{
    Console.Write("Input size of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} elements: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

int BiggerZero (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count ++;

    return count;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array[i] + " ");

    Console.WriteLine ();
}

int[] MyArray = CreateArray();
ShowArray(MyArray);
Console.Write($"Your array have {BiggerZero(MyArray)} zeros.");

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

void FindCoordinates (int b1, int k1, int b2, int k2, int x, int y)
{
x = (b2 - b1) /(k1 - k2);
y = k1 * x + b1;
}

Console.Write("Input b1:");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k1:");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b2:");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k2:");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"There is crossing of two lines: {FindCoordinates (b1, k1, b2, k2)} ");