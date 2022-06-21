// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int number1, number2, number3, max;

Console.Write("Input number1: ");
number1 = Convert.ToInt32(Console.ReadLine ());

Console.Write("Input number2: ");
number2 = Convert.ToInt32(Console.ReadLine ());

Console.Write("Input number3: ");
number3 = Convert.ToInt32(Console.ReadLine ());

if (number1 > number2)
{
    max = number1;
}
else 
{
    max = number2;
}

if (number1 > number3)
{
    max = number1;
}
else 
{
    max = number3;
}
if (number2 > number3)
{
    max = number1;
}
else 
{
    max = number3;
}
Console.Write($"Max number is {max}");