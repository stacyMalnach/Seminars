//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 
int Numbers (int n)
{
	int num = (n/10) % 10;
	return num;
}

Console.WriteLine ("Input tree-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

int res = Numbers (n);
Console.WriteLine ("Second number is  " + res);
