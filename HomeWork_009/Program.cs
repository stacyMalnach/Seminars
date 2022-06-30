// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeNumbers(int N)
{
int count = 1;

	while (count <= N)
	{
		int cube = count * count * count;
        Console.Write(cube + " ");
		count++;
	}
}

Console.Write("Input number ");
int N = Convert.ToInt32(Console.ReadLine());

CubeNumbers(N);
