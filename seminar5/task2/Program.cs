// See https://aka.ms/new-console-template for more information
// На оснвое симоволов строки (тип string) сформировать массив символов (тип char[]).

string str = "Hellow!";
char[] ch = new char[str.Length];
for (int i = 0; i < str.Length; i++)
{
	ch[i] = str[i];
}
foreach (char e in ch)
{
	Console.WriteLine(e + " ");
}