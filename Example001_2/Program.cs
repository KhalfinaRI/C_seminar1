// вводит 2 целых числа и проверяет является ли 1ое квадратом 2ого;

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

if(numberA == numberB * numberB)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}
