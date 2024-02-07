// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

// Чисто моё решение
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; 

// int numbers = 0;
// int minRange = 10;
// int maxRange = 90;
// for(int i=0; i<array.Length; i++)
// {
//     if(array[i]>=minRange && array[i]<=maxRange)
//     {
//        numbers  = numbers + 1;
//     }
// }
// Console.Write(numbers);

public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
      int count = 0;
        foreach (int num in numbers)
        {
            if (num >= minRange && num <= maxRange)
            {
                count++;
            }
        }
        return count;
         //Введите сюда свое решение
    }
    
    public static void PrintResult(int[] array)
    {
        int minRange = 10;
        int maxRange = 90;
        int numbers = CountItemsRange(array, minRange, maxRange);
        Console.Write(numbers);
          //Введите сюда свое решение
    }
