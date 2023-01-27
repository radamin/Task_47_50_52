// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CreateMatrixAverageInt(int rows, int columns, int min, int max)
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
    Console.Write('[');
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
      else Console.Write($"{matrix[i, j],5}, ");
    }
    Console.WriteLine("]");
  }
}


double[] AverageInt(int[,] matrix)
{
  double[] avg = new double[matrix.GetLength(1)];
  double[] sum = new double[matrix.GetLength(1)];
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    sum[j] = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      sum[j] = matrix[i, j] + sum[j];
      if (i == matrix.GetLength(0) - 1) avg[j] = Math.Round((sum[j] / matrix.GetLength(0)), 2);
    }
  }
  return avg;
}

void PrintAverageInt(double[] avg)
{
  Console.WriteLine();
  Console.WriteLine("Arithmetic mean of all elements of each column: ");
  Console.WriteLine(String.Join("; ", avg));
}


int[,] array2D = CreateMatrixAverageInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

double[] avg = AverageInt(array2D);
PrintAverageInt(avg);

