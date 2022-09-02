// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7 (день недели): ");
string dayOfTheWeek=Console.ReadLine();

if (dayOfTheWeek=="6" || dayOfTheWeek=="7") Console.WriteLine("Выходной");
else Console.WriteLine("Будний день");