// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
int m = InputInt("введите число строк в матрицах ");
int n = InputInt("введите число столбцов в матрицах ");
int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[m,n];
int[,] resultMatrix = new int[m, n];

FillandPrintArray(firstMatrix);
Console.WriteLine();
FillandPrintArray(secondMatrix);
Console.WriteLine();
SumArrays(firstMatrix, secondMatrix, resultMatrix);

void SumArrays(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultMatrix[i,j] = firstArray[i,j] * secondArray[i,j]; 
        }
    }
    PrintArray(resultArray);
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