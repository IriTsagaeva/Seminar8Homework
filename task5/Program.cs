int[,] CreateNewArray()
{
    int rowCount = new Random().Next(2, 6);
    int colCount = new Random().Next(2, 6);
    int[,] array = new int[rowCount, colCount];
    int firstRowIndex = 0;
    int firstColIndex = 0;
    int direction = 0;
    for (int k = 1; k <= array.GetLength(0)*array.GetLength(1);)
    {
        if (direction == 0)
        {
            for (int j = firstColIndex; j < colCount; j++)
            {
                array[firstRowIndex, j] = k;
                k++;
            }
            firstRowIndex++;
            direction = 1;
        }
        else if (direction == 1)
        {
            for (int j = firstRowIndex; j < rowCount; j++)
            {
                array[j, colCount-1] = k;
                k++;
            }
            colCount--;
            direction = 2;
        }
        else if (direction == 2)
        {
            for (int j = colCount-1; j >= firstColIndex; j--)
            {
                array[rowCount-1, j] = k;
                k++;
            }
            rowCount--;
            direction = 3;
        }
        else
        {
            for (int j = rowCount-1; j >= firstRowIndex; j--)
            {
                array[j,firstColIndex] = k;
                k++;
            }
            firstColIndex++;
            direction = 0;
        }
    }
    
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] myArray = CreateNewArray();
System.Console.WriteLine();
PrintArray(myArray);