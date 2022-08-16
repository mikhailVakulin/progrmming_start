
Console.Write("Ввдите количество строк : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввдите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
/// Заполнение двмерного массива 
int[,] createArray(int rows, int columns, int minRandom, int maxRandom)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = new Random().Next(minRandom, maxRandom);
        }
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


int[,] array = createArray(rows, columns, 0, 100);
printArrayInt(array);

/// Замена первой и последней строчки
void ChangeRows(int [,] inputMatrix)
{
    int indexLastRow = inputMatrix.GetLength(0) - 1; // Номер = индекс в массиве
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        int temp =  inputMatrix[0,i];
        inputMatrix[0,i] = inputMatrix[indexLastRow,i];
        inputMatrix[indexLastRow,i] = temp;
    }
}

System.Console.WriteLine();
ChangeRows(array);
printArrayInt(array);


// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший элемент массива.
 
int rows = 3;
int columns = 3;
 
int[,] matrix = new int[rows, columns];
 
int minValue = int.MaxValue; //Значение минимального элемента
int minIndexRows = 0;        //Задание индекса минимального элемента (строчка)
int minIndexColumns = 0;     //Задание индекса минимального элемента (столбец)
 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11); // [0,10]
        Console.Write(matrix[i, j] + "\t");
        if (minValue > matrix[i, j])
        // minValue = 5(пусть)
        // 5>0, то минимум уже не 5, minValue = 0
        {
            minValue = matrix[i, j];
            minIndexRows = i;
            minIndexColumns = j;
        }
 
    }
    Console.WriteLine();
}
Console.WriteLine("Минимум:" + minValue);
System.Console.WriteLine("Результат:");
for (int i = 0; i < rows; i++) // rows = GetLength(0)
{
    if (i != minIndexRows)
    {
        for (int j = 0; j < columns; j++) //columns - GetLength(1)
        {
            if (j != minIndexColumns)
            {
                Console.Write(matrix[i,j] + "\t");
 
            }
        }
        System.Console.WriteLine();
    }
}
