Console.WriteLine("Задайте количество строк двумерного массива: m= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива: n= ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] CreateMatrixRndDouble(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = (int)(rnd.NextDouble() * (max - min) + min);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write("|");
        for (int j = 0; j < n; j++)
        {
            if (j < n - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}
int[,] matrix = CreateMatrixRndDouble(3, 4, -100, 100);
PrintMatrix(matrix);

