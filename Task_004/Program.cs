// Задача N4, которая принимает на вход цифру, обозначающую день недели, а на выходе наименования дня

Console.WriteLine("Введите цифру, обозначающую день недели, чтобы проверить его наименование: ");

int numberA = int.Parse(Console.ReadLine()!);

if(numberA == 1)
{
    Console.WriteLine("Понедельник");
}

if(numberA == 2)
{
    Console.WriteLine("Вторник");
}

if(numberA == 3)
{
    Console.WriteLine("Среда");
}

if(numberA == 4)
{
    Console.WriteLine("Четверг");
}

if(numberA == 5)
{
    Console.WriteLine("Пятница");
}

if(numberA == 6)
{
    Console.WriteLine("Суббота");
}

if(numberA == 7)
{
    Console.WriteLine("Воскресенье");
}

if(numberA < 1)
{
    Console.WriteLine("Такого дня недели нет");
}

if(numberA > 7)
{
    Console.WriteLine("Такого дня недели нет");
}