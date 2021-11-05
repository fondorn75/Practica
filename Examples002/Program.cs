// 0. Вывести квадрат числа 
int kvadrat()
{
    int x = 12;
    int result = x * x;
    return result;
}

int kv = kvadrat();
Console.WriteLine(kv);

// 1. По двум заданным числам проверять является ли первое квадратом второго
void FirstKvadrat()
{
    int x = 64;
    int y = 8;
    if (y * y == x)
    {
        Console.WriteLine("Первое число является квадратом второго.");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго.");
    }
}

FirstKvadrat();

// 2. Даны два числа. Показать большее и меньшее число 

void MaxOrMin()
{
    int x = 5;
    int y = 8;

    if (x > y)
    {
        Console.WriteLine("Большее число " + x);
        Console.WriteLine("Меньшее число " + y);
    }
    else
    {
        Console.WriteLine("Большее число " + y);
        Console.WriteLine("Меньшее число " + x);
    }
}

MaxOrMin();

// 3. По заданному номеру дня недели вывести его название

void Weeks(int day)
{
    string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    Console.WriteLine(days[day - 1]);

}

Weeks(7);

// 4. Найти максимальное из трех чисел 

void MaxInThree()
{
    int[] number = { 10, 4, 9 };
    int max = 0;

    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > max) max = number[i];
    }

    Console.WriteLine(max);
}

MaxInThree();

// 5. Написать программу вычисления значения функции y=sin(a) (синус или косинус)

void Sinus(double a)
{
    double y = 0;
    y = Math.Sin(a);
    Console.WriteLine(y);

}

Sinus(10);

// 6. Выяснить является ли число чётным 

void Chetnoe(int number)
{
    if (number % 2 == 0) Console.WriteLine("Число: " + number + " четное.");
    else Console.WriteLine("Число: " + number + " нечетное.");
}

Chetnoe(12);

// 7. Показать числа от -N до N 

void Numbers(int n)
{
    int length = n + n;
    for (int i = 0; i < length + 1; i++)
    {

        Console.WriteLine(-n + i);
    }

}
Numbers(5);

// 8. Показать четные числа от 1 до N 

void ArrayNumbers(int n)
{
    for (int i = 1; i < n + 1; i++)
    {

        Console.WriteLine(i);
    }

}
Console.WriteLine();
ArrayNumbers(5);

// 9. Показать последнюю цифру трёхзначного числа

Console.WriteLine();
int number = 123;
string end = Convert.ToString(number);
Console.WriteLine(end[2]);

// 10. Показать вторую цифру трёхзначного числа

Console.WriteLine();
number = 258;
end = Convert.ToString(number);
Console.WriteLine(end[1]);

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа



// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет

