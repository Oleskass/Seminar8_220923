// ===============================================================
// #57 Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных.
// ===============================================================

int[] FreqDicLoad(int[,] arr)
{
    int[] dic = new int[10]; //от 0 до 9 //создаём частотный словарь
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            dic[arr[i,j]]++; //увеличиваем ту позицию в массиве dic которую встречаем в arr //заполняем частотный словарь
        }
    }
    return dic;
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
//печатаем одномерный массив
void Print1DArray(int[] array)
{
    Console.Write("0=" + array[0] + "шт, ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write(i + "=" + array[i] + "шт, ");
    }
    Console.WriteLine(array.Length-1 + "=" + array[array.Length - 1] + "шт.");
}

int[,] matrix = Fill2DArray(7, 8, 0, 9);
Print2DArray(matrix);
int[] array = FreqDicLoad(matrix);
Print1DArray(array);


// //вариант Анатолия - разобрать ещё
// // Генерация случайного 2D массива.
// int[,] Gen2DArr(int rows, int columns, int arrMin, int arrMax)
// {
//     int[,] arr = new int[rows, columns];
//     Random rnd = new Random();
//     if (arrMin > arrMax)
//     {
//         int temp = arrMax;
//         arrMax = arrMin;
//         arrMin = temp;
//     }
//     int range = arrMax - arrMin;

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             arr[i, j] = rnd.Next(arrMin, arrMax);
//         }
//     }
//     return arr;
// }

// Dictionary<int, int> FreqDict(Dictionary<int, int> countValues, int[,] arr)
// {
//     foreach (int item in arr)
//     {
//         if (countValues.ContainsKey(item))
//         {
//             countValues[item]++;
//         }
//         else
//         {
//             countValues.Add(item, 1);
//         }
//     }
//     return countValues;
// }

// // Печать словаря.
// void PrintDict(Dictionary<int, int> countValues)
// {
//     foreach (var item in countValues)
//     {
//         Console.WriteLine(item);
//     }
// }

// // Печать двумерного массива
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int[,] arr = Gen2DArr(10, 10, 0, 10);
// Dictionary<int, int> countValues = new Dictionary<int, int>();
// Print2DArray(arr);
// FreqDict(countValues, arr);
// PrintDict(countValues);