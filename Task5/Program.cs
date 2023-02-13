// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[] FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 51);
    }
    return array;
}

int[,] SpiralFillingOfTheMatrix(int[,] matrix, int[] array)
{
    int rows = matrix.GetLength(0) - 1;
    int columns = matrix.GetLength(1) - 1;
    int index = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int i = 0;
        matrix[i, j] = array[index];
        index++;
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int j = columns;
        matrix[i, j] = array[index];
        index++;
    }
    for (int j = columns - 1; j >= 0; j--)
    {
        int i = rows;
        matrix[i, j] = array[index];
        index++;
    }
    for (int i = rows - 1; i >= 1; i--)
    {
        int j = 0;
        matrix[i, j] = array[index];
        index++;
    }
    for (int j = 1; j <= columns - 1; j++)
    {
        int i = 1;
        matrix[i, j] = array[index];
        index++;
    }
    rows = 2;
    columns--;
    matrix[rows, columns] = array[index];
    index++;
    columns--;
    matrix[rows, columns] = array[index];
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

Random rand = new Random();
int m = 4;
int n = 4;
int[,] matrix = new int[m, n];

int[] array = new int[m * n];
FillArray(array);
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// System.Console.WriteLine();
SpiralFillingOfTheMatrix(matrix, array);
PrintMatrix(SpiralFillingOfTheMatrix(matrix, array));



