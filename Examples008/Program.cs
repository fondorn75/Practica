int[,] koloda = new int[,]
{
    {2,2,2,2},
    {3,3,3,3},
    {4,4,4,4},
    {5,5,5,5},
    {6,6,6,6},
    {7,7,7,7},
    {8,8,8,8},
    {9,9,9,9},
    {10,10,10,10},
    {11,11,11,11},
    {10,10,10,10},
    {10,10,10,10},
    {10,10,10,10},
};

string[] koloda2 = { "2 червы", "2 бубны", "2 трефы", "2 пики",
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


int[,] RandomMultyArray(int[,] array)
{
    int tmp = 0;
    int q = 0;
    int t = 0;
    for (int i = array.GetLength(0) - 1; i >= 1; i--)
    {
        for (int j = array.GetLength(1) - 1; j >= 1; j--)
        {
            q = new Random().Next(i + 1);
            t = new Random().Next(j + 1);
            tmp = array[q, t];
            array[q, t] = array[i, j];
            array[i, j] = tmp;
        }
    }
    return array;
}

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

string PrintArray(int[,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j] + " ";
        }
        result += "\n";
    }
    return result;
}

string PrintArray2(string[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i] + ", ";
    }
    return result;
}

//Console.WriteLine(PrintArray(koloda));
//Console.WriteLine(PrintArray2(koloda2));
//RandomMultyArray(koloda);
RandomArray(koloda2);
//Console.WriteLine(PrintArray(koloda));
Console.WriteLine(PrintArray2(koloda2));