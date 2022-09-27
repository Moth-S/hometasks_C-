// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetIntValue(int start, int end)
{
    return new Random().Next(start, end);
}

Console.Write("Count rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Count columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int rows, int columns)
{
    return new int[rows,columns];
}

int[,] GetArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = GetIntValue(0,10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] SumRowElements(int[,] arr)
{
    int[] arrSum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summa+=arr[i,j];
        }
        arrSum[i] = summa;
    }
    return arrSum;
}

int MinSumma(int[] arr)
{
    int minNumber = arr[0];
    int index = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<minNumber) {
            minNumber=arr[i];
            index=i;
        }
        
    }

    return index+1;
}

int[,] array = CreateArray(m,n);
GetArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Min summa in {MinSumma(SumRowElements(array))} row");



