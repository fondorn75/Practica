// 48. Показать двумерный массив размером m×n заполненный целыми числами

int[,] NewArray(int m, int n, int ch1, int ch2)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(ch1, ch2);
        }
    }

    return array;
}

string PrintArray(int[,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += $"{array[i, j]} ";
        }
        result += "\n";
    }
    return result;
}

int[,] ArrayMN = NewArray(4, 4, 0, 10);
Console.WriteLine(PrintArray(ArrayMN));


// 49. Показать двумерный массив размером m×n заполненный вещественными числами

int[,] ArrayMN2 = NewArray(4, 4, -10, 10);
Console.WriteLine(PrintArray(ArrayMN2));

// 50. В двумерном массиве n×k заменить четные элементы на противоположные

int[,] ArrayNK(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[array.GetLength(0) - i - 1, array.GetLength(1) - j - 1] = array[i, j];
        }
    }
    return result;
}

int[,] ArrayNK_New = ArrayNK(ArrayMN);
Console.WriteLine(PrintArray(ArrayNK_New));

// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] NewPravArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }

    return array;
}

int[,] ArrayNK_New2 = NewPravArray(5, 6);
Console.WriteLine(PrintArray(ArrayNK_New2));

// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты



// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет



// 54. В матрице чисел найти сумму элементов главной диагонали



// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.