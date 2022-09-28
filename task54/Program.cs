// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int GetIntValue(int start, int end)
{
    return new Random().Next(start, end);
}

int[] CreateArray(int size)
{
    return new int[size];
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

int[] GetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetIntValue(1, 10);
    }
    return arr;
}

int[,] DescendingSort(int[,] arr)
{
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            int maxElement = 0;
            for (int t = k; t < arr.GetLength(1); t++)
            {
                if (maxElement < arr[i, t])
                {
                    maxElement = arr[i, t];
                    index = t;
                }
            }

            int temporary = arr[i, k];
            arr[i, k] = maxElement;
            arr[i, index] = temporary;
            maxElement = 0;
        }
    return arr;

}

int[,] Get2DArray(int[,] arr2D)
{
    int[] arr = CreateArray(arr2D.GetLength(1));
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        GetArray(arr);

        int count = 0;
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = arr[count];
            count++;
        }
    }
    return arr2D;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array2D = Create2DArray(GetIntValue(3, 7), GetIntValue(3, 7));

Get2DArray(array2D);
Print2DArray(array2D);
Console.WriteLine();
DescendingSort(array2D);
Print2DArray(array2D);
