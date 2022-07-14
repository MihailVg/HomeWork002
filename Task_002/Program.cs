// Задача N2, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число, третью цифру которого хотите узнать: ");

int numberA = int.Parse(Console.ReadLine()!);
int numberB = 0;

if(numberA < 100)
{
    Console.WriteLine("Данное число не имеет третьей цифры");
}

else{
    while(numberA > 1000)
    {
        numberA = numberA / 10;
    }

    numberB = numberA % 10;
    Console.WriteLine("Третьей цифрой заданного числа является " + numberB);
}
