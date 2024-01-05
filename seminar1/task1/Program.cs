// Напишите прорамму, которая принимает на вход трёхзначное число
// и удаляет вторую цифру этого числа

int num = 345;
num = Math.Abs(num);
int first_dig = num / 100;
int second_dig = num % 10;
Console.Write($"{first_dig}{second_dig}");
