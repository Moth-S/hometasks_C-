// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFun(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermanFun(m - 1, 1);
    return AckermanFun(m - 1, AckermanFun(m, n - 1));
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = " + AckermanFun(m, n));