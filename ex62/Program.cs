// Задача 62: Заполните спирально массив 4 на 4.
int[,] pic = new int[,]
{
{0, 0, 0, 0},
{0, 0, 0, 0},
{0, 0, 0, 0},
{0, 0, 0, 0},
};

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

//Console.Write("введите кол-во строк: ");
//int m = 4;//int.Parse(Console.ReadLine());
//Console.Write("введите кол-во столбцов: ");
//int n = 4;//int.Parse(Console.ReadLine());




//метод заполнения
void FillImage(int row, int col, int startValue)
{
    if (col < 4 & row < 4 & col >= 0 & row >= 0)
    {
        if (pic[row, col] == 0)
        {
            pic[row, col] = startValue;
            startValue = startValue + 1;
            //Console.WriteLine(col);
            FillImage(row, col + 1, startValue);
            FillImage(row + 1, col, startValue);
            FillImage(row, col - 1, startValue);
            FillImage(row - 1, col, startValue);
        }
    }

}
//метод заполнения




FillImage(0, 0, 1);
Console.WriteLine("массив спиральный:");
PrintArray(pic);