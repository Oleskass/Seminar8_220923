// ===============================================================
// #53 Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.
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

//заполняем массив случайными числами
void Fill2DArray(int[,] matr, int arrMin, int arrMax)
{
    if (arrMin < arrMax)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(arrMin, arrMax + 1);
            }
        }
    }
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
    Console.WriteLine();
}

int[,] Change2DArray(int[,] matr)
{
    int temp = 0;
    for (int j = 0; j < matr.GetLength(1); j++) //пробегаемся по каждому эл-ту в одной строке
    {
        temp = matr[0,j]; //временная (буферная) переменная - строка с индексом 0
        matr[0,j] = matr[matr.GetLength(0) - 1, j]; //в строку с индексом 0 записываем данные с последней строки
        matr[matr.GetLength(0) - 1, j] = temp; //в последнюю строку записываем данные из буферной пременной
    }
    return matr;
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] matrix = new int[m, n];


Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);

Change2DArray(matrix);
Print2DArray(matrix);