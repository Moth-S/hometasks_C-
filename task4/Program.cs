// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int count = 0, max=0;

while (count<3) {
    Console.WriteLine($"Введите {count+1} число ");
    int num = int.Parse(Console.ReadLine());
    if (num>max) max=num;
    count++;
}

Console.WriteLine(max);