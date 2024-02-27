// Рекурсивная функция для вычисления функции Аккермана
public static int Ackermann(int m, int n)
{
    // Базовый случай: A(0, n) = n + 1
    if (m == 0)
    {
        return n + 1;
    }

    // Случай: A(m, 0) = A(m-1, 1)
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }

    // Общий случай: A(m, n) = A(m-1, A(m, n-1))
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

// Пример использования функции
int m = 2;
int n = 3;
int result = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");

