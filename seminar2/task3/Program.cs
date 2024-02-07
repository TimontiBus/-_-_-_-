// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и. т. д.
// Результат запишите в новый массив.

// Пример:

// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] array = {2, 4, 6, 7 ,8 , 9, 1, 3, -4, -3, 11};
int[] parArr = new int[array.Length/2];

for(int i = 0; i<parArr.Length; i++)
{
    parArr[i] = array[i] * array[array.Length-1-i];
    Console.Write($"{parArr[i]} ");
}

if(array.Length%2==1)
{
    Console.Write($"(элемент {array[parArr.Length]} не имеет пары)");
}