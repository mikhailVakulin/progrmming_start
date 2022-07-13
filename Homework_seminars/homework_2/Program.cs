﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int newCount = Convert.ToInt32(Console.ReadLine());

if (newCount < 1000 && newCount > 99)
{
    newCount /= 10;
    newCount %= 10;
    Console.WriteLine($"Вторая цифра числа = {newCount}");

}
else
{
    Console.WriteLine("Ошибка, число не трехзначное!");
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while (number > 999) number /= 10;
    number %= 10;
    Console.WriteLine($"Третья цифра = {number}");
}
else
{
    Console.WriteLine("Ошибка, третьей цифры нет!");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Введите порядковый номер дня недели: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
if (dayOfTheWeek == 6 || dayOfTheWeek == 7)
{
    Console.WriteLine("Прими мои поздравления друг, этот день -выходной!");
}
else
{
    Console.WriteLine("Не хотел тебя расстраивать, но увы- этот день рабочий..");
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// ввод дня недели и переменная dayOfTheWeek описаны выше
bool result = (dayOfTheWeek == 6 || dayOfTheWeek == 7);
Console.WriteLine($"Выходной? - {result}");
