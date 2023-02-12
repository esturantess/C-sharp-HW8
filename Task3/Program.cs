// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:

// 18 20
// 15 18

// !!! Матрицы A и B могут быть перемножены, если они совместимы в том смысле, что число столбцов матрицы A равно числу строк матрицы B.

// !!! Элемент xij на пересечении строки i и столбца j результирующей матрицы является
// скалярным произведением i-й строки первой матрицы и j-го столбца второй матрицы.

// Например, для матриц выше считаем x11 (элемент в первой строке, первом столбце результирующей матрицы) так:
// x11 = скалярное произведение (2, 4) * (3, 3) = 2 * 3 + 4 * 3 = 6 + 12 = 18.

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
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int[] ArrayRowRetrieving(int[,] matr, int rowIndex)
{
    int[] array = new int[matr.GetLength(1)];
    int i = rowIndex;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        array[j] = matr[i, j];
    }
    return array;
}

int[] ArrayColumnRetrieving(int[,] matr, int colIndex)
{
    int[] array = new int[matr.GetLength(0)];
    int j = colIndex;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        array[i] = matr[i, j];
    }
    return array;
}

int ScalarProduct(int[,] matr, int[,] matr1, int rowNumber, int columnNumber)
{
    int scalarProduct = 0;
    int[] arrayRow = ArrayRowRetrieving(matr, rowNumber);
    int[] arrayColumn = ArrayColumnRetrieving(matr1, columnNumber);
    for (int j = 0; j < arrayRow.Length; j++)
    {
        scalarProduct = arrayRow[j] * arrayColumn[j] + scalarProduct;
    }
    return scalarProduct;
}

int[,] ProductOfTwoMatrices(int[,] matr, int[,] matr1)
{
    int[,] product = new int[matr.GetLength(0), matr1.GetLength(1)];
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            product[i, j] = ScalarProduct(matr, matr1, i, j);
        }

    }
    Console.WriteLine();
    return product;
}

Random rand = new Random();
int m = rand.Next(2, 4);
int n = rand.Next(2, 4);
int[,] firstMatrix = FillMatrix(m, n);
Console.WriteLine("Матрица 1: ");
Console.WriteLine();
PrintMatrix(firstMatrix);
Console.WriteLine();
int m1 = rand.Next(2, 4);
int n1 = rand.Next(2, 4);
int[,] secondMatrix = FillMatrix(m1, n1);
Console.WriteLine("Матрица 2: ");
Console.WriteLine();
PrintMatrix(secondMatrix);

if (n == m1)
{
    int[,] matrixProduct = ProductOfTwoMatrices(firstMatrix, secondMatrix);
    Console.WriteLine("Произведение матриц: ");
    System.Console.WriteLine();
    PrintMatrix(matrixProduct);
}
else
{
    Console.WriteLine();
    Console.WriteLine("Невозможно найти произведение заданных матриц, так как число столбцов первой матрицы не равно числу строк второй.");
}
