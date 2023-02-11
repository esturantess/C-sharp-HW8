// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(-10, 11);
        }
    }

    return matr;
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

int firstRowElementsSum(int[,] matr)
{
    int sum = 0;
    int i = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum = sum + matr[i, j];
    }
    return sum;
}

void FindRowWithMinimumSumOfItems(int[,] matr)
{
    int sum = 0;
    int minSumRow = 0;
    int minSum = firstRowElementsSum(matr);
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }
        System.Console.WriteLine(sum);
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumRow + 1}.");
}

Random rand = new Random();
int m = rand.Next(2, 10);
int n = rand.Next(2, 10);
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine();
FindRowWithMinimumSumOfItems(matrix);