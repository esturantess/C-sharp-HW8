// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] ArrangeRowItemsInDescendingOrder(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                if (matr[i, j] > matr[i, k])
                {
                    temp = matr[i, k];
                    matr[i, k] = matr[i, j];
                    matr[i, j] = temp;
                }
            }
        }
    }
    return matr;
}

Random rand = new Random();
int m = rand.Next(2, 10);
int n = rand.Next(2, 10);

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine();
ArrangeRowItemsInDescendingOrder(matrix);
PrintMatrix(matrix);