/*
Напишите программу, которая на вход принимает число и выдает его квадрат
*/
Console.Write("Введите число, квадрат которого вы хотите посчитать: ");
int num = int.Parse(Console.ReadLine() ?? string.Empty);
Console.WriteLine($"Квадрат числа {num} равен: {num * num}.");