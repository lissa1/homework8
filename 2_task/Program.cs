// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int m = InputInt("введите число строк ");
int n = InputInt("введите число столбцов ");
int[,] numbers = new int[m, n];
FillandPrintArray(numbers);
FindMinSumRowIndex(numbers);

void FindMinSumRowIndex(int[,] array)
{
    int minSumRow = 0;
    int sumRow = SumRowsNum(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumRow = SumRowsNum(array, i);
        if (sumRow > tempSumRow)
        {
            sumRow = tempSumRow;
            minSumRow = i;
        }
    }
    Console.WriteLine($"строка с наименьшей суммой элементов {minSumRow}");
}
int SumRowsNum(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
void FillandPrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
