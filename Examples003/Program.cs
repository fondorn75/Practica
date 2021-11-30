// 15. Дано число. проверить кратно ли оно 7 и 23.

string Multiple(int number)
{
    string result = string.Empty;
    if (number % 7 == 0 && number % 23 == 0) result = "Число кратно 7 и 23";
    else result = "Число не кратно 7 и 23";
    return result;
}

Console.WriteLine(Multiple(160));

// 16. Дано число, обозначающее день недели. Выяснить является номер дня недели выходным.

string DayOfWeek(int a)
{
    string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    string result = string.Empty;
    if (a == 6 || a == 7) result = "Сегодня выходной: " + days[a - 1];
    else result = "Сегодня будний день: " + days[a - 1];
    return result;
}

Console.WriteLine(DayOfWeek(7));

// 17. По двум заданным числам проверять является ли одно квадратом другого.

string SquareNumber(int x, int y)
{
    string result = string.Empty;
    if (y * y == x) result = "Число " + x + " является квадратом числа " + y;
    else result = "Число " + x + " не является квадратом числа " + y;
    return result;
}

Console.WriteLine(SquareNumber(121, 12));

// 18. Проверить истинность утверждения ¬(X ˅ Y)= ¬X ˄ ¬Y

Console.WriteLine();

bool TrueStatement(bool x, bool y)
{
    return !(x || y) == (!x && !y);
}

Console.WriteLine(TrueStatement(false, false));
Console.WriteLine(TrueStatement(false, true));
Console.WriteLine(TrueStatement(true, false));
Console.WriteLine(TrueStatement(true, true));


// 19. Определить номер четверти и плоскости, в которой находится точка с координатами Х и У, причем Х ≠ 0 и У ≠ 0

string Quadrant(int x, int y)
{
    string result = string.Empty;
    if (x > 0 && y < 0) result = "1 четверть";
    if (x > 0 && y > 0) result = "2 четверть";
    if (x < 0 && y > 0) result = "3 четверть";
    if (x < 0 && y < 0) result = "4 четверть";

    return result;
}

Console.WriteLine(Quadrant(-6, 10));

// 20. Задать номер четверти, показать диапазоны для возможных координат.

string CoordinateRange(int x)
{
    string result = string.Empty;
    if (x == 1) result = "Диапазон координат: х от 0 до " + int.MaxValue + ", у от 0 до " + int.MinValue;
    if (x == 2) result = "Диапазон координат: х от 0 до " + int.MaxValue + ", у от 0 до " + int.MaxValue;
    if (x == 3) result = "Диапазон координат: х от 0 до " + int.MinValue + ", у от 0 до " + int.MaxValue;
    if (x == 4) result = "Диапазон координат: х от 0 до " + int.MinValue + ", у от 0 до " + int.MinValue;

    return result;
}
Console.WriteLine(CoordinateRange(3));

// 21. Программа проверяет пятизначное число на палиндромом.

string PalindromeNumber(int number)
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
Console.WriteLine(PalindromeNumber(56765));

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