// 23. Показать таблицу квадратов чисел от 1 до N 

int[] TabKvadrat(int n)
{
    int result = 1;
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = result * result;
        result++;
    }
    return array;
}

string PrintArr(int[] array)
{
    string res = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

int[] NewArray = TabKvadrat(12);

Console.WriteLine(PrintArr(NewArray));

// 24. Найти кубы чисел от 1 до N

int[] TabKub(int n)
{
    int result = 1;
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = result * result * result;
        result++;
    }
    return array;
}

int[] NewKub = TabKub(8);

Console.WriteLine(PrintArr(NewKub));

// 25. Найти сумму чисел от 1 до А

string Summa(int a)
{
    int b = 0;
    string res = string.Empty;
    for (int i = 1; i <= a; i++)
    {
        b = b + i;
        res = res + b + " ";
    }
    return res;
}
Console.WriteLine(Summa(5));

// 26. Возведите число А в натуральную степень B используя цикл

string NatSt(int a, int b)
{
    string res = string.Empty;
    int tmp = 0;

    for (int i = 1; i <= b; i++)
    {
        tmp = Convert.ToInt32(Math.Pow(a, i));
        res += tmp + " ";
    }

    return res;
}
Console.WriteLine(NatSt(2, 3));

// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру