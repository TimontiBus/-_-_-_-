
int[] array = { 3, 5, 7, 67, 25, 300, 1345, 32, 654, 10 };
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
Console.Write(max);