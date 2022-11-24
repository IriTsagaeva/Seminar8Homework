int[,] CreateNewRandomArray()
{
    int rowCount = new Random().Next(1, 10);
    int columnCount = new Random().Next(1, 10);
    int[,] resultArray = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            resultArray[row, column] = new Random().Next(1, 5);
        }
    }
    return resultArray;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
}

int GetMinSumRowIndex(int[,] array)
{
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0, i];
    }
    int minIndex = 0;
    for (int row = 1; row < array.GetLength(0); row++)
    {
        int sum = 0;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            sum += array[row, column];
        }
        if (sum < minSum)
        {
            minIndex = row;
        }
    }
    return minIndex+1;
}


Console.Clear();
int[,] array = CreateNewRandomArray();
PrintArray(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {GetMinSumRowIndex(array)}");