// 31. Задать массив из 8 элементов и вывести их на экран 
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int[] NewArray(int n, int x, int y)
{
    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(x, y);
    }

    return array;
}

string PrintArray(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i] + " ";
    }
    return result;
}

Console.WriteLine(PrintArray(NewArray(8, 0, 2)));


// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] NewArr(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }

    return array;
}

int[] arr = NewArr(12);

Console.WriteLine(PrintArray(arr));

int SummaPol(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) summa += array[i];
    }

    return summa;
}
int SummaOtr(int[] array)
{
    int summa = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) summa += array[i];
    }

    return summa;
}
Console.WriteLine("Сумма положительных элементов массива = " + SummaPol(arr));
Console.WriteLine("Сумма отрицательных элементов массива = " + SummaOtr(arr));

// 34. Написать программу замену элементов массива на противоположные

string Zamena(int[] array)
{
    string result = string.Empty;
    int tmp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        tmp = array[i] * -1;
        result += tmp + " ";
    }
    return result;
}

Console.WriteLine(Zamena(arr));


// 35. Определить, присутствует ли в заданном массиве, некоторое число 

string ProverkaNum(int[] arr, int n)
{
    string result = string.Empty;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == n)
        {
            result = "Число " + n + " есть в массиве";
            break;
        }
        else result = "Числа " + n + " нет в массиве"; ;
    }

    return result;
}

Console.WriteLine(ProverkaNum(arr, 2));

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] NewArray2(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

int[] arraynew = NewArray2(12);

Console.WriteLine(PrintArray(arraynew));

string ChetNechet(int[] array)
{
    string result = string.Empty;
    int chet = 0;
    int nechet = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) chet++;
        else nechet++;
    }
    result = "Четных чисел - " + chet + ", а нечетных - " + nechet;
    return result;
}

Console.WriteLine(ChetNechet(arraynew));

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array123 = NewArray(123, 0, 500);

int KolEl(int[] array)
{
    int kolvo = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) kolvo++;
    }
    return kolvo;
}

Console.WriteLine(PrintArray(array123));
Console.WriteLine("Количество элементов из отрезка [10,99] = " + KolEl(array123));

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

string Nechet(int[] array)
{
    string result = string.Empty;
    int summ = 0;
    string itog = string.Empty;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i] + " ";
        summ += array[i];
    }

    itog = "Массив: " + result + " Сумма: " + summ;
    return itog;
}

Console.WriteLine(Nechet(arraynew));

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] arrayodnomer = NewArray(12, 1, 10);

string ProisvPar(int[] array)
{
    string result = string.Empty;
    int proisv = 0;
    int j = array.Length - 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length / 2)
        {
            proisv = array[i] * array[j];
            result += proisv + " ";
            j--;
        }

    }

    return result;
}

Console.WriteLine(PrintArray(arrayodnomer));
Console.WriteLine(ProisvPar(arrayodnomer));

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int MinNumber(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }

    return min;
}
int MaxNumber(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }

    return max;
}
int rasnitca = MinNumber(arraynew) + MaxNumber(arraynew);
Console.WriteLine("Разница между максимальным и минимальным элементом = " + rasnitca);
