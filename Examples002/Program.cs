// 0. Вывести квадрат числа 

Console.WriteLine("Вывести квадрат числа");
int kvadrat(int x)
{
    int result = x * x;
    return result;
}

int kv = kvadrat(14);
Console.WriteLine(kv);

// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("является ли первое квадратом второго");
string FirstKvadrat(int x, int y)
{
    string res = string.Empty;
    if (y * y == x) res = "Число " + x + " является квадратом числа " + y;
    else res = "Число " + x + " не является квадратом числа " + y;
    return res;
}

Console.WriteLine(FirstKvadrat(121, 11));

// 2. Даны два числа. Показать большее и меньшее число 

Console.WriteLine("Показать большее и меньшее число");

string MaxOrMin(int x, int y)
{
    string res = string.Empty;
    if (x > y) res = $"{"Большее число - " + x}, {"Меньшее число - " + y}";
    else res = $"{"Большее число - " + y}, {"Меньшее число - " + x}";
    return res;
}

Console.WriteLine(MaxOrMin(5, 8));

// 3. По заданному номеру дня недели вывести его название

Console.WriteLine("По заданному номеру дня недели вывести его название");

string Weeks(int day)
{
    string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    return days[day - 1];
}

Console.WriteLine(Weeks(7));

// 4. Найти максимальное из трех чисел 

Console.WriteLine("Найти максимальное из трех чисел");

int MaxInThree()
{
    int[] array = { 45, 35, 48 };
    int max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }

    return max;
}

Console.WriteLine(MaxInThree());

// 5. Написать программу вычисления значения функции y=sin(a) (синус или косинус)

Console.WriteLine("Вычисление значения функции y=sin(a)");

double Sinus(double a)
{
    double y = 0;
    y = Math.Sin(a);
    return y;
}

Console.WriteLine(Sinus(45));

// 6. Выяснить является ли число чётным 

Console.WriteLine("Выяснить является ли число чётным");
string Chetnoe(int number)
{
    string result = string.Empty;
    if (number % 2 == 0) result = "Число: " + number + " четное.";
    else result = "Число: " + number + " нечетное.";
    return result;
}

Console.WriteLine(Chetnoe(12));

// 7. Показать числа от -N до N 

Console.WriteLine("Показать числа от -N до N");

string ShowNumbers(int n)
{
    string result = string.Empty;
    for (int i = -n; i < n + 1; i++)
    {
        result += i + " ";
    }

    return result;
}
Console.WriteLine(ShowNumbers(5));

// 8. Показать четные числа от 1 до N 

Console.WriteLine("Показать четные числа от 1 до N");
string ArrayNumbers(int n)
{
    string result = string.Empty;
    for (int i = 1; i < n + 1; i++)
    {
        result += i + " ";
    }
    return result;
}

Console.WriteLine(ArrayNumbers(5));

// 9. Показать последнюю цифру трёхзначного числа

Console.WriteLine("Показать последнюю цифру трёхзначного числа");
int LastDigit(int number)
{
    int temp = number % 10;
    return temp;
}

Console.WriteLine(LastDigit(124));

// 10. Показать вторую цифру трёхзначного числа

Console.WriteLine("Показать вторую цифру трёхзначного числа");
int SecondDigit(int number)
{
    int temp = (number % 100) / 10;
    return temp;
}

Console.WriteLine(SecondDigit(458));

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Показать наибольшую цифру числа");

string RandomNumber()
{
    string result = string.Empty;
    int randomNumber = new Random().Next(10, 99);
    int x1 = randomNumber / 10;
    int x2 = randomNumber % 10;
    if (x1 > x2) result = "Задано число: " + randomNumber + " наибольшее: " + x1;
    else result = "Задано число: " + randomNumber + " наибольшее: " + x2;

    return result;
}

Console.WriteLine(RandomNumber());

// 12. Удалить вторую цифру трёхзначного числа

Console.WriteLine("Удалить вторую цифру трёхзначного числа");

int DelNumber(int x1)
{
    string str = x1.ToString();
    int x2 = int.Parse(str[0].ToString() + str[2].ToString());
    return x2;
}
Console.WriteLine(DelNumber(486));

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("кратно ли число заданному, если нет, вывести остаток.");

string Kratnoe(int x1, int x2)
{
    int ostatok = 0;
    string res = string.Empty;
    if (x1 % x2 == 0) res = ("Число " + x1 + " кратное числу " + x2);
    else
    {
        ostatok = x1 % x2;
        res = "Число " + x1 + " не кратно числу " + x2 + " имеется остаток - " + ostatok;
    }
    return res;
}

Console.WriteLine(Kratnoe(12, 5));

// 14. Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Найти третью цифру числа или сообщить, что её нет");

string ThreeNumber(int number)
{
    string result = string.Empty;
    if (number / 100 == 0) result = "Третьей цифры нет.";
    else
    {
        int threeNumber = number % 10;
        result = "Третья цифра: " + threeNumber;
    }
    return result;
}

Console.WriteLine(ThreeNumber(459));

