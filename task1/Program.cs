int[,] CreateNewRandomArray()
{
    int rowCount = new Random().Next(1, 10);
    int columnCount = new Random().Next(1, 10);
    int[,] resultArray = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            resultArray[row, column] = new Random().Next(1, 100);
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

int[,] SortArrayRows(int[,] array)
{

    for (int row = 0; row < array.GetLength(0); row++)
    {
        //int min = array[row,0];
        for (int column = 0; column < array.GetLength(1); column++)
        {
            for (int i = column + 1; i < array.GetLength(1); i++)
            {
                if (array[row, i] < array[row, column])
                {
                    int transfer = array[row, column];
                    array[row, column] = array[row, i];
                    array[row, i] = transfer;
                }
            }

        }
    }
    return array;
}


Console.Clear();
int[,] array = CreateNewRandomArray();
PrintArray(array);
array = SortArrayRows(array);
Console.WriteLine();
PrintArray(array);