// Ex52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void MediumColumn(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
        {
            double average = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                average = average + matr[i, j];   
            }
        }
        Console.Write($" {average / matr.GetLength(0)} ");
}

Console.Write("Введите размер матрицы. Укажите количество строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("  и столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
MediumColumn(matrix);
