// ===============================================================
// #58 Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// ===============================================================

int[,] MatrixMultiply(int[,] matr1, int[,] matr2)
{

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

int[,] matrix1 = Fill2DArray(4, 4, 0, 9);
Print2DArray(matrix1);
int[,] matrix2 = Fill2DArray(4, 4, 0, 9);
Print2DArray(matrix2);
int[,] matrMult = MatrixMultiply(matrix1, matrix2);
Print2DArray(matrMult);
