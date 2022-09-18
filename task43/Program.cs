// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите числа через пробел (k1,b1,k2,b2): ");
string inputData = Console.ReadLine();

string[] data = inputData.Split(" ");
Console.WriteLine($"Array: {String.Join("\t", data)}");

//не нашла как преобразоать массив из строкового типа в числовой, решила перезаписать в новый массив

int[] intData = new int[4];
for (int i=0; i<data.Length; i++)
{
    intData[i]=Convert.ToInt32(data[i]);
} 

float x=0, y=0;

x=(intData[2]-intData[0])/(intData[1]-intData[3]);
y=intData[1]*x+intData[0];

Console.WriteLine($"точка пересечения прямых ({x};{y})");



