// Ex52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//  1 4 7 2
//  5 9 2 3
//  Среднее арифметическое каждого столбца: 3; 6,5; 4,5; 2,5.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-10, 11);    
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void AverageColumn(int[,] matr)    //считает среднее арифметическое столбцов
{
    for (int j = 0; j < matr.GetLength(1); j++)
        {
            double medium = 0.0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                medium += matr[i, j];   
            }
            Console.Write($" {medium / matr.GetLength(0)} ");
        }
}
Console.Write("Введите размер матрицы. Укажите количество строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("  и столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
AverageColumn(matrix);
