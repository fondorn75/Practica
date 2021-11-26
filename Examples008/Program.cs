int[,] NewArray(int x, int y)
{
    int[,] arr = new int[x, y];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(2, 12);
        }
    }
    return arr;
}

int[,] image = new int[,]
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
    {12,12,12,12},
    {13,13,13,13},
    {14,14,14,14},
};

int[,] RandomArray(int[,] array)
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

int[,] arraynew = NewArray(13, 4);

Console.WriteLine(PrintArray(image));
RandomArray(image);
Console.WriteLine(PrintArray(image));
