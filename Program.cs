// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// */

// Console.WriteLine("Please input m and n");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] Array = new double[m, n];

// void PrintArray(double[,] Matrix)
// {
//     for (int i = 0; i < Matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < Matrix.GetLength(1); j++)
//         {
//             Console.Write($"{Matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int m, int n)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             double x = rnd.NextDouble() * 100;
//             Array[i, j] = Math.Round(x, 1);
//         }
//     }
// }

// try
// {
//     FillArray(m, n);
//     PrintArray(Array);
//     Console.WriteLine();
// }
// catch
// {
//     Console.WriteLine("Please use integers only");
// }

/*****************************************************************************************************************
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
 или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

try
{
Console.WriteLine("Please input m and n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input x");
int x = Convert.ToInt32(Console.ReadLine()); ;
int[,] Array = new int[m, n];
Console.WriteLine();

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] Array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Array[i, j] = new Random().Next(1, 10);
        }
    }
}

int CheckArray(int[,] Array)
{
    int Element = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] == x)
            {
                Element = x;
            }
        }
    }
    if (Element == 0) Console.WriteLine($"{x} ->  this integer is absent");
    else Console.WriteLine(Element);
    return Element;
}

FillArray(Array);
PrintArray(Array);
CheckArray(Array);
Console.WriteLine();

}
catch
{
    Console.WriteLine("Pease input correctly");
}
*/
// *********************************************************************************************************************

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Array = new int[,]
// {
//  {1, 4, 7, 2},
//  {5, 9, 2, 3},
//  {8, 4, 2, 4}
// };

// double[] ArrResault = new double[4];

// void ArithmeticMeanColumn(int[,] Array)
// {
//     double Res = 0;
//     Console.WriteLine("Срееднее арифметическое кадого столбца: ");
//     for (int j = 0; j < Array.GetLength(1); j++)
//     {
//         for (int i = 0; i < Array.GetLength(0); i++)
//         {

//             Res = Res + Array[i, j];

//         }
//         Res = Res / 3;
//         Res = Math.Round(Res, 1);
//         ArrResault[j] = Res;
//         Res = 0;
//     }
// }

// void PrintArrResult()
// {
//     for (int i = 0; i < ArrResault.Length - 1; i++)
//     {
//         Console.Write($"{ArrResault[i]},  ");
//     }
//     Console.Write($"{ArrResault[ArrResault.Length - 1]}.");
// }

// ArithmeticMeanColumn(Array);
// PrintArrResult();
// Console.WriteLine();

// /*********************************************************************************************************************
// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

try
{
    Console.WriteLine("Please input m and n");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,] Array = new int[m, n];
    int[] ArrayOneLine = new int[m * n];

    void PrintArray()
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Console.Write(Array[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    void FillArray()
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Array[i, j] = new Random().Next(1, 10);
            }
        }

    }

    void FillOneLineArray()
    {
        int k = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                ArrayOneLine[k] = Array[i, j];
                k += 1;
            }
        }
    }

    void BubbleSort(int[] Array)
    {
        for (int i = 0; i < ArrayOneLine.Length; i++)
        {
            for (int j = 0; j < ArrayOneLine.Length - 1; j++)
            {
                if (ArrayOneLine[j] > ArrayOneLine[j + 1])
                {
                    int temp = ArrayOneLine[j];
                    ArrayOneLine[j] = ArrayOneLine[j + 1];
                    ArrayOneLine[j + 1] = temp;
                }
            }
        }
    }

    void FillSortArray(int[,] Array)
    {
        int k = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Array[i, j] = ArrayOneLine[k];
                k++;
            }
        }
    }

    FillArray();
    PrintArray();
    FillOneLineArray();
    BubbleSort(ArrayOneLine);
    FillSortArray(Array);
    PrintArray();
}
catch
{
    Console.WriteLine("Please input correctly");
}

