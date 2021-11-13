// 15. Дано число. проверить кратно ли оно 7 и 23.

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

void Kvadrat(int x, int y)
{
    if (y * y == x) Console.WriteLine("Число " + x + " является квадратом числа " + y);
    else Console.WriteLine("Число " + x + " не является квадратом числа " + y);
}

Kvadrat(1201, 11);

// 18. Проверить истинность утверждения ¬(X ˅ Y)= ¬X ˄ ¬Y

void DisKon(int x, int y)
{
    //if (!(x && y) == !x & !y) Console.WriteLine("");

}

DisKon(10, 12);

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

void Palindrom(int number)
{
    int[] array = { 0, 0, 0, 0, 0 };
    string tmp = number.ToString();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(tmp[i].ToString());
        Console.WriteLine($"{array[i]}");
    }
    if (array[0] == array[4] && array[1] == array[3] && array[1] + 1 == array[2]) Console.WriteLine("Число полиндромно.");
    else Console.WriteLine("Число не полиндромно");
}

Palindrom(56765);

// 22. Найти расстояние между точками в пространстве 2D/3D
