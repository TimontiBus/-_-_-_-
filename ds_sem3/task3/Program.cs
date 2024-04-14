




// Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 
// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем.


using System;
class Program
{
	static void Main()
	{
		int[] numbers = { 1, 3, 5, 6, 7, 8 }; // Исходный массив
		int temp;
		// Вывод исходного массива
		Console.Write("Исходный массив: ");
		foreach (int number in numbers)
		{
			Console.Write(number + " ");
		}
		// Реверсирование массива
		for (int i = 0; i < numbers.Length / 2; i++)
		{
			// Меняем местами элементы
			temp = numbers[i];
			numbers[i] = numbers[numbers.Length - 1 - i];
			numbers[numbers.Length - 1 - i] = temp;
		}
		// Вывод измененного массива
		Console.Write("\nПеревернутый массив: ");
		foreach (int number in numbers)
		{
			Console.Write(number + " ");
		}
	}
}
