// Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int[,] Create2DArray(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            matrix[i, j] = new Random().Next(0, 10);
    return matrix;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangeLastToFirstRows(int[,] nmatrix)
{
    int temp;
    for (int j = 0; j < nmatrix.GetLength(1); j++)
    {
        temp = nmatrix[0, j];
        nmatrix[0, j] = nmatrix[nmatrix.GetLength(0) - 1, j];
        nmatrix[nmatrix.GetLength(0) - 1, j] = temp;
    }
    return nmatrix;
}

Console.Write("Input amount of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input amount of cols: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(m, n);

ShowArray(myArray);
ShowArray(ChangeLastToFirstRows(myArray));
*/

// Задача 2.Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] ChangeColsRows(int[,] arr)
{
    int temp;
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
    return arr;
}

int[,] Create2DArray(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            matrix[i, j] = new Random().Next(0, 10);
    return matrix;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите одинаковое количество строк и столбцов");

Console.Write("Строки - ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Столбцы - ");
int n = Convert.ToInt32(Console.ReadLine());

if (m != n) Console.Write("Поменять строки на столбцы невозможно, введите одинаковое количество строк и столбцов!");
else
{
    int[,] myArray = Create2DArray(m, n);
    ShowArray(myArray);
    ShowArray(ChangeColsRows(myArray));
}