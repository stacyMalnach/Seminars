// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a, b;

Console.Write("Input first number ");
a = Convert.ToInt32(Console.ReadLine ());

Console.Write("Input second number ");
b = Convert.ToInt32(Console.ReadLine ());

if (a > b)
{
    Console.WriteLine ($"Max number is {a}");
}
else
{
    Console.WriteLine ($"Max number is {b}");
}
