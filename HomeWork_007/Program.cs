//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Numbers ()
{
int rand = new Random().Next(1,1000);
Console.WriteLine ("Current number is " + rand );

	if (rand < 100) 
	{
	Console.WriteLine("Third number is not exist"); 
	return rand;
	}
	else
	{
	int current = rand % 10;
	Console.WriteLine ("Third number is " + current);
	return current;
	}
}

int res = Numbers ();

