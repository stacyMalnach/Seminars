// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int n;

Console.Write("Input number ");
n = Convert.ToInt32(Console.ReadLine ());

if(n % 2 == 0)
{
    Console.WriteLine ("This number is even.");
}
else
{
    Console.WriteLine ("This number is not even.");
}