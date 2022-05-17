// Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int[,] ChangeMassive(int[,] nmatrix)
{
    int temp;
    for (int j = 0; j < nmatrix.GetLength(1); j++)
    {
        temp = nmatrix[0, j];
        nmatrix[0, j] = nmatrix[nmatrix.GetLength(0) - 1, j];
        nmatrix[nmatrix.GetLength(0) - 1, j] = temp;
    }
    return nmatrix;
    Console.WriteLine();
}

Console.Write("Input amount of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input amount of cols: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(ChangeMassive(matrix));
*/

// Задача 2.Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] ChangeColsRows(int[,] arr)
{
    int temp;
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < arr.GetLength(1) - 1; j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
            Console.Write( + " ");
        }
        Console.WriteLine();
    }
    return arr;
}

Console.Write("Input size of matrix: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write(ChangeColsRows(matrix));

