// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQvart(int x, int y)
{
    if (x > 0 && y > 0) return 1; // 1 четверть
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else if (x > 0 && y < 0) return 4;
    else return 0; // если х или у равны 0
}

Console.Write("Input X coordinate: ");
int xDot = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y coordinate: ");
int yDot = Convert.ToInt32(Console.ReadLine());

int Qvartnum = FindQvart(xDot, yDot);

if (Qvartnum == 0) Console.Write("Dot located on the axes!");
else Console.Write("Number of qvart is " + Qvartnum);
*/

// Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void Coordinates(int q)
{
    if (q == 1) Console.Write("Диапазон координат точки Х > 0 и У > 0");
    else if (q == 2) Console.Write("Диапазон координат точки Х < 0 и У > 0");
    else if (q == 3) Console.Write("Диапазон координат точки Х < 0 и У < 0");
    else if (q == 4) Console.Write("Диапазон координат точки Х > 0 и У < 0");
    else Console.Write("Точка расположена на оси");
}

Console.Write("Input number of qvart from 0 to 4 ");
int Qvartnum = Convert.ToInt32(Console.ReadLine());

if (Qvartnum > 4 || Qvartnum < 0) Console.Write("Incorrect number");
else Coordinates(Qvartnum);
*/

// Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// метод (Math.Sqrt(25)); находит квадратный корень того,что в скобках
/*
double Rasst2dot(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}
Console.Write("Введите координату X 1 точки: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y 1 точки: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X 2 точки: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y 2 точки: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Расстояние между 2 точками - " + Rasst2dot(x1, y1, x2, y2));
*/
// Задача 4. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void TableSqrt(int N)
{
    int count = 1;
    Console.Write(N + " -> ");
    while (count <= N)
    {
        Console.Write(count * count + " ");
        count++;
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0) TableSqrt(num);
else Console.Write("Введите положительное число!");
*/