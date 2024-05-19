
//Задайте двумерный массив из целых чисел.
//Сформируйте новый одномерный массив, состоящий из средних
//арифметических значений по строкам двумерного массива

int[,] Create2DArray(int row, int col, int min, int max)
{
	int[,] arr = new int[row, col];
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < col; j++)
		{
			arr[i, j] = new Random().Next(min, max + 1);
		}
	}
	return arr;
}

void Show2DArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($" {arr[i, j]}");
		}
		Console.WriteLine();
	}
}


void Test(int[,] arr)
{
	int sum = 0;
	int minInd = 0;
	if (arr.GetLength(0) > arr.GetLength(1))
	{
		minInd = arr.GetLength(1);
	}
	else
	{
		minInd = arr.GetLength(0);
	}
	for (int i = 0; i < minInd; i++)
	{
		sum += arr[i, i];
	}
	Console.WriteLine(sum);
}


int[] Average2Array(int[,] arr)
{
	int[] array = new int[arr.GetLength(0)];
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		int average = 0;
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			average += arr[i, j];
		}
		array[i] = average / arr.GetLength(1);
	}
	return array;
}

void ShowArray(int[] arr)
{
	foreach (int i in arr)
	{
		Console.Write($"{i}");
	}
}

Console.Write("Введите кол-во строк ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов ");
int col = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DArray(row, col, min, max);
Show2DArray(array);
Console.WriteLine();
ShowArray(Average2Array(array));
//int[,] changedArray = Change2DArray(array);

//Test(array);
//int[] arr = Average2Array(array);
//ShowArray(arr);