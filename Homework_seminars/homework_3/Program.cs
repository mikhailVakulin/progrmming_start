// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
int count = Int32.Parse(Console.ReadLine());

if (count / 10000 == count % 10)
{
    if (count / 1000 % 10 == count % 100 / 10) Console.WriteLine("count =  палиндром");
}
else
{
    Console.WriteLine("count не является палиндромом");
}

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("ввлите координаты точки Х1: ");
int X1 = Int32.Parse(Console.ReadLine());

Console.Write("ввлите координаты точки Y1: ");
int Y1 = Int32.Parse(Console.ReadLine());

Console.Write("ввлите координаты точки Z1: ");
int Z1 = Int32.Parse(Console.ReadLine());

Console.Write("ввлите координаты точки Х2: ");
int X2 = Int32.Parse(Console.ReadLine());

Console.Write("ввлите координаты точки Y2: ");
int Y2 = Int32.Parse(Console.ReadLine());

Console.Write("ввлите координаты точки Z2: ");
int Z2 = Int32.Parse(Console.ReadLine());

var distanceBetweenPoint = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
Console.WriteLine(Math.Round(distanceBetweenPoint, 2));


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("введите число: ");
int number = Int32.Parse(Console.ReadLine());
for (int i = 1; i < number; i++) Console.Write($"{Math.Pow(i, 3)} ");

