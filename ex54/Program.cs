// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] GetArray(int a, int b) //метод заполнения массива целыми числами
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)//0-строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//1-столбцы
        {
            array[i, j] = rnd.Next(0, 10); //или array[i, j]=rnd.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array) //метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)//0-строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//1-столбцы
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = GetArray(4, 4);
PrintArray(arrayResult);

int[,] ArrayFromMaxToMin(int[,] array) //метод убывания строки массива
{
    for (int i = 0; i < array.GetLength(0); i++)//0-строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//1-столбцы
        {
            int temp = array[i, 0];
            for (int x = 1; x < array.GetLength(1); x++)
            {
                if (array[i, x] > temp)
                {
                    array[i, x - 1] = array[i, x];
                    array[i, x] = temp;
                }
                else
                {
                    temp = array[i, x];
                }
            }
        }
    }
    return array;
}

Console.WriteLine();
int[,] arrayResult2 = ArrayFromMaxToMin(arrayResult);
PrintArray(arrayResult2);