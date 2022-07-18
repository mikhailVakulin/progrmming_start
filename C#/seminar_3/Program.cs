//программа по оординатм определет четверть на координатах в которой лежит точка
Console.Write("Введите координаты X: ");

int x = Int32.Parse(Console.ReadLine());

Console.Write("Введите координаты Y: ");

int y = Int32.Parse(Console.ReadLine());
int quarter;
if (x > 0 && y > 0)
{ quarter = 1; }
else if (x > 0 && y < 0)
{
    quarter = 2;
}
else if (x < 0 && y < 0)
{
    quarter = 3;
}
else { quarter = 4; }
Console.WriteLine($"Чтверть: {quarter}");



//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
//через цикл while и доп перменной
Console.Write("Введите число: ");
int count = Int32.Parse(Console.ReadLine());
int counter = 1;
while (counter <= count)
{
    Console.Write($"{counter * counter} ,");
    counter++;
}

//через цикл FOR и пользуем интерполяцию
Console.Write("Цикл FOR Введите число: ");
int length = Int32.Parse(Console.ReadLine());
for (int i = 1; i <= length; i++)
{

    Console.Write($"{i * i} ");
}



// Задача 18: Напишите программу, 
// которая по заданному номеру четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).

Console.Write("Введит четверть: ");
int numberQuarter = Int32.Parse(Console.ReadLine());
if (numberQuarter == 1) Console.WriteLine("диапазон возможных координат точек в этой четверти: x > 0, y > 0");
else if (numberQuarter == 2) Console.WriteLine("диапазон возможных координат точек в этой четверти: x > 0, y < 0");
else if (numberQuarter == 3) Console.WriteLine("диапазон возможных координат точек в этой четверти: x < 0, y < 0");
else if (numberQuarter == 4) Console.WriteLine("диапазон возможных координат точек в этой четверти: x > 0, y < 0");

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

//Формула: l = √ (x 2 - x 1)^2+ (y 2 - y 1)^2

Console.Write("ввлите координаты точки Х1: ");
int X1 = Int32.Parse(Console.ReadLine());

Console.Write("ввлите координаты точки Y1: ");
int Y1 = Int32.Parse(Console.ReadLine());

Console.Write("ввлите координаты точки Х2: ");
int X2 = Int32.Parse(Console.ReadLine());

Console.Write("ввлите координаты точки Y2: ");
int Y2 = Int32.Parse(Console.ReadLine());

// var- автоматически опрееляет тип данных, 
//round- округляет до цлого числа Math.Pow возводит в степень(число, степень)
var distanceBetweenPoint = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
Console.WriteLine(Math.Round(distanceBetweenPoint, 2));