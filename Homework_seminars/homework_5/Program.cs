// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] randomArray = { 345, 897, 568, 234 };
int evenCount = 0;
for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] % 2 == 0) evenCount++;
}
Console.WriteLine($"Количество четных чисел - {evenCount}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] createArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++) array[i] = new Random().Next(0, 100);
    return array;
}
int[] array = createArray(5);
Console.Write($"[{String.Join(" , ", array)}]");

int sumOddPosition=0;
for (int i = 1; i < array.Length; i+=2) sumOddPosition += array[i];
Console.WriteLine();
Console.Write($" Сумма позиций с нечетными индексами = {sumOddPosition}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double [] newArray= new double[5];
for (int i = 0; i < newArray.Length; i++) newArray[i]= new Random().NextDouble()*10;
Console.WriteLine();
Console.Write($"[{String.Join(" , ", newArray)}]");

double max= newArray[0], min = newArray[0];
for (int i = 1; i < newArray.Length; i++)
{
    if (newArray[i]>max) max=newArray[i];
    if (newArray[i]<min) min=newArray[i];
}
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным числом = {Math.Round(max-min,2)}");