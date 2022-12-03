int[,,] CreateNewRandomArray()
{
    int rowCount = 2;
    int columnCount = 2;
    int listCount = 2;
    int[,,] resultArray = new int[rowCount, columnCount, listCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            for (int list = 0; list < listCount; list++)
            {
                resultArray[row, column, list] = new Random().Next(10, 100);
            }            
        }
    }
    return resultArray;
}

void PrintArray(int[,,] array)
{
    for (int list = 0; list < array.GetLength(2); list++)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                Console.Write($"{array[row, column, list]} ({row},{column},{list}) ");
            }
            Console.WriteLine();            
        }
        Console.WriteLine();
    }
}

int[,,] array = CreateNewRandomArray();
PrintArray(array);
