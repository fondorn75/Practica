﻿// 15. Дано число. проверить кратно ли оно 7 и 23.

void Kratno(int a)
{
    if (a % 7 == 0 && a % 23 == 0) Console.WriteLine("Число кратно 7 и 23");
    else Console.WriteLine("Число не кратно 7 и 23");
}

Kratno(161);

// 16. Дано число, обозначающее день недели. Выяснить является номер дня недели выходным.

void WeekDay(int a)
{
    string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

    if (a == 6) Console.WriteLine("Сегодня выходной: " + days[a - 1]);
    else if (a == 7) Console.WriteLine("Сегодня выходной: " + days[a - 1]);
    else Console.WriteLine("Сегодня будний день: " + days[a - 1]);
}

WeekDay(3);

// 17. По двум заданным числам проверять является ли одно квадратом другого.

string Kvadrat(int x, int y)
{
    string result = string.Empty;
    if (y * y == x) result = "Число " + x + " является квадратом числа " + y;
    else result = "Число " + x + " не является квадратом числа " + y;
    return result;
}

Console.WriteLine(Kvadrat(121, 12));

// 18. Проверить истинность утверждения ¬(X ˅ Y)= ¬X ˄ ¬Y

Console.WriteLine();

bool DisKon(bool x, bool y)
{
    return !(x || y) == (!x && !y);
}

Console.WriteLine(DisKon(false, false));
Console.WriteLine(DisKon(false, true));
Console.WriteLine(DisKon(true, false));
Console.WriteLine(DisKon(true, true));


// 19. Определить номер четверти и плоскости, в которой находится точка с координатами Х и У, причем Х ≠ 0 и У ≠ 0

void Chetvert(int x, int y)
{
    if (x > 0 && y < 0) Console.WriteLine("1 четверть");
    if (x > 0 && y > 0) Console.WriteLine("2 четверть");
    if (x < 0 && y > 0) Console.WriteLine("3 четверть");
    if (x < 0 && y < 0) Console.WriteLine("4 четверть");
}

Chetvert(-6, 10);

// 20. Задать номер четверти, показать диапазоны для возможных координат.

void Diapason(int x)
{
    if (x == 1) Console.WriteLine("Диапазон координат: х от 0 до " + int.MaxValue + " у от 0 до " + int.MinValue);
    if (x == 2) Console.WriteLine("Диапазон координат: х от 0 до " + int.MaxValue + " у от 0 до " + int.MaxValue);
    if (x == 3) Console.WriteLine("Диапазон координат: х от 0 до " + int.MinValue + " у от 0 до " + int.MaxValue);
    if (x == 4) Console.WriteLine("Диапазон координат: х от 0 до " + int.MinValue + " у от 0 до " + int.MinValue);
}
Diapason(3);

// 21. Программа проверяет пятизначное число на палиндромом.

string Palindrom(int number)
{
    int[] array = { 0, 0, 0, 0, 0 };
    string result = string.Empty;
    string tmp = number.ToString();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(tmp[i].ToString());
    }
    if (array[0] == array[4] && array[1] == array[3] && array[1] + 1 == array[2]) result = "Число " + number + " полиндромно.";
    else result = "Число " + number + " не полиндромно";
    return result;
}
Console.WriteLine(Palindrom(56765));

// 22. Найти расстояние между точками в пространстве 2D/3D
// Формула вычисления расстояния от точки A(xa, ya) до точки B(xb, yb) на плоскости:
// AB = √(xb - xa)2 + (yb - ya)2
// Формула вычисления расстояния от точки A(xa, ya, za) до точки B(xb, yb, zb) в пространстве:
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double Ploskost2D(double xa, double ya, double xb, double yb)
{
    int kv = 2;
    double result = Math.Sqrt((Math.Pow((xb - xa), kv) + (Math.Pow((yb - ya), kv))));
    return result;
}

double Ploskost3D(double xa, double ya, double za, double xb, double yb, double zb)
{
    int kv = 2;
    double result = Math.Sqrt((Math.Pow((xb - xa), kv) + (Math.Pow((yb - ya), kv) + (Math.Pow((zb - za), kv)))));
    return result;
}

Console.WriteLine(Ploskost2D(12, 5, -10, 20));
Console.WriteLine(Ploskost3D(12, 5, -10, 20, 15, 25));