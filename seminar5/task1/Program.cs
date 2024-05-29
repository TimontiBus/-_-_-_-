// // See https://aka.ms/new-console-template for more information
// char ch = 'E';
// char ch2 = 'r';
// char ch3 = 'r';
// Console.WriteLine(ch);
// Console.WriteLine(ch2);
// Console.WriteLine(ch3);



// char[] ch4 = { '1', '2', '$', '%' };
// Console.WriteLine(ch4);

// Задайте массив символов (тип char []). Создайте строку из символов этого массива.

char[] ch = { 'a', 'b', ';', 'd' };
string str = "";
foreach (char e in ch)
{
	str += e;
}

Console.WriteLine(str);