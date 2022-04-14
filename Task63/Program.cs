﻿/*
Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void NatureNumbers(int number, int count = 1)
{
    if (count > number)
    {
        return;
    }
    else
    {
        Console.Write($"{count}");
        if (count < number)
        {
            Console.Write($", ");
        }
        NatureNumbers(number, ++count);
    }
}

NatureNumbers(12);
