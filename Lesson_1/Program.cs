// Задача 1. Найти квадрат целого числа. 
/*
Console.Write("Imput integer number: ");
int number = Convert.ToInt32(Console.ReadLine()); // преобразует целочисленное значение 25, "25"- это строка

int Result = number * number;

Console.WriteLine("Result is " + Result);
*/

//Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Imput first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

//int quad = num2*num2; можно убрать эту команду, можно убрать фигурные скобки, так как всего по 1 строке в условии

if (num1 == num2 * num2) Console.WriteLine("First number is a quad of second number");
else Console.WriteLine("First number is NOT a quad of second number");
*/

//Задача 3. Напишите программу, которая преобразует число в день недели. 
/*
Console.Write("Imput number of week day: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7 || day < 1)
    Console.WriteLine("Incorrect number of day!");
else
{
    if (day == 1) Console.WriteLine("It's Monday");
    if (day == 2) Console.WriteLine("It's Thuesday");
    if (day == 3) Console.WriteLine("It's Wednesday");
    if (day == 4) Console.WriteLine("It's Thursday");
    if (day == 5) Console.WriteLine("It's Friday");
    if (day == 6) Console.WriteLine("It's Saturday");
    if (day == 7) Console.WriteLine("It's Sunday");
}
*/

//Задача 4. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Imput integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current;

if (num < 0)
{
    current = num;
    num = num * (-1);
}
else current = -1 * num;

while (current <= num)
{
    Console.Write(current + " "); // здесь просто пробел между числами " "
    current++;
}
*/

//Задача 5. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
/*
Console.Write("Imput integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999) Console.WriteLine("Incorrect number");
else
{
    int a = num % 10;
    Console.WriteLine("The last digit of the number " + a);
}
*/

