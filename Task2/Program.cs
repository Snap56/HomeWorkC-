// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");

int number1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int number2 = Int32.Parse(Console.ReadLine());

if (number1 > number2)
    {
    Console.WriteLine(number1 + " Большее число.");
    Console.WriteLine(number2 + " Меньшее чило. ");
    }
else
{
    Console.WriteLine(number2+ " Большее число.");
    Console.WriteLine(number1 + " Меньшее чило. ");
}

