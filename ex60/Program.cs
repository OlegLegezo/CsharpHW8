// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int[,,] array = new int[,,] { { { 11, 12, 13 }, { 14, 15, 16 } },{ { 17, 18, 19 }, { 20, 21, 22 } } };

void ArrayIndex3D(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($"{array[x, y, z]} - элемент с индексами X={x},Y={y},Z={z}");
            }
        }
    }
}
ArrayIndex3D(array);