// Задача 1. Кол-во элементов больше 0. Задача 41 из ДЗ 6.
/*
Console.Write("Input number of elements: ");
int kol = Convert.ToInt32(Console.ReadLine());

int count = 0;
int num;
for (int i = 0; i < kol; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) count++;
}

Console.WriteLine("Number of positive elements is " + count);
*/

// Задача 2. ДЗ 6 2 задача, перевод из 10 в 2-ую систему.
/*
int num = 46;
string boolNumber = string.Empty;

while (num > 0)
{
    boolNumber = (num % 2) + boolNumber;
    num /= 2;
}

Console.WriteLine(boolNumber);
*/

// Задача 3. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Главная диагональ с левого верхнего угла в правый нижний, у которой i = j (0,0; 1,1; 2,2 и т д). Массив должен быть квадратный. 
/*
int SumOfDiagonal(int[,] quad)
{
    int sum = 0;

    for (int i = 0; i < quad.GetLength(0); i++) sum += quad[i, i];
    return sum;
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

Console.WriteLine("Сумма элементов на главной диагонали = " + SumOfDiagonal(matrix));
*/

// Задача 4. Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
/*
Console.Write("Input amount of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input amount of cols: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = i + j;
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
*/

// Задача 5. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты. 
/*
int[,] ArrayGen(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] = matrix[i, j] * matrix[i, j];
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    return matrix;
}

Console.Write("Input amount of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input amount of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = ArrayGen(rows, cols);
*/



