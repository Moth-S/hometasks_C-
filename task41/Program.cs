// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Length array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int count = 0;

for (int i=0; i<length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());

    if (array[i]>0) count+=1;
}


Console.WriteLine($"Array: {String.Join("\t", array)}");
Console.WriteLine($"Count positive number: {count}");


