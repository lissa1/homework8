// Заполните спирально массив 4 на 4
int m = InputInt("введите число строк ");
int n = InputInt("введите число столбцов ");
int[,] numbers = new int[m, n];
FillSpiralArray(numbers);

void FillSpiralArray(int[,] array)
{
    int p = 1, i = 0, j = 0;
    while (p <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = p;
        p++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    PrintArray(numbers);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
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

