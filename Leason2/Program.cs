﻿// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = Prompt();
int N = Prompt();

int Prompt()
{
    Console.WriteLine("Введите значение: ");
    int limit = int.Parse(Console.ReadLine()!);
    return limit;
}

SumFromMToN(M, N);

void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m , n);
        return res;
    }
}