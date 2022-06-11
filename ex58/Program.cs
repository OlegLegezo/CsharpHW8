// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

Console.Write("введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] arrayResult1 = GetArray(m, n);
Console.WriteLine("массив №1:");
PrintArray(arrayResult1);
Console.WriteLine();
int[,] arrayResult2 = GetArray(m, n);
Console.WriteLine("массив №2:");
PrintArray(arrayResult2);

int[,] ArrayMul(int[,] array1, int[,] array2, int a, int b) //метод перемножения двух массивов
{
    int[,] array3 = new int[a, b];
    for (int i = 0; i < array1.GetLength(0); i++)//0-строки
    {
        for (int j = 0; j < array1.GetLength(1); j++)//1-столбцы
        {
            array3[i, j] = array1[i, j] * array2[i, j]; //или array[i, j]=rnd.Next(10);
        }
    }
    return array3;
}

int[,] arrayResult3 = ArrayMul(arrayResult1, arrayResult2, m, n);
Console.WriteLine();
Console.WriteLine("массив №1х№2:");
PrintArray(arrayResult3);