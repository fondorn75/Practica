using System;
// Задача
// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные


int[] A = new int[10];
int index = 0;
while (index < A.Length)
{
    A[index] = new Random().Next(10, 100);
    index++;
}

index = 0;

while (index < A.Length)
{
    Console.WriteLine(A[index]);
    index++;
}

Console.WriteLine("massive B");

index = 0;
int max = 0;

while (index < A.Length)
{
    if (A[index] > max)
    {
        Console.WriteLine(A[index]);
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
Console.WriteLine(arifm);


Console.WriteLine();
index = 0;
while (index < A.Length)
{
    if (arifm< A[index])
    {
        Console.WriteLine(A[index]);
    }
index++;
}