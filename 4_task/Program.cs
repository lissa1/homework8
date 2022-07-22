// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int m = InputInt("введите число строк ");
int n = InputInt("введите число столбцов ");
int p = InputInt("ввeдите число ");
int[,,] numbers = new int[m, n, p];
FillandPrintArray(numbers);

void FillandPrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 20);
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}