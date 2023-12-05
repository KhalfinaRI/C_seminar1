// вводит 2 целых числа и проверяет является ли 1ое квадратом 2ого;

int numberA = new Random().Next(1, 60);
Console.WriteLine(numberA);

int numberB = new Random().Next(1, 60);
Console.WriteLine(numberB);

if(numberA == numberB * numberB)
{
    Console.WriteLine($"numberA = {numberA} is quadrat numberB = {numberB}");
} else if(numberB == numberA * numberA)
{
    Console.WriteLine($"numberB = {numberB} is quadrat numberA = {numberA}");
} else
{
    Console.WriteLine("no one number is not a quadrat each other");
}
