﻿// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}

// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumNumberInterval(m, n);

void SumNumberInterval(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

FunAkkerman(m,n);

void FunAkkerman(int m, int n)
{
    Console.Write(Akk(m, n)); 
}

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return (Akk(m - 1, Akk(m, n - 1)));
    }
}