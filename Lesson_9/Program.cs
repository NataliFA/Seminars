// Задача 1. Пользователь пишет число N. Вывести числа от 1 до N.
/*
void ShowNumber(int n)
{
    if (n >= 1)
    {
        ShowNumber(n - 1);
        Console.Write(n + " ");
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNumber(num);
*/

// Задача 2. Пользователь пишет числа N и M. Вывести числа от N до M. Считаем, что N < M.
/*
void ShowNumber(int n, int m)
{
    if (n <= m)
    {
        ShowNumber(n, m - 1);
        Console.Write(m + " ");
    }
}
Console.Write("Input n: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Input m: ");
int M = Convert.ToInt32(Console.ReadLine());

ShowNumber(num, M);
*/

// Задача 3. Возвести А в степень B.
/*
int ExponentialNum(int a, int b)
{
    if (b > 0)
    {
        a *= ExponentialNum(a, b - 1);
    }
    return a;
}

Console.Write("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write(ExponentialNum(A, B));
*/
