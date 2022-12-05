Console.WriteLine("Задайте количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] FillMatrix2D(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}
Console.WriteLine("---------------------------");
int[,] matrix = FillMatrix2D(rows, columns, 1, 10);
PrintMatrix(matrix);
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        sum += matrix[i, j];
    }
    Console.WriteLine("------------------------");
    Console.WriteLine($"Среднее арифметическое столбца -> {Math.Round(sum / matrix.GetLength(0), 1)}; ");
}











