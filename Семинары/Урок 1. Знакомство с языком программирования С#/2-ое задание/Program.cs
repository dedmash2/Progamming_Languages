/*
    Написать программу которая проверяет, является ли первое число квадратом второго
*/
string a = Console.ReadLine() ?? "",
       b = Console.ReadLine() ?? "";
int numA = int.Parse(a);
int numB = int.Parse(b);
if (Math.Pow(numB, 2) == numA)
{
    Console.WriteLine("да");
} else
{
    Console.WriteLine("нет");
}