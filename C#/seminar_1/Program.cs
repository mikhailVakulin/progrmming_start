﻿Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Число " + a + " является квадратом числа " + b);

}
else
{
    Console.WriteLine("Число " + a + "не является квадратом числа " + b);
}



