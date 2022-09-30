// ===============================================================
// #54 Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// ===============================================================

//сортировка элементов строк двумерного массива
int[,] SortedArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        List<int> row = new List<int>(); //создаём список объектов int
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            row.Add(arr[i, j]);
            row.Sort();
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = row[j];
        }
    }
    return arr;
}

//разворачиваем сортировку массива, чтобы было по убыванию
int[,] OrderDescend(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1)/2; j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[i, arr.GetLength(1)-1-j];
            arr[i, arr.GetLength(1)-1-j] = temp;
        }
    }
    return arr;
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

int[,] matrix = Fill2DArray(5, 5, 0, 9);
Console.WriteLine("Созданная матрица: ");
Print2DArray(matrix);
Console.WriteLine("Отсортированная матрица по возрастанию (по умолчанию): ");
int[,] matrixSorted = SortedArr(matrix);
Print2DArray(matrixSorted);
Console.WriteLine("Отсортированная матрица ПО УБЫВАНИЮ: ");
Print2DArray((OrderDescend(SortedArr(matrix))));
