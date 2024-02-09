Console.Clear();

int[] CreateRandomArray(int size, int min, int max)   // название "(CreateRandomArray)" и параметры функции "(int size, int min, int max)"
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);      // метод рандомного заполнения массива "array[i] = new Random().Next(min, max+1)"
    }
    return array;
}

void ShowArray(int[] array)
{
    foreach (int e in array)
    {
        Console.Write($"{e} ");
    }
     Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");                   // Спросили у пользователя, чтобы он ввёл данные
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);                // array это переменная 

ShowArray(array);

// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом, а первый на последнем и.т.д.)  
// [1 2 3 4 5] -> [5 4 3 2 1]

// int [] ReverseArray(int [] array)
// {
//     int k = array.Length;
//     for(int i = 0; i<k/2; i++)
//     {
//          int temp = array[i];
//          array[i] = array[k-i-1];
//          array[k-i-1] = temp;
//     }
//     return array;
// }

// int [] reverseArray = ReverseArray(array);


// ShowArray(reverseArray);                                     

void FindCountDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 && array[i] % 7 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

FindCountDigits(array);