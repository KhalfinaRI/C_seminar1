﻿// вводит 2 целых числа и проверяет является ли 1ое квадратом 2ого;

int numberA = new Random().Next(1, 60);
Console.WriteLine(numberA);

int numberB = new Random().Next(1, 60);
Console.WriteLine(numberB);

if(numberA == numberB * numberB)
{
    Console.WriteLine("1ое число является квадратом второго");
}
else
{
    Console.WriteLine("1ое число не является квадратом второго");
}

