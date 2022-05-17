//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int NaturalSum(int a)
{
    int sum = 0;

    if (a < 1) return 0;
    else
    {
        for (int i = 1; i <= a; i++)
        {
            sum = sum + i; // sum += i; -= *= и т д то эже самое, упрощенная запись
        }
        return sum;
    }
}
Console.Write("Input number A - ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Sum of elements from 1 to {num} = " + NaturalSum(num));
*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
void CountDigitNum(int num1)
{
    int count = 0;

    while (num1 != 0)
    {
        num1 /= 10;
        count++;
    }
    Console.Write(count);
}

Console.Write("Input Number - ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("The number of digits - ");
CountDigitNum(num);
*/

// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factorial(int a)
{
    int fact = 1;

    if (a < 1) return 0;
    else
    {
        for (int i = 1; i <= a; i++)
        {
            fact = fact * i;
        }
        return fact;
    }
}

Console.Write("Input number - ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Factorial = " + Factorial(num));
*/

// Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]
/*
void PrintArray()
{
    int[] ar = new int[8];

    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = new Random().Next(0, 2);
        Console.Write(ar[i] + " ");
    }
}
PrintArray();
*/

// Задача 5. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
/*
int[] CreateRandomArray(int size, int min, int max) // int min, int max - для рандомных чисел
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        //Console.Write("Input " + i + " element: ");
        //array[i] = Convert.ToInt32(Console.ReadLine()); для заполнения с клавиатуры
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void FindSumOfElements(int[] array)
{
    int plusSum = 0;
    int minusSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) plusSum += array[i];
        else minusSum += array[i];
    }
    Console.WriteLine("Sum of positive elements is " + plusSum);
    Console.WriteLine("Sum of negative elements is " + minusSum);
    
}

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);
FindSumOfElements(myArray);
*/