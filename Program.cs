// Задача 54: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
//Console.WriteLine("input the number of rows");
//int rows = Convert.ToInt32(Console.ReadLine ());
//Console.WriteLine("Input the number of columns");
//int columns = Convert.ToInt32( Console.ReadLine ());
//Console.WriteLine("Input the minValue");
//int minValue = Convert.ToInt32(Console.ReadLine ());
//Console.WriteLine("Input the maxValue");
//int maxValue = Convert.ToInt32(Console.ReadLine ());
//int[,] array = new int[rows, columns];
//CreateArray(array);
//ShowArray(array);
//Console.WriteLine($"The array we are looking for: ");
//OrderArrayLines(array);

//void OrderArrayLines(int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      for (int k = 0; k < array.GetLength(1) - 1; k++)
//      {
//        if (array[i, k] < array[i, k + 1])
//        {
//          int temp = array[i, k + 1];
//          array[i, k + 1] = array[i, k];
//          array[i, k] = temp;
//        }
//      }
//    }
//  }
//}
//void CreateArray(int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      array[i, j] = new Random().Next(minValue, maxValue);
//    }
//  }
//}

//void ShowArray(int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//  }
//}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Console.WriteLine("input the number of rows");
//int rows = Convert.ToInt32(Console.ReadLine ());
//Console.WriteLine("Input the number of columns");
//int columns = Convert.ToInt32( Console.ReadLine ());
//Console.WriteLine("Input the minValue");
//int minValue = Convert.ToInt32(Console.ReadLine ());
//Console.WriteLine("Input the maxValue");
//int maxValue = Convert.ToInt32(Console.ReadLine ());
//int[,] array = GetArray(rows, columns, minValue, maxValue);
//int[,] array = new int[rows, columns];
//PrintArray(array);
//Console.WriteLine($"Our row is - {GetRowNumber(array)}");

//int[,] GetArray(int m, int n, int min, int max)
//  {
//    int[,] result = new int[m, n];
//    for (int i = 0; i < m; i++)
//    {
//      for (int j = 0; j < n; j++)
//        {
//          result[i, j] = new Random().Next(min, max +1);
//        }
//    }
//    return result;
//}
//void PrintArray(int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//      {
//      Console.Write($"{array[i, j]} ");
//      }
//      Console.WriteLine();
//      }
//  }
//int GetRowNumber (int [,] array)
//{
//int row = 0;
//int minsum = 0;
//  for (int i = 0; i < array.GetLength(1); i++)
//    {
//    minsum = minsum + array[0,i];
//    }
//      for (int i = 1; i < array.GetLength(0); i++)
//      {
//      int sum = 0;
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//        sum = sum + array[i,j];
//        }
//        if (minsum > sum)
//        {
//          minsum = sum;
//          row = i;
//        }
//      }
//return row;
//}  
//
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//int n = 4;
//int[,] MyMatrix = new int[n, n];
//int temp = 1;
//int i = 0;
//int j = 0;
//while (temp <= MyMatrix.GetLength(0) * MyMatrix.GetLength(1))
//{
//  MyMatrix[i, j] = temp;
//  temp++;
//  if (i <= j + 1 && i + j < MyMatrix.GetLength(1) - 1)
//    j++;
//  else if (i < j && i + j >= MyMatrix.GetLength(0) - 1)
//    i++;
//  else if (i >= j && i + j > MyMatrix.GetLength(1) - 1)
//    j--;
//  else
//    i--;
//}

//ShowArray(MyMatrix);

//void ShowArray (int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      if (array[i,j] / 10 <= 0)
//      Console.Write($" {array[i,j]} ");
//      else Console.Write($"{array[i,j]} ");
//    }
//    Console.WriteLine();
//  }
//}


                  
