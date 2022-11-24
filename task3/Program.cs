int[,] CreateNewRandomArray(int rowCount, int columnCount)
{
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
    Console.WriteLine();
}

void GetMatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int[,] resultArray = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum = sum + matrix1[i, k] * matrix2[k, j];
                }
                resultArray[i, j] = sum;
            }
        }
        PrintArray(resultArray);
    }
    else
    {
        Console.WriteLine("Умножение не может быть произведено. Количество столбцов первой матрицы не совпадает с количеством строк второй матрицы!!!");
    }

}


Console.Clear();
Console.WriteLine("Матрица 1:");
Console.WriteLine("Введите количество строк матрицы:");
int matrix1Rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы:");
int matrix1Columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Матрица 2:");
Console.WriteLine("Введите количество строк матрицы:");
int matrix2Rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы:");
int matrix2Columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = CreateNewRandomArray(matrix1Rows, matrix1Columns);
int[,] matrix2 = CreateNewRandomArray(matrix2Rows, matrix2Columns);
PrintArray(matrix1);
PrintArray(matrix2);
GetMatrixMultiplication(matrix1, matrix2);
