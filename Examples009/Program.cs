// 66. Показать натуральные числа от 1 до N, N задано
string result = string.Empty;

string naturalNumber(int n)
{
    if (n > 1) naturalNumber(n - 1);
    result += n + " ";
    return result;
}

Console.WriteLine(naturalNumber(10));

// 67. Показать натуральные числа от N до 1, N задано
string result2 = string.Empty;
string naturalNumber2(int n)
{
    result2 += n + " ";
    if (n > 1) naturalNumber2(n - 1);
    return result2;
}

Console.WriteLine(naturalNumber2(10));

// 68. Показать натуральные числа от M до N, N и M заданы

string tempString = string.Empty;

string NaturalNumberMN(int m, int n)
{
    if (m < n) NaturalNumberMN(m, n - 1);
    tempString += n + " ";

    return tempString;
}
Console.WriteLine(NaturalNumberMN(10, 20));

// 69. Найти сумму элементов от M до N, N и M заданы
int temp = 0;

int SummaNumber(int m, int n)
{
    if (m < n) SummaNumber(m, n - 1);
    temp += n;

    return temp;
}

Console.WriteLine(SummaNumber(1, 5));

// 70. Найти сумму цифр числа

int SummaDigitNumbers(int number)
{
    if (number > 1) return number % 10 + SummaDigitNumbers(number / 10);
    else return 1;
}

Console.WriteLine(SummaDigitNumbers(12345));

// 71. Написать программу вычисления функции Аккермана
// Функция Аккермана определяется рекурсивно для неотрицательных целых чисел m и n следующим образом:
// A(m, n) = n + 1 если m = 0
//           A(m-1,1) если m > 0, n = 0
//           A(m - 1, A(m, n - 1)) если m > 0, n > 0

int FunctionA(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionA(m - 1, 1);
    else return FunctionA(m - 1, FunctionA(m, n - 1));
}

Console.WriteLine(FunctionA(4, 0));

// 72. Написать программу возведения числа А в целую стень B

int tempSqrt = 0;

int SqrtNumber(int a, int b)
{
    if (b > 0) return SqrtNumber(a, b - 1) * a;
    tempSqrt = a;
    return tempSqrt;
}

Console.WriteLine(SqrtNumber(2, 10));


// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//     Первые два элемента последовательности задаются пользователем

string res = string.Empty;
int tmp2 = 0;

string FirstNumbers(int a, int b, int n)
{
    tmp2 = a + b;
    a = b;
    b = tmp2;
    res += tmp2 + " ";
    if (n > 1) FirstNumbers(a, b, n - 1);

    return res;
}

Console.WriteLine(FirstNumbers(2, 3, 5));

// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//     Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита