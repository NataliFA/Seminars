/*int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
*/
// Задача 1. Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие 
//отрицательные, и наоборот.


/*
int[] ChangeNums(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] *= (-1));
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);
ChangeNums(myArray);
*/





//Задача 2. Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное число 
//в массиве.
/*
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

string FindNumber(int[] array, int numbers)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numbers)
        {
            return "Your number in array";
        }
    }
    return "Your number NOT in array";

}
Console.Write("Input number: ");
int Num = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(5, 0, 5);
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine(FindNumber(myArray, Num));
*/

// Задача 3. Задайте одномерный массив из 15 случайных 
//чисел. Найдите количество элементов массива, значения 
//которых лежат в отрезке [10,99].
/*
int[] CreateArray()
{
    int[] array = new int[15];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write(array[i] + " ");
    }
    return array;
}
*/
/*
void CountElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество элементов, которые лежат в отрезке от 10 до 100 = {count}");
}
*/
/*
int CountElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
            count++;
    }
    return count;

}

CountElements(CreateArray());
*/
// Задача 4. Найдите произведение пар чисел в одномерном 
//массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в 
//новом массиве.

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] NewMagicArray(int[] array)
{
    int newSize = array.Length / 2;
    int[] newArray = new int[newSize];

    for (int i = 0, j = array.Length - 1; i < newSize; i++, j--)
    {
        newArray[i] = array[i] * array[j];
    }
    return newArray;

}

int[] myArray = CreateArray(7, 1, 6);
int[] newArr = NewMagicArray(myArray);
ShowArray(myArray);
Console.WriteLine();
ShowArray(newArr);


