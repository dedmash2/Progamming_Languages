/*
Напишите программу, которая принимает на вход трехзначное число и выводит последнюю цифру этого числа
*/
Console.WriteLine("Введите трехзначное число(от 100 до 999): ");
int num = int.Parse(Console.ReadLine() ?? "");
if (num >= 100 && num <= 999)
{
    Console.WriteLine(num % 10);
}else
{
    Console.WriteLine("Введите корректное трехзначное число!");
}
