/*Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.

*/
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] array = GetArray(rows, columns, 0, 15);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);



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
int[,] SortArray(int[,] result)
{
    int temp = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(1) - 1 - j; k++) //упорядочиваем элементы в строках
            {

                if (result[i, k] < result[i, k + 1])
                {
                    temp = result[i, k];
                    result[i, k] = result[i, k + 1];
                    result[i, k + 1] = temp;
                }
            }
        }
    }
    return result;
}