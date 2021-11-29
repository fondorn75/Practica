﻿// Консольная игра "Угадай число"
// Комп загадал число в некотором диапазоне, например от 1 до 100. Далее он предлагает игроку угадать это число. Игрок вводит некоторое число и комп "отвечает":

// правильное ли это число или
// Загаданное число больше чем введенное
// загаданное число меньше чем введенное. После этого игрок делает следующую догадку. У Игрока есть некоторое количество попыток.
// Если игрок потратил все свои попытки, то игра заканчивается. Если игрок угадал число, но попытки еще остались, игра также заканчивается.

// Определить условия. (какой диапазон для загадывания чисел - мы его задаем, формируем рандомно или запрашиваем у пользователя?; определиться с количеством попыток - высчитать необходимое количество попыток, либо запросить у участника)
// Загадать число в указанном диапазоне.
// Начало игры - описываем правила.
// Запрашиваем у пользователя число. Пользователь вводит некоторое число (добавить проверку нештатных ситуаций). Определяем как оно соотносится с нашим загаданным и даем следующие инструкции игроку. Если пользователь не угадал, то у него сгорает 1 попытка.
// Игра продолжается пока есть попытки или пока пользователь не угадал число.
// int requestNumber() - метод запросит у игрока число, сделает все необходимые преобразования и вернет нам это число. int createNumber(int leftBound, int rightBound) - загадает число в указанном диапазоне и вернет его нам. bool MakeMove(int SecretNumber, int CountOfAttempts) - метод, в котором запрограммирован 1 игровой ход, в результате метод возвращает либо true, либо false. true если пользователь угадал число и игру надо остановить, false, если пользователь не угадал.

// int SecretNumber = createNumber(1, 100); int PlayersNumber = requestNumber();

//Объявляем переменные
int newNumber = 0;
int numberOfAttempts = 8;

int RandomNumber()
{
    int number = 0;
    number = new Random().Next(10, 100);
    return number;
}

int PlayerNumber()
{
    while (true)
    {
        Console.Write("Введите число: ");
        string text = Console.ReadLine()!;
        if (int.TryParse(text, out int number)) return number;
        else Console.WriteLine("Вы ввели не число.");
    }
}

string GameOver(int number)
{
    string text = "Вы угадали, это число: " + number;
    return text;
}

string NumberMax()
{
    string text = "Ваше число больше загаданного.";
    return text;
}

string NumberMin()
{
    string text = "Ваше число меньше загаданного.";
    return text;
}

void Game(int pc)
{
    int player = PlayerNumber();
    numberOfAttempts--;
    Console.WriteLine("У вас осталось: " + numberOfAttempts + " попыток");
    if (numberOfAttempts == 0)
    {
        Console.WriteLine("У вас осталось " + numberOfAttempts + " попыток. Игра закончена.");
    }
    else if (pc == player)
    {
        Console.WriteLine(GameOver(player));
    }
    else if (pc > player)
    {
        Console.WriteLine(NumberMin());
        Game(newNumber);
    }
    else if (pc < player)
    {
        Console.WriteLine(NumberMax());
        Game(newNumber);
    }
}

Console.WriteLine("Загадано число от 10 до 100.\nУ вас есть " + numberOfAttempts + " попыток, чтобы его найти.");

newNumber = RandomNumber();
//Console.WriteLine(newnumber);
Game(newNumber);