// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

/// построчная печать двумерого массива с вещ. числами
void printArrayDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(Math.Round(matrix[i, j], 2) + "\t");
        }
        System.Console.WriteLine();
    }
}


Console.WriteLine();
Console.WriteLine("Задача 47");
Console.WriteLine();

Console.Write("Ввдите количество строк : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввдите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().NextDouble() * 10;
    }
}

printArrayDouble(array);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


/// заполнение двумерного массива целыми числами
int[,] createArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = new Random().Next(100);
        }
    }
    return array;
}
///  построчная печать двумерого массива с целыми числами
void printArrayInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
Console.WriteLine();
Console.WriteLine("Задача 50");
Console.WriteLine();

Console.Write("Ввдите количество строк : ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввдите количество столбцов : ");
columns = Convert.ToInt32(Console.ReadLine());

int[,] array1 = createArray(rows, columns);
printArrayInt(array1);

Console.Write("Ввдите искомое значение : ");
int searchCount = Convert.ToInt32(Console.ReadLine());
bool result = false;
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        if (searchCount == array1[i, j])
        {
            Console.WriteLine($"Индекс позиции искомого числа = [{i} , {j}]");
            result = true;
        }

    }
}
if (result == false) Console.WriteLine("Такого числа нет");



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// массив возьмём из предыдущей задачи
Console.WriteLine();
Console.WriteLine("Задача 52");
Console.WriteLine();
int sum = 0;
for (int i = 0; i < array1.GetLength(1); i++)
{
    sum = 0;
    for (int j = 0; j < array1.GetLength(0); j++)
    {
        sum += array1[j, i];
    }
    sum = sum / rows;
    Console.WriteLine($"Среднее аифмитическое {i + 1} столбца = {sum}");
}