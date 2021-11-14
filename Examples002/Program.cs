// 0. Вывести квадрат числа 

Console.WriteLine("Вывести квадрат числа");
int kvadrat()
{
    int x = 12;
    int result = x * x;
    return result;
}

int kv = kvadrat();
Console.WriteLine(kv);

// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("является ли первое квадратом второго");
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

Console.WriteLine("Показать большее и меньшее число");
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

Console.WriteLine("По заданному номеру дня недели вывести его название");
void Weeks(int day)
{
    string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    Console.WriteLine(days[day - 1]);

}

Weeks(7);

// 4. Найти максимальное из трех чисел 

Console.WriteLine("Найти максимальное из трех чисел");
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

Console.WriteLine("Вычисление значения функции y=sin(a)");
void Sinus(double a)
{
    double y = 0;
    y = Math.Sin(a);
    Console.WriteLine(y);

}

Sinus(10);

// 6. Выяснить является ли число чётным 

Console.WriteLine("Выяснить является ли число чётным");
void Chetnoe(int number)
{
    if (number % 2 == 0) Console.WriteLine("Число: " + number + " четное.");
    else Console.WriteLine("Число: " + number + " нечетное.");
}

Chetnoe(12);

// 7. Показать числа от -N до N 

Console.WriteLine("Показать числа от -N до N");
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

Console.WriteLine("Показать четные числа от 1 до N");
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

Console.WriteLine("Показать последнюю цифру трёхзначного числа");
int number = 123;
string end = Convert.ToString(number);
Console.WriteLine(end[2]);

// 10. Показать вторую цифру трёхзначного числа

Console.WriteLine("Показать вторую цифру трёхзначного числа");
number = 258;
end = Convert.ToString(number);
Console.WriteLine(end[1]);

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Показать наибольшую цифру числа");

void RandomNumber()
{
    int randomNumber = new Random().Next(10, 99);
    int x1 = randomNumber / 10;
    int x2 = randomNumber % 10;
    if (x1 > x2) Console.WriteLine(x1);
    else Console.WriteLine(x2);
}

RandomNumber();

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

void Kratnoe(int x1, int x2)
{
    int ostatok = 0;
    if (x1 % x2 == 0) Console.WriteLine("Число " + x1 + " кратное числу " + x2);
    else
    {
        ostatok = x1 % x2;
        Console.WriteLine(ostatok);
    }
}

Kratnoe(12, 4);

// 14. Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Найти третью цифру числа или сообщить, что её нет");

void ThreeNumber(int x0)
{
    if (x0 / 100 == 0) Console.WriteLine("Третьей цифры нет.");
    else
    {
        int threeNumber = x0 % 10;
        Console.WriteLine("Третья цифра: " + threeNumber);
    }
}

ThreeNumber(49);

