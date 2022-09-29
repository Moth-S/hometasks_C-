// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetIntNumber() ///возвращает целое случайное число
{
    return new Random().Next(1, 20);
}

int SumNumbers(int startNum, int endNum)
{
    if (startNum == endNum) return startNum;

    return startNum + SumNumbers(startNum + 1, endNum);
}

int startNum = GetIntNumber();
int endNum = GetIntNumber();

if (startNum > endNum)
{
    Console.WriteLine("Так не работает! :Р");
    return;
}

Console.WriteLine($"Сумма чисел от {startNum} до {endNum}: " + SumNumbers(startNum, endNum));