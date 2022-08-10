

// // // // Напишите программу которая принимает на вход число и выдаёт сумму чисел от 1 до заданного числа
// Console.Write("Ведите число: ");
// int count = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= count; i++)
// {
//     sum = sum + i;

// }
// Console.WriteLine($"Сумма чисел от 1 до {count} = {sum}");            //  конкатенация
// Console.WriteLine("Сумма чисел от 1 до " + count + " = " + sum);        //  интерполяция

// // // // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// // // // 456 -> 3
// // // // 78 -> 2
// // // // 89126 -> 5


// Console.Write("Ведите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int summator = 0;
// for (int i = 0; number / 10 >= 1; i++)
// {
//     summator = summator + 1;
//     number = number / 10;
// }
// Console.WriteLine($"Количество цифр в числе= {summator + 1}");


// // // Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// // // 4 -> 24
// // // 5 -> 120

// Console.Write("Ведите число: ");
// int count = Convert.ToInt32(Console.ReadLine());
// int sum = 1;
// for (int i = 1; i <= count; i++)
// {
//     sum = sum * i;

// }
// Console.WriteLine($"Факториал числа {count} = {sum}");




// // // Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // // [1,0,1,1,0,1,0,0]


// int[] createNewArray(int arraySize)
// {
//     int[] array = new int[arraySize];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(2);
//     }
//     return array;
// }
// int[] array = createNewArray(8);


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"  {array[i]}");
//     }
// }
// createNewArray(8);
// PrintArray(array);

// // // Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // // [1,0,1,1,0,1,0,0]


// void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// void PrintArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         Console.Write(collection[index] + " ");
//         index++;
//     }
// }
// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);


// // // Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // // [1,0,1,1,0,1,0,0]


int[] array = GetBinaryArray(8);
Console.Write($"[{String.Join(",", array)}]");
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    // new int[size] - массив размером size элементов
    // заполнен массив "0"
    // result.Length = size
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(2);// (2) - считаем, что числа от 0 до 1 (2 не включается)
    }
    return result; // int [] result
}