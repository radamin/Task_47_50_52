// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет


Console.Write("Enter the number of rows in the array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns in the array: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixInt(int rows, int columns, int min, int max)
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

void PrintMatrixInt(int[,] matrix)
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

int CheckInt(int[,] matrix, int m, int n)
{
  int e = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == m - 1 && j == n - 1) e = matrix[i, j];
    }
  }
  return e;
}



int[,] array2D = CreateMatrixInt(3, 4, 1, 10);
PrintMatrixInt(array2D);
Console.WriteLine();

if (CheckInt(array2D, m, n) > 0)
{
  Console.WriteLine($"The value of the selected item: " + CheckInt(array2D, m, n));
}
else Console.WriteLine("The number is missing from the array");
