// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Count rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Count columns: ");
int n = Convert.ToInt32(Console.ReadLine());

void GetDoubleMatrix(int rows, int columns)
{
    double[,] array = new double[rows,columns];
    for (int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            array[i,j]= new Random().NextDouble()*20-10;
            Console.Write(Math.Round(array[i,j],1)+"\t");
        }

        Console.WriteLine();
    }
}

GetDoubleMatrix(m,n);