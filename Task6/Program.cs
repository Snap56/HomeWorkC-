// Напишите программу, которая на вход принимает число  и выдает, является ли число четным(делиться ли оно на два без остатка).

Console.Write("Напишите число ");

int number = int.Parse(Console.ReadLine());

if (number % 2 == 1) 
{
    Console.WriteLine("Не четное число");
}
if (number % 2 == 0 )
{
    Console.WriteLine("Четное число");
}
