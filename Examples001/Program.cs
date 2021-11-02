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

int[] B = new int[10];
index = 0;
int max = A[0];
Console.WriteLine(max);
while (index < A.Length)
{
    if (A[index] > max)
    {
        B[index] = max;
        Console.WriteLine(B[index]);
        
        max = B[index];
    }
    index++;
}


// index = 0;
// int max = A[0];
// while (index < A.Length)
// {
//     if (A[index] > max) B[index] = max;
//     Console.WriteLine(B[index]);
//     index++;

// }