// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Length rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Length columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int[,] array) 
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j]=new Random().Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

void PrintAverageColumns(int[,] arr)
{
    
    double average = 0;

    for (int i = 0; i < columns; i++)
    {
        double sum=0;

        for (int j = 0; j < rows; j++)
        {
            sum+=arr[j,i];
        }

        average=sum/rows;
        Console.Write(Math.Round(average,1)+"\t");
    }
}

int[,] array = new int[rows,columns];

GetArray(array);
PrintArray(array);
Console.WriteLine();
PrintAverageColumns(array);
