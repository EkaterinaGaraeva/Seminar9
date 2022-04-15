/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int StepNumber(int number, int step, int result = 1)
{
    if (step > 0)
    {
        result *= number;
        step--;
        result = StepNumber(number, step, result);
    }
    return result;
}

int res = StepNumber(8, 2);
Console.WriteLine(res);
