// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int number1, number2, number3, sum;

Console.Write("Input number1: ");
number1 = Convert.ToInt32(Console.ReadLine ());

Console.Write("Input number2: ");
number2 = Convert.ToInt32(Console.ReadLine ());

Console.Write("Input number3: ");
number3 = Convert.ToInt32(Console.ReadLine ());

sum = (number1 + number2 + number3);
Console.Write($"Sum of all numbers are {sum}");

