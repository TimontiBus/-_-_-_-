// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого числа в степень, 
// равную третьеё цифре.

int num = 678;
num = Math.Abs(num);
int first_dig = (num % 100) / 10;
int second_dig = num % 10;
int pow = 1;
for (int i = 1; i <= second_dig; i++)
{
	pow = pow * second_dig;
}
Console.Write(pow);

