//Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int ShowNumber()   // int - возвращаемый тип метода, обязательно должна быть команда return
{
    int n = new Random().Next(10,99);
    int firstNum = n/10;
    int secondNum = n%10;

    Console.Write(n + "-> ");

    if (firstNum > secondNum)
    {
        return firstNum;  // возвращаем значение, но необходимо знать куда?, для этого задаем переменную "int a"
    }
    else
    {
        return secondNum;
    }
}
int a = ShowNumber();  // переменная "а" должна быть такого же типа как метод вначале
Console.Write(a);
*/

//Задача 2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
void ShowNumber()  // невозвращаемый тип метода
{
    int num = new Random().Next(100, 999);
    Console.WriteLine(num);
    int firstNum = num / 100;
    int secondNum = num % 10;
    
  Console.Write(firstNum * 10 + secondNum);
}
ShowNumber();
*/

//Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным 
//первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
/*
Console.Write("Imput first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine()); 

void Show()
{
    if (num2 % num1 == 0)
    {
        Console.Write("2 number is divisible by 1 without remainder");
    }
    else
    {
        Console.Write("Remainder (ostatok) = " + num2 / num1);
    }
}
Show();
*/

//Задача 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
/*
void Multiple(int num)
{
    if(num % 7 == 0 && num % 23 == 0 )
    {
         Console.Write("Yes, the number is a multiple of 7 and 23");
    }
    else
    {
         Console.Write("No, the number is NOT a multiple of 7 and 23");
    }
}
Console.Write("Imput integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Multiple(num);
*/

//Задача 5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
void SQR(int num1, int num2)
{
    if (num1 == num2*num2)
    {
        Console.Write("Yes, the first number is the square of the second number");
    }
    else
    {
        Console.Write("No, the first number is NOT the square of the second number");
    }
}

Console.Write("Imput first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine()); 
SQR(num1, num2);
*/