// Задача N2, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число, вторую цифру которого вы хотите определить: ");

int numberA = int.Parse(Console.ReadLine()!);
int numberB = numberA / 10 % 10;

Console.WriteLine("Второй цифрой числа " + numberA + " является " + numberB);