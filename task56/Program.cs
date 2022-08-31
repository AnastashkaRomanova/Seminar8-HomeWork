// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = GetArray(5, 7, 0, 15);

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {FindSummRows(array)} ");


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

int FindSummRows(int[,] result)
{
    int sum = 0;
    int temp = 0;
    int line = 0;

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {

            sum = sum + result[i, j];


        }
        Console.WriteLine($"Сумма чисел в строке {i + 1} = {sum}");
        if (sum <= temp || temp == 0)
        {
            temp = sum;
            sum = 0;
            line = i + 1;
        }

    }
    return line;


}

