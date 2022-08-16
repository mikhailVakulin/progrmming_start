// Урок 8. Как не нужно писать код. Часть 2
// Любые 4 задачки на "5"
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8
Console.WriteLine();
Console.Write("Задача 54");
Console.WriteLine();

Console.Write("Введите количество строк : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());


/// Заполнение двмерного массива 
int[,] createArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(100);
    }
    return array;
}

/// построчная печать двумерного массива
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

/// Сортировка двумерного массива по срокам от большего к меньшему
void sortArrayInt(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j + 1];
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = temp;

                }
            }
        }
    }
}



int[,] array54 = createArray(rows, columns);
System.Console.WriteLine();
Console.WriteLine("массив до сортровки:");
printArrayInt(array54);

System.Console.WriteLine();
sortArrayInt(array54);
Console.WriteLine("массив после сортровки:");
printArrayInt(array54);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine();
Console.Write("Задача 56");
Console.WriteLine();

Console.Write("Введите количество строк : ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
columns = Convert.ToInt32(Console.ReadLine());


int[,] array56 = createArray(rows, columns);
System.Console.WriteLine();
printArrayInt(array56);
Console.WriteLine();

/// поиск строки с минимальной сммой элементов
void SearchMinValueRows(int[,] matrix)
{
    int minValueRows = int.MaxValue;
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += array56[i, j];
        }
        if (minValueRows > sum)
        {
            minValueRows = sum; result = i + 1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов = {result} ");
}

SearchMinValueRows(array56);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49
Console.WriteLine();
Console.Write("Задача 58");
Console.WriteLine();
Console.Write("Введите количество строк : ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
Console.WriteLine("первый массив:");
int[,] firstArray58 = createArray(rows, columns);
printArrayInt(firstArray58);
Console.WriteLine();

Console.WriteLine("второй массив:");
int[,] secondArray58 = createArray(rows, columns);
printArrayInt(secondArray58);
Console.WriteLine();

Console.WriteLine("произведение массивов:");

/// произведение двух массивов
int[,] MultiplicationArray(int[,] matrix, int[,] array)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i, j] = matrix[i, j] * array[i, j];
        }

    }
    return result;
}
printArrayInt(MultiplicationArray(firstArray58, secondArray58));



// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)


Console.WriteLine();
Console.Write("Задача 60");
Console.WriteLine();

Console.Write("Введите количество строк : ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива : ");
int deep = Convert.ToInt32(Console.ReadLine());


/// Заполнение трехмерного массива 
int[,,] create3DArray(int rows, int columns, int deep)
{
    int[,,] array = new int[rows, columns, deep];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(100);
            }
        }
    }

    return array;
}

/// построчная печать двумерного массива
void print3DArrayInt(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]}[{i},{j},{k}]\t");
            }
            System.Console.WriteLine();
        }
    }
}



int[,,] array60 = create3DArray(rows, columns, deep);
print3DArrayInt(array60);




// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7