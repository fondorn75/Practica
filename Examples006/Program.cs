// 41. Выяснить являются ли три числа сторонами треугольника 
//Если сумма любых двух чисел (из трех заданных) больше третьего, то они могут быть длинами сторон треугольника.
// CT = (a+b-c)*(b+c-a)*(c+a-b)/(a*b*c)
// CT = 1. Такое качество имеют лишь равносторонние треугольники. 
// CT<0,5. Это треугольники низкого качества, один угол у них является тупым, что говорит о некоторой доле «приплюснутости» таких фигур. 
// CT => 0. Абсолютно вырожденный треугольник.

string Triangle(int a, int b, int c)
{
    string result = string.Empty;
    int ct = 0;
    if (a + b > c || b + c > a || a + c > b)
    {
        ct = (a + b - c) * (b + c - a) * (c + a - b) / (a * b * c);
        result = "Числа являются сторонами треугольника. Качество треугольника = " + ct;
    }


    return result;
}

Console.WriteLine(Triangle(10, 10, 10));

// 42. Определить сколько чисел больше 0 введено с клавиатуры

int number = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int x)
{
    int tmp = 0;
    string str = Convert.ToString(x);
    int[] arr = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = x % 10;
        tmp = x / 10;
        x = tmp;
    }
    return arr;
}

string PrintArray(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result += array[i] + " ";
    }
    return result;
}

Console.WriteLine(PrintArray(FillArray(number)));

// 43. Написать программу преобразования десятичного числа в двоичное

string NumerDez(int num)
{
    string result = string.Empty;
    result = Convert.ToString(num, 2).PadLeft(8, '0');
    return result;
}

Console.WriteLine(NumerDez(248));

// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

string TochkaPer(int b1, int b2, int k1, int k2)
{
    string result = string.Empty;
    int x = 0;
    int y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = ((b2 * k1) - (b1 * k2)) / (k1 - k2);
    result = "x = " + x + " y = " + y;
    return result;
}

Console.WriteLine(TochkaPer(3, -1, 4, 2));

// 45. Показать числа Фибоначчи

string Fibonacci(int n)
{
    string result = string.Empty;
    int tmp = 0;
    int tmp1 = 0;
    int tmp2 = 1;

    for (int i = 0; i < n; i++)
    {
        tmp = tmp1 + tmp2;
        tmp1 = tmp2;
        tmp2 = tmp;
        result += tmp + " ";
    }

    return result;
}

Console.WriteLine(Fibonacci(20));

// 46. Написать программу масштабирования фигуры

int[,] FillArray2(int x, int y)
{
    int[,] array = new int[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 4);
        }
    }
    return array;
}

void PrintArray2(int[,] tabl)
{
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            Console.Write($"{tabl[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Scale(int[,] array, int k)
{
    string result = string.Empty;
    int[,] array2 = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[i, j] = array[i, j] * k;
            Console.Write($"{array2[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] newarray = FillArray2(4, 2);
PrintArray2(newarray);
Console.WriteLine();
Scale(newarray, 2);

//47. Написать программу копирования массива