// ===================================================================
// #60 Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// ===================================================================

//создаём рандомный трёхмерный массив двухзначных чисел
int[,,] Fill3DArray(int countRow, int countColumn, int countDepth)
{
    Random rnd = new Random();
    int[,,] matr = new int[countRow, countColumn, countDepth];
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int k = 0; k < matr.GetLength(2); k++)
                {
                    matr[i, j, k] = rnd.Next(10, 99);
                }
                
            }
        }
    return matr;
}

//печатаем трёхмерный  массив
void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        
    }
}

//программа создаёт и выводит на экран трёхмерный массив
Print3DArray(Fill3DArray(2,2,2));
