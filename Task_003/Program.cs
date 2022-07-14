// Задача N3, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели, чтобы проверить, является ли он выходным: ");

int numberA = int.Parse(Console.ReadLine()!);

if(numberA == 1)
{
    Console.WriteLine("Нет");
}

if(numberA == 2)
{
    Console.WriteLine("Нет");
}

if(numberA == 3)
{
    Console.WriteLine("Нет");
}

if(numberA == 4)
{
    Console.WriteLine("Нет");
}

if(numberA == 5)
{
    Console.WriteLine("Нет");
}

if(numberA == 6)
{
    Console.WriteLine("Да");
}

if(numberA == 7)
{
    Console.WriteLine("Да");
}

if(numberA < 1)
{
    Console.WriteLine("Такого дня недели нет");
}

if(numberA > 7)
{
    Console.WriteLine("Такого дня недели нет");
}