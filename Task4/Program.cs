// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] CreateArrayOfRandomNonRepeatingTwoDigitNumbers()
{
    int size = 90;
    int[] array = new int[size];
    array[0] = 10;
    for (int i = 1; i < size; i++)
    {
        array[i] = array[i - 1] + 1;
    }
    int temp = 0;
    int randomIndex = 0;
    Random rand = new Random();
    for (int j = 0; j < size; j++)
    {
        randomIndex = rand.Next(0, size - 1);
        temp = array[randomIndex];
        array[randomIndex] = array[j];
        array[j] = temp;
    }
    return array;
}

int[,,] FillArray(int[,,] array)
{
    int[] nonRepeatingTwoDigitNumbers = CreateArrayOfRandomNonRepeatingTwoDigitNumbers();
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = nonRepeatingTwoDigitNumbers[index];
                index++;
            }
        }
    }
    return array;
}

void PrintArrayWithCoords(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

Random rand = new Random();
int x = rand.Next(2, 4);
int y = rand.Next(2, 4);
int z = rand.Next(2, 4);
int[,,] array = new int[x, y, z];
FillArray(array);
PrintArrayWithCoords(array);

