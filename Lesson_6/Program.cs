// Задача 1. Метод принимает 3 числа  и говорит, может ли существовать треугольник с такими сторонами.
/*
bool IsTriangleExist(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        return true;

    return false;
}

Console.Write("Введите длину стороны А = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны B = ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны C = ");
int C = Convert.ToInt32(Console.ReadLine());

Console.Write("Может ли существовать треугольник с такими сторонами? - ");

if (IsTriangleExist(A, B, C)) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/

// Задача 2. Написать программу, которая принимает одномерный массив и разворачивает его в обратную сторону в новом массиве
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] NewArray(int[] array) // проходим весь массив, это неудобно и долго, если массив большой
{
    int newSize = array.Length;
    int[] newArray = new int[newSize];

    for (int i = 0, j = array.Length - 1; i < newSize; i++, j--)
    {
        newArray[i] = array[j];
    }
    return newArray;
}

int[] NewArray(int[] array)
{
    int tmp;
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        tmp = array[i];
        array[i] = array[j];
        array[j] = tmp;
    }
    return array;
}

int[] myArray = CreateRandomArray(8, 0, 10);
ShowArray(myArray);

int[] newArr = NewArray(myArray);
ShowArray(newArr);
*/

// Задача 3. Метод, который принимает число и выводит числа Фибоначчи
// С рекурсией
/*
double Fibonacci(int n)
{
    // f(0) = 0 f(1) = 1 f(n) =f(n-1) + f(n-2)
    if (n == 1 || n == 2)
        return 1;
    else
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"f({i}) = " + Fibonacci(i));
}
*/
// без рекурсии
/*
double[] Fibonacci(int size) // f(0) = 0 f(1) = 1 f(n) =f(n-1) + f(n-2)
{
    double[] arr = new double[size];
    arr[0] = 0;
    arr[1] = 1;
    arr[2] = 1;

    for (int i = 3; i < size; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

double[] myarray = Fibonacci(num + 1);
ShowArray(myarray);
*/

// Задача 3. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
/*
int PositiveNum(int size)
{
    int[] array = new int[size];
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
            count++;
    }
    return count;
}

Console.Write("Введите количество элементов - ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Количество положительных элементов - " + PositiveNum(num));
*/
