// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSumDigit (int num)
{
    int sum = 0;
    int digit = 0;

    while (num > 0)
    {
        digit = num % 10;
        sum += digit;
        num = num / 10;
    }

    return sum; 
}

Console.Write ("Input random number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Digit's sum of your number is " + FindSumDigit (n));