// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int GetIntValue() //возвращает целое случайное число
{
    return new Random().Next(1, 10);
}

int[,] CreateArray(int rows, int columns) //создает двумерный массив
{
    return new int[rows,columns];
}

int[,] GetArray(int[,] arr) //заполняет массив случайными числами [0,9]
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = GetIntValue();
        }
    }
    return arr;
}

void PrintArray(int[,] arr)//печатает двумерный массив 
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

int[,] MatrixProduct(int[,] a1, int[,] a2)//перемножает две матрицы
{
    int[,] a3=CreateArray(a1.GetLength(0),a1.GetLength(1));
    for (int i = 0; i < a1.GetLength(0); i++)
    {
        for (int j = 0; j < a2.GetLength(1); j++)
        {
           for (int k = 0; k < a1.GetLength(0); k++)
           {
                a3[i,j]+=a1[i,k]*a2[k,j];
           }
        }
    }
    return a3;
}

int size=GetIntValue();
int[,] arr1=CreateArray(size,size);
GetArray(arr1);
PrintArray(arr1);
Console.WriteLine();

int[,] arr2=CreateArray(size,size);
GetArray(arr2);
PrintArray(arr2);
Console.WriteLine();

int[,] arr3=MatrixProduct(arr1,arr2);
PrintArray(arr3);



