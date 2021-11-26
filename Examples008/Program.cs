int[] NewArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(2, 12);
    }
    return arr;
}


int[] RandomArray(int[] array)
{
    int tmp = 0;
    int j = 0;
    for (int i = array.Length - 1; i >= 1; i--)
    {
        j = new Random().Next(i + 1);
        tmp = array[j];
        array[j] = array[i];
        array[i] = tmp;
    }
    return array;
}

string PrintArray(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i] + " ";
    }
    return result;
}

int[] arraynew = NewArray(52);

Console.WriteLine(PrintArray(arraynew));
RandomArray(arraynew);
Console.WriteLine();
Console.WriteLine(PrintArray(arraynew));
