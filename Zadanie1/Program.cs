// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Пример 1)  M = 1; N = 5; -> "1, 2, 3, 4, 5";
// Пример 2)  M = 4; N = 8; -> "4, 5, 6, 7, 8".

void outputNumbersInBetween(int m, int n)
{
    if (m == n)
    {
        Console.WriteLine(n);
        return;
    }
    Console.Write(m + ", ");
    outputNumbersInBetween(m + 1, n);
}

outputNumbersInBetween(1, 5);
outputNumbersInBetween(4, 8);