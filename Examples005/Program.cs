// 31. Задать массив из 8 элементов и вывести их на экран 
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int[] NewArray(int n)
{
    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
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

Console.WriteLine(PrintArray(NewArray(8)));


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
        if (arr[i] == n) result = "Число" + n + " есть в массиве";
        else result = "Числа " + n + " нет в массиве";
    }

    return result;
}

Console.WriteLine(ProverkaNum(arr, 0));

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом