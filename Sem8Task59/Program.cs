// ===============================================================
// #59 Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.
// ===============================================================

void MinFind(int[,] arr, ref int x, ref int y)
{
    int min = arr[0, 0];
    x = 0;
    y = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                x = i;
                y = j;
            }
        }
    }
}

int[,] CreateArr(int[,] arr, int x, int y)
{
    int k = 0;
    int m = 0;
    int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == x)
        {
        }
        else
        {
            m = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j == y)
                {
                }
                else
                {
                    outArr[k, m] = arr[i, j];
                    m++;
                }
            }
            k++;
        }
    }
    return outArr;
}

//создаётся рандомный двумерный массив с заданными пользователем границами
int[,] Fill2DArray(int countRow, int countColumn, int arrMin, int arrMax)
{
    Random rnd = new Random();
    int[,] matr = new int[countRow, countColumn];
    if (arrMin < arrMax)
    {
        for (int i = 0; i < countRow; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                matr[i, j] = rnd.Next(arrMin, arrMax + 1);
            }
        }
    }
    return matr;
}

//печатаем двумерный  массив
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = Fill2DArray(4,4,0,9);
Print2DArray(array);
Console.WriteLine();
int x = -1;
int y = -1;
MinFind(array, ref x, ref y);
int[,] outArr = CreateArr(array, x, y);
Print2DArray(outArr);