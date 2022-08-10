//Задайте массив из 12ти элементов, заполненный случайными числами из промежутка [-9,9] . Найдите сумму отрицательных и положительных эллементов массива


int[] createNewArray(int size, int minRandom, int maxRandom)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minRandom, maxRandom + 1);

    }
    return result;
}
int[] workArray = createNewArray(12, -9, 9);
Console.Write($"[{String.Join(" , ", workArray)}]");
Console.WriteLine();
int negativeSum = 0, positiveSum = 0;
for (int i = 0; i < workArray.Length; i++)
{
    if (workArray[i] < 0)
    {
        negativeSum += workArray[i];
    }
    else
    {
        positiveSum += workArray[i];
    }
}
Console.WriteLine($"Сумма положительных = {positiveSum}, Сумма отрицательных = {negativeSum}");


//Напишите программу замена элементов массива: положительные замените на отрицательные и наоборот

for (int i = 0; i < workArray.Length; i++) workArray[i] *= -1;
Console.Write($"[{String.Join(" , ", workArray)}]");



//Задайте массив напишите программу, которая определяет присутствует ли данное число в массиве
Console.WriteLine();
Console.Write("Введите чиcло: ");
int count = Convert.ToInt32(Console.ReadLine());
string checkResult = "False";
for (int i = 0; i < workArray.Length; i++)
{
    if (count == workArray[i]) checkResult = "true";
}
Console.Write(checkResult);


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

workArray = createNewArray(20, 0, 400);
Console.WriteLine();
Console.Write($"[{String.Join(" , ", workArray)}]");
int sum = 0;
for (int i = 0; i < workArray.Length; i++)
{
    if (workArray[i] > 10 && workArray[i] < 99) sum ++;
}
Console.WriteLine();
Console.Write($"Количество элементов в заданном промежутке = {sum} ");