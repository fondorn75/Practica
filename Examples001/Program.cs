using System;
// Задача
// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные

int[] NewArray(int count)
{
    int[] array = new int[count];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(10, 100);
        index++;
    }
    return array;
}

int index = 0;

int[] A = NewArray(10);

//Печать массива

while (index < A.Length)
{
    Console.WriteLine(A[index]);
    index++;
}

Console.WriteLine("нарушают порядок возрастания");

index = 0;
int max = 0;
int[] B = NewArray(10);

//Заполняем В

while (index < A.Length)
{
    if (A[index] > max)
    {
        B[index] = A[index];
        Console.WriteLine(B[index]);
        max = A[index];
    }
    index++;
}


Console.WriteLine("больше среднего арифметического элементов A");

index = 0;
int arifm = 0;

while (index < A.Length)
{
    arifm = A[index] + arifm;
    index++;
}
arifm = arifm / A.Length;
Console.WriteLine("Среднее арифметическое: " + arifm);

Console.WriteLine();

index = 0;
while (index < A.Length)
{
    if (arifm < A[index])
    {
        Console.WriteLine(A[index]);
    }
    index++;
}

Console.WriteLine("четные");

index = 0;
while (index < A.Length)
{
    if (A[index] % 2 == 0)
    {
        Console.WriteLine(A[index]);
    }
    index++;
}