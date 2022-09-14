// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Length: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] arr= new int[len];
int sum = 0;

for (int i=0; i<len; i++)
{
    arr[i] = new Random().Next(-100,101);

    if (i%2==1) sum+=arr[i];
}

Console.WriteLine($"Array: {String.Join(',', arr)}");
Console.WriteLine($"Summa: {sum}");

