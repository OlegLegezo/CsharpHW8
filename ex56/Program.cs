// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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
int[,] arrayResult = GetArray(m, n);
PrintArray(arrayResult);

int SumStroka(int[,] array, int i) //метод суммы в строке
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)//0-строки
    {
        sum = array[i, j] + sum;
    }
    return sum;
}

Console.WriteLine();

//применяю метод внутри цикла for
int temp = SumStroka(arrayResult, 0);
int answer = 0;
for (int i = 0; i < arrayResult.GetLength(0); i++)
{
    int Result2 = SumStroka(arrayResult, i);
    Console.WriteLine($"сумма элементов строки {i}: {Result2}");
    if (Result2 < temp)
    {
        temp = Result2;
        answer = i;
    }
    if (i == arrayResult.GetLength(0) - 1)
    {
        // Console.WriteLine(temp);
        // Console.WriteLine();
        Console.WriteLine($"наименьшая сумма элементов в строке: {answer}");
    }

}

