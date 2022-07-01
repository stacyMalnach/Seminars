// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom (int n)
{

	int endN = n % 10;
	int firstN = n / 10000;
    int preN = n % 10;
	int secondN = n / 1000;

    if (endN == firstN && preN == secondN)
		Console.WriteLine("This number is palindrom.");
		
	else
		Console.WriteLine("This number is NOT palindrom.");
    
}

Console.Write("Input five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

Palindrom (n);

        




        
		
