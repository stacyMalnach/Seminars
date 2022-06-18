// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int n;
int current;

Console.Write("Input number, please ");
n = Convert.ToInt32(Console.ReadLine ());

if (n % 2 ==1)
{
    n = n-1;
}
current = n;

while (current > 0)
{
Console.Write(current + " ");
current = current - 2;
}

