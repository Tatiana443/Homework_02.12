Console.WriteLine("Введите позицию строки элемента массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца элемента массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int rows = m;
int colums = n;
int[,] numbers = new int[5, 10];
FillMatrix(numbers);
PrintMatrix(numbers);

if (rows < 0 | colums < 0) Console.WriteLine("Вы ввели отрицательное число, попробуйте еще раз");
if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1))
    Console.WriteLine($"Значение этого элемента -> {numbers[rows, colums]}");
else Console.WriteLine($"[{rows},{colums}] -> такого числа в массиве нет");
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             if (j < n - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
        }
}










