//Ex47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Math.Round(new Random().Next(-10,10), 1);    
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер матрицы. Укажите количество строк m = ");
int m = Convert.ToInt32(Console.Read());
Console.Write("  и столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, m];
FillArray(matrix);

