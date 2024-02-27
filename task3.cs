// Рекурсивная функция для вывода элементов массива в обратном порядке
public static void PrintArrayReverse(int[] array, int index)
{
    // Базовый случай: индекс вышел за пределы массива
    if (index < 0)
    {
        return;
    }

    // Рекурсивный случай: вывести текущий элемент и перейти к следующему
    Console.Write($"{array[index]} ");
    PrintArrayReverse(array, index - 1);
}

// Пример использования функции
int[] array = { 1, 2, 3, 4, 5 };
PrintArrayReverse(array, array.Length - 1);

