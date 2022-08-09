// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("введите первое число: ");
int count1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int count2 = Convert.ToInt32(Console.ReadLine());
int temporary = count1;
for (int i = 1; i < count2; i++)
{

    temporary *= count1;
}

Console.WriteLine($"Число {count1} в степени {count2} = {temporary}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("введите число: ");
int count = Convert.ToInt32(Console.ReadLine());
int summator = 0;
while (count > 0)
{
    summator = summator + count % 10;
    count /= 10;
}
Console.WriteLine($"Сумма цифр = {summator}");


//  массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.Write(collection[index] + " ");
        index++;
    }
}

int[] array = new int[8];

FillArray(array);
Console.Write("Ура, наш масив - ");
PrintArray(array);