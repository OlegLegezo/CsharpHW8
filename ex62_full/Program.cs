// Задача 62: Заполните спирально массив 4 на 4.
// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.


//метод заполнения спирально
int[,] ArrSpiral(int row, int col, int startValue)
{
    int[,] array = new int[row, col];
    int startrow = 0;
    int startcol = 0;
    int rowcount = array.GetLength(0);//строки
    int colcount = array.GetLength(1);//столбцы

    // while (startrow < array.GetLength(0) & startcol < array.GetLength(1))
    while (startrow < rowcount&startcol < colcount)
    {


        for (col = startrow; col < colcount - 1; col++)
        {
            array[startrow, col] = startValue;
            startValue++;
        }
        startrow++;


        //Console.WriteLine(rowcount);

        for (row = startcol; row < rowcount - 1; row++)
        {
            array[row, colcount - 1] = startValue;
            startValue++;
        }
        startcol++;

        for (col = colcount - 1; col >= startcol-1; col--)
        {
            array[rowcount - 1, col] = startValue;
            startValue++;
        }
        rowcount--;


        for (row = rowcount - 1; row >= startrow; row--)
        {
            array[row, startcol - 1] = startValue;
            startValue++;
        }
        colcount--;

        // Console.WriteLine();
        // Console.WriteLine(startrow);
        // Console.WriteLine(startcol);
        // Console.WriteLine(rowcount);
        // Console.WriteLine(colcount);
    }
    return array;
}
//метод заполнения спирально



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
Console.Write("введите стартовое значение: ");
int stratvalue = int.Parse(Console.ReadLine());
int[,] arrayResult1 = ArrSpiral(m, n, stratvalue);
Console.WriteLine("массив спирально заполненный");
PrintArray(arrayResult1);
