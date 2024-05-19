// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

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

int[,] Change2DArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			if (i % 2 == 0 && j % 2 == 0)
			{
				arr[i, j] *= arr[i, j];
			}
		}
	}
	return arr;
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
int[,] changedArray = Change2DArray(array);
Show2DArray(changedArray);