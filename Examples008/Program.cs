string[] koloda = { "2 червы", "2 бубны", "2 трефы", "2 пики",
                    "3 червы", "3 бубны", "3 трефы", "3 пики",
                    "4 червы", "4 бубны", "4 трефы", "4 пики",
                    "5 червы", "5 бубны", "5 трефы", "5 пики",
                    "6 червы", "6 бубны", "6 трефы", "6 пики",
                    "7 червы", "7 бубны", "7 трефы", "7 пики",
                    "8 червы", "8 бубны", "8 трефы", "8 пики",
                    "9 червы", "9 бубны", "9 трефы", "9 пики",
                    "10 червы", "10 бубны", "10 трефы", "10 пики",
                    "валет червы", "валет бубны", "валет трефы", "валет пики",
                    "дама червы", "дама бубны", "дама трефы", "дама пики",
                    "король червы", "король бубны", "король трефы", "король пики",
                    "туз червы", "туз бубны", "туз трефы", "туз пики", };


string[] RandomArray(string[] array)
{
    string tmp = string.Empty;
    int q = 0;
    for (int i = array.Length - 1; i >= 1; i--)
    {
        q = new Random().Next(i + 1);
        tmp = array[q];
        array[q] = array[i];
        array[i] = tmp;
    }
    return array;
}

string PrintArray(string[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i] + ", ";
    }
    return result;
}

Console.WriteLine(PrintArray(koloda));
RandomArray(koloda);
Console.WriteLine(PrintArray(koloda));