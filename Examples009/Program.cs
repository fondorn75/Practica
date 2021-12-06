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
int tmp = 0;

int SummaDigitNumbers(int number)
{

    if (number > 0) tmp += SummaDigitNumbers(number % 10);
    return tmp;

}

Console.WriteLine(SummaDigitNumbers(123));

// 71. Написать программу вычисления функции Аккермана

int FunctionA(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionA(m - 1, 1);
    else return FunctionA(m - 1, FunctionA(m, n - 1));
}

Console.WriteLine(FunctionA(4, 0));

// 72. Написать программу возведения числа А в целую стень B


// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем
// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита