// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Пример: m = 2; n = 3; -> A(m, n) = 9.

int AkkermanFuction(int m = 2, int n = 3)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0 && m > 0)
        {
            return AkkermanFuction(m - 1, 1);
        }
        else
        {
            return AkkermanFuction(m - 1, AkkermanFuction(m, n - 1));
        }
    }
}

int result = AkkermanFuction();
Console.WriteLine($"A(m, n) = {result}");