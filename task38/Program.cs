// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("Length: ");
int len = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[len];
double minNumber = 100;
double maxNumber = 0;

for (int i=0;i<len;i++)
{
    arr[i] = new Random().NextDouble()*100;
    arr[i]=Math.Round(arr[i],2);

    if (arr[i]>maxNumber) maxNumber=arr[i];
    if (arr[i]<minNumber) minNumber=arr[i];
}

Console.WriteLine($"Array: {String.Join("\t", arr)} ");

System.Console.WriteLine($"maxNumber - minNumber = {Math.Round(maxNumber-minNumber,2)}");