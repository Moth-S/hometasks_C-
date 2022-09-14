// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Lenght: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[len];
int count = 0;

for (int i=0; i<len; i++)
{
    arr[i] = new Random().Next(100,1000);

    if (arr[i]%2==0) count+=1;
}

Console.WriteLine($"{String.Join(", ", arr)}");
Console.WriteLine($"Positiv numbers: {count}");