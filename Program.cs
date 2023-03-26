// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] SortRowsInArrayByDescending(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = array.GetLength(1); k > 0; k--)
//         {
//             for (int j = 1; j < k; j++)
//             {
//                 if (array[i, j - 1] < array[i, j])
//                 {
//                     int temp = array[i, j - 1];
//                     array[i, j - 1] = array[i, j];
//                     array[i, j] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(array);
// Console.WriteLine();
// Show2DArray(SortRowsInArrayByDescending(array));




//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int FindMinimalSummRow(int[,] array)
// {
//   int[] SummOfElementsInRow = new int[array.GetLength(0)];

//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       SummOfElementsInRow[i] += array[i, j];
//     }
//   }

//   Console.WriteLine(SummOfElementsInRow);

//   int minSummRow = 0;

//   for (int i = 1; i < SummOfElementsInRow.Length; i++)
//   {
//     if (SummOfElementsInRow[i] < SummOfElementsInRow[minSummRow])
//     {
//       minSummRow = i;
//     }
//   }
//   return minSummRow;
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(array);
// Console.WriteLine();

// Console.WriteLine($"Index of the row with minimal summ of elements: {FindMinimalSummRow(array)}");


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] CreateSpiralMatrix(int size)
// {
//   int[,] matrix = new int[size, size];

//   if (size == 1)
//   {
//     matrix[0, 0] = 1;
//   }
//   else
//   {
//     for (int i = 1; i <= size; i++)
//     {
//       for (int j = 1; j <= size; j++)
//       {
//         int switcher = (j - i + size) / size;
//         int iCenter = Math.Abs(i - Convert.ToInt32(size / 2) - 1) + (i - 1) / Convert.ToInt32(size / 2) * ((size - 1) % 2);
//         int jCenter = Math.Abs(j - Convert.ToInt32(size / 2) - 1) + (j - 1) / Convert.ToInt32(size / 2) * ((size - 1) % 2);
//         int ring = size / 2 - (Math.Abs(iCenter - jCenter) + iCenter + jCenter) / 2;
//         int xs = i - ring + j - ring - 1;
//         int coef = 4 * ring * (size - ring);
//         matrix[i - 1, j - 1] = coef + switcher * xs + Math.Abs(switcher - 1) * (4 * (size - 2 * ring) - 2 - xs);
//       }
//     }
//   }

//   return matrix;
// }

// string NumToString(int num, int size)
// {
//   int power = (Math.Pow(size, 2)).ToString().Length;
//   int numPower = num.ToString().Length;
//   return $"{(power > numPower ? new string(Convert.ToChar("0"), power - numPower) : "")}{num}  ";
// }

// void PrintSpiralMatrix(int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       Console.Write(NumToString(matr[i, j], matr.GetLength(0)));
//     }
//     Console.WriteLine();
//   }
// }

// Console.Write("Input number of rows and columns: ");
// int size = Convert.ToInt32(Console.ReadLine());
// PrintSpiralMatrix(CreateSpiralMatrix(size));