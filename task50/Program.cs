// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int[4,3];

int[,] GetArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+"\t");
        }
        Console.WriteLine();
    }
    
    
}

GetArray(array);
PrintArray(array);

Console.Write("Введите индексы элемента матрицы через запятую -> ");
string i = Console.ReadLine();
int[] index = Array.ConvertAll(i.Split(","),int.Parse);

if (index[0]<array.GetLength(0) && index[1]<array.GetLength(1)) Console.WriteLine($"array[{index[0]}, {index[1]}] = {array[index[0],index[1]]}");
else Console.WriteLine("Такого числа в массиве нет!");