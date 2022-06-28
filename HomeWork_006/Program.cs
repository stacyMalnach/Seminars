//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Days(int n)
{
	if (n < 6) 
		Console.WriteLine("This day is not day off =( ");
	
	else 
		Console.WriteLine("This day is day off =) ");
	
}

Console.WriteLine("Input number from 1 to 7");
int n = Convert.ToInt32 (Console.ReadLine ());
Days(n);