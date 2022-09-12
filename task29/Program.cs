// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray(int length)
{
    int[] arr = new int[length];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;

}

System.Console.Write("Введите длину массива - ");
int lengthArr = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{String.Join(", ", GetArray(lengthArr))}");