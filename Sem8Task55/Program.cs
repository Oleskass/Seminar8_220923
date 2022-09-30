// ===============================================================
// #55 Задайте двумерный массив. Напишите программу, которая 
// заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.
// ===============================================================

//чтение данных пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
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

bool TestTransp(int[,] arr)
{
    return arr.GetLength(0) == arr.GetLength(1);
}

int[,] TranspArray(int[,] matr)
{
    int temp = 0;
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = i + 1; j < matr.GetLength(1); j++) //i+1 так как иначе будем снова менять то, что уже поменяли. А нам нужно сдвигаться правее, значения, стоящие на главной диагонали не трогаем как раз
            {
                temp = matr[i, j];
                matr[i, j] = matr[j, i];
                matr[j, i] = temp;
            }
        }
        return matr;
    }
}

// //  Ещё вариант решения, здесь меняем строки со столбцами
// int[,] TranspArrayNewAr(int[,] matr)
// {
//     int[,] matrix = new int[matr.GetLength(1), matr.GetLength(0)];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matrix[j, i] = matr[i, j];
//         }
//     }
//     return matrix;
// }

int[,] matrix = Fill2DArray(ReadData("Сколько строк? "), ReadData("Сколько столбцов? "), 0, 9);
Print2DArray(matrix);
Console.WriteLine();

if (TestTransp(matrix))
{
    TranspArray(matrix);
    Print2DArray(matrix);
}
else
{
    Console.WriteLine("Данную матрицу транспонировать некорректно");
}