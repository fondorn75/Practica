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

int[] NewArray = TabKvadrat(12);

string PrintArr(int[] array)
{
    string res = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += $"{array[i]}, ";
    }
    return res;
}

Console.WriteLine(PrintArr(NewArray));

// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру