/*
Задача 67: Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

void SumNumbers(int number, int sum = 0)
{
    if (number == 0)
    {
        Console.WriteLine($"Сумма цифр = {sum}");
        return;
    }
    else
    {
        sum += number % 10;
        number /= 10;
        SumNumbers(number, sum);
    }
}

SumNumbers(453);

