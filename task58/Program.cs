// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] newArray = GetArray(2, 2, 0, 10);
int[,] newArray2 = GetArray(2, 2, 0, 10);

PrintArray(newArray);
Console.WriteLine();
PrintArray(newArray2);
Console.WriteLine();
int[,] resultArray = MatrixProduct(newArray, newArray2);
PrintArray(resultArray);


int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = new Random().Next(min, max);
        }
    }
    return resultArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixProduct(int[,] firstMatrix, int[,] secondMatrix)// метод, создающий массив-произведение двух исходных массивов
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                result[i, j] = result[i, j] + firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return result;
}