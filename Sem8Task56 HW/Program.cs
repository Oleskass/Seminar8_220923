// ===============================================================
// #56 Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой 
// элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка
// ===============================================================

int FindMinRow(int[,] arr)
{
    int indexRow = -1;
    int minNum = int.MaxValue;
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (minNum > sum)
        {
            minNum = sum;
            indexRow = i + 1; //+1 чтобы видеть не индекс строки, а порядковый номер строки
        }
        //Console.WriteLine($"{minNum}"); //можно посмотреть сумму в строках
    }
    return indexRow;
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

//печать результата
void PrintResult(string prefix, int data)
{
    Console.WriteLine(prefix + data);
}

int[,] matrix = Fill2DArray(5, 6, 0, 9);
Console.WriteLine("Созданная матрица: ");
Print2DArray(matrix);
PrintResult("Первая попавшаяся строка с наименьшей суммой элементов: ", FindMinRow(matrix));

