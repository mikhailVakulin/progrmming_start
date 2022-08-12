// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Write("Введите количество чисел - ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-10, 10);
Console.WriteLine(String.Join(" ", array));
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) result++;
}
System.Console.WriteLine($"Чисел больше нуля = {result}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
double b1 = 2, k1 = 5, b2 = 4, k2 = 9;
double  y, x;
// y = k1 * x + b1, 
// k1* x + b1 = k2 * x + b2;
// k1* x - k2*x=b2-b1;
// (k1-k2)*x=b2-b1;
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;
Console.Write($"координаты ({y} , {x})");
