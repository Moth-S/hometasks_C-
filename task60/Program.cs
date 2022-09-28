// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int GetInt2DigitNumber() //возвращает целое двухзначное случайное число
{
    return new Random().Next(10, 100);
}

int GetInt1DigitNumber() //возвращает случайную цифру
{
    return new Random().Next(1, 10);
}

int[,,] Create3DArray(int rows, int columns, int depth) //создает трехмерный массив
{
    return new int[rows, columns, depth];
}

int[] Create1DArray(int length) //создает одномерный массив массив
{
    return new int[length];
}

int[,,] Get3DArray(int[,,] arr, int[] array) //заполняет 3d массив  числами из одномерного массива
{
    int count=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = array[count];
                count++;

            }

        }
    }
    return arr;
}

void Print3DArray(int[,,] arr)//печатает трехмерный массив 
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

int[] GetArray(int[] arr)//заполняет одномерный массив неповторяющимися двузначными числами
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=GetInt2DigitNumber();
        if (i>0) 
        {
            for (int j = 0; j < i; j++)
            {
                while (arr[i]==arr[j])
                {
                    arr[i] = GetInt2DigitNumber();
                    j=0;
                }
                
            }
        }
    }
    return arr;
}


int[,,] array3D = Create3DArray(GetInt1DigitNumber(), GetInt1DigitNumber(), GetInt1DigitNumber());
int[] array = Create1DArray(array3D.GetLength(0)*array3D.GetLength(1)*array3D.GetLength(2));

GetArray(array);
Get3DArray(array3D, array);
Print3DArray(array3D);