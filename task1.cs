// Рекурсивная функция для вывода всех натуральных чисел в промежутке от M до N
public static void PrintNaturalNumbers(int m, int n)
{
    // Если M равно N, вывести M и завершить рекурсию
    if (m == n)
    {
        Console.WriteLine(m);
        return;
    }

    // Вывести M и вызвать рекурсию для вывода следующего числа
    Console.WriteLine(m);
    PrintNaturalNumbers(m + 1, n);
}

// Пример использования функции
int m = 5;
int n = 10;
PrintNaturalNumbers(m, n);

