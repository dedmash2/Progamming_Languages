/*Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
*/
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "");

num = Math.Abs(num);

for (int i = -num; i <= num; i++)
{
    Console.Write($"{i}, ");
}