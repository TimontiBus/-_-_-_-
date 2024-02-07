// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// Программа должна выдать ответ: Да/Нет.

int num = 6;
int[] array = new int [5] {1, 2, 3, 4, 5};

bool flag = false;

for(int i = 0; i<array.Length; i++)
{
    if(array[i]==num)
    {
       flag = true; 
    }  
}

if(flag)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}




