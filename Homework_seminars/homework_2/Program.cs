//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
int newcount = Convert.ToInt32(Console.ReadLine());

if (newcount < 1000 && newcount > 99)
{
    newcount = newcount / 10;
    newcount = newcount % 10;
    Console.WriteLine(newcount);

}
else
{
    Console.WriteLine("Ошибка, число не трехзначное!");
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while (number > 999)  number/=10;
    number=number%10;
    Console.WriteLine(number);
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
else{
    Console.WriteLine("Не хотел тебя расстраивать, но увы- этот день рабочий..");
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите порядковый номер дня недели: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
bool result = (dayOfTheWeek == 6 || dayOfTheWeek == 7);
Console.WriteLine(result);