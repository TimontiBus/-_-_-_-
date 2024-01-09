int n = 10;
int[] array = { 3, 5, 7, 2000, 25, 300, 1345, 32, 654, 10 };
int i = 0;
int max = array[0];

while (i < array.Length)
{
	if (array[i] > max)
	{
		max = array[i];
	}
	i = i + 1;
}
Console.WriteLine(max);

max = array[0];

for (int j = 0; j < n; j++)
{
	if (array[j] > max)
	{
		max = array[j];
	}
}
Console.WriteLine(max);

max = array[0];
foreach (int e in array)
{
	if (e > max)
	{
		max = e;
	}
}
Console.WriteLine(max);