/*//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] CreateRandom2dArray (int m, int n, int minValue, int maxValue)
{
	int[,] newArray = new int[m,n];
	
	for (int i = 0; i < m; i++)
		for(int j = 0; j < n; j++)
			newArray[i,j] = new Random().Next(minValue, maxValue + 1);
			
	return newArray;
}

void Show2dArray (int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i,j] + " ");
			
		Console.WriteLine();
	}	
    Console.WriteLine();	
}

int MinSumRow (int[,] array)
{
int rowSum = 0;
int tempSum = 0;

	for (int i = 0; i < array.GetLength(0); i++)
		for(int j = 0; j < array.GetLength(1); j++)
			tempSum += array[i,j];
		    if (tempSum > rowSum)
            {
                rowSum = tempSum;
            }	  
	return rowSum;
    
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input man possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] NewArray = CreateRandom2dArray(m, n, min, max);
Show2dArray (NewArray);
Console.WriteLine (MinSumRow(NewArray));*/


/*//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] CreateRandom2dArray (int m, int n, int minValue, int maxValue)
{
	int[,] newArray = new int[m,n];
	
	for (int i = 0; i < m; i++)
		for(int j = 0; j < n; j++)
			newArray[i,j] = new Random().Next(minValue, maxValue + 1);
			
	return newArray;
}

void Show2dArray (int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i,j] + " ");
		
        Console.WriteLine();
	}	
    Console.WriteLine();
    	
}

int[,] SortedRows (int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
		for(int j = 0; j < array.GetLength(1); j++)
			for (int k = j + 1; k < array.GetLength(1); k++)
				if (array[i,j] > array[i,k])
                {
					int temp = array[i,j];
					array[i,j] = array[i,k];
					array[i,k] = temp;
                }
    return array;       
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input man possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] NewArray = CreateRandom2dArray(m, n, min, max);
Show2dArray (NewArray);
Show2dArray (SortedRows(NewArray));*/


/*//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int [,] CreateArray (int m, int n, int minValue, int maxValue)
{
	int[,] newArray = new int[m,n];
	
	for (int i = 0; i < m; i++)
		for(int j = 0; j < n; j++)
			newArray[i,j] = new Random().Next(minValue, maxValue + 1);
			
	return newArray;
}

void Show2dArray (int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i,j] + " ");
		
        Console.WriteLine();
	}	
    Console.WriteLine();
    	
}

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix)
{
  int[,] resultMartrix = new int[firstMartrix.GetLength(0), secondMartrix.GetLength(1)];
 
            for (int i = 0; i < firstMartrix.GetLength(0); i++)
                for (int j = 0; j < secondMartrix.GetLength(0); j++)
                        resultMartrix[i, j] += firstMartrix[i, j] * secondMartrix[i, j];
            return resultMartrix;
}

Console.Write("Input number of rows for Array1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums for Array1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value for Array1: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input man possible valuef or Array1: ");
int max1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of rows for Array2: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums for Array2: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value for Array2: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input man possible valuef or Array2: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] FirstMatrix = CreateArray(m, n, min1, max1);
int[,] SecondMatrix = CreateArray(m, n, min2, max2);

Show2dArray (FirstMatrix);
Show2dArray (SecondMatrix);
Show2dArray (MultiplyMatrix(FirstMatrix,SecondMatrix));*/

/*//Задача 62. Заполните спирально массив 4 на 4.

int[,] SpiralArray (int m, int n)
{
    int[,] array = new int[m,n];
    int num = 1;

	for (int j = 0; j < m; j++)
	{
		array[0,j] = num;
		num++;
	}
	
	for (int i = 1; i < m; i++)
	{
		array[i,n-1] = num;
		num++;
	}
	
	for (int j = n - 2; j >= 0; j--)
	{
		array[m - 1, j] = num;
		num++;	
	}
	
	for (int i = m - 2; i > 0; i--)
	{
		array[i,0] = num;
		num ++;
	}

	for (int j = n - 3; j <= n - 2; j++)
	{
		array[m - 3, j] = num;
		num++;
	}
	
	for (int j = n - 2; j >= n - 3; j--)
	{
		array[m - 2, j] = num;
		num++;
    }

    return array;
}

void Show2dArray (int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i,j] + " ");
		
        Console.WriteLine();
	}	
    Console.WriteLine();
    	
}

Show2dArray(SpiralArray(4,4));*/
