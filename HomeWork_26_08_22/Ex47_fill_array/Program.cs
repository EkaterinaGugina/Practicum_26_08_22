//Ex47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 2, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().NextDouble() * 20 - 10;;    
            Console.Write($"{Math.Round(matr[i, j], 1)}\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Console.Write("Введите размер матрицы. Укажите количество строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("  и столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
FillArray(matrix);
