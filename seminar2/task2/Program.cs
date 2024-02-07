// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10].
// Замените отрицательные элементы на положительные, а положительные на отрицательные.

// моё решение
// int[] array = new int[10] { -2, -4, -6, 0, -5, 8, 3, 6, 9, 10 };

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < 0)
//     {
//         array[i] = array[i] * -1;
//     }
//     else
//     {
//         array[i] = array[i] * -1;
//     }
//     Console.Write(array[i]);
//     Console.Write(" ");
// }

// Решение преподавателя

int[] array = new int[10] { -2, -4, -6, 0, -5, 8, 3, 6, 9, 10 };

for (int i = 0; i < array.Length; i++)
{
    array[i]*=(-1);
    Console.Write($"{array[i]} ");
}

