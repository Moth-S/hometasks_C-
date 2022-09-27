// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int GetIntValue() //возвращает целое случайное число
{
    return new Random().Next(1, 10);
}

int[,,] CreateArray(int rows, int columns, int depth) //создает трехмерный массив
{
    return new int[rows, columns, depth];
}

int[,,] GetArray(int[,,] arr) //заполняет 3d массив случайными числами [0,9]
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = GetIntValue();
            }

        }
    }
    return arr;
}

void PrintArray(int[,,] arr)//печатает трехмерный массив 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})" + " ");
            }
            Console.WriteLine();
        }

    }
}

int[,,] array3D = CreateArray(GetIntValue(), GetIntValue(), GetIntValue());

GetArray(array3D);
PrintArray(array3D);