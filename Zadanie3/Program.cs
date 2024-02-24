// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// Пример: [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

void OutputElementsArrayFromEnd(int[] array, int lengthArray)
{
    if (lengthArray == 0)
    {
        return;
    }
    lengthArray = lengthArray - 1;
    Console.Write($"{array[lengthArray]} ");
    OutputElementsArrayFromEnd(array, lengthArray);
}

int[] array = new int[] {1, 2, 5, 0, 10, 34};
int lengthArray = array.Length;
OutputElementsArrayFromEnd(array, lengthArray);