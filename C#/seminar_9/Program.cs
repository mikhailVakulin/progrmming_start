// factorial 
// 4!= 1 * 2 * 3 * 4 = 24

int factorial(int number)
{
    if (number == 1) return 1;
    return number * factorial(number - 1);
}
System.Console.WriteLine(factorial(10));

// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

/// start = 1 - начальная точка
/// end - N - конец
// [1;N]
string PrintNumbers(int start, int end)
{
    // Базовый случай
    if (start == end) return start.ToString();
    // Рекурсивный случай
    return (start + ", " + PrintNumbers(start + 1, end));
}

int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(1, N));


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int sumNumbers(int number)
{
    if (number / 10 == 1) return 0;
    return number%10 + sumNumbers(number/10);
}
System.Console.WriteLine(sumNumbers(453));


//  Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int power(int number, int degree)
{
    if (degree == 1) return number;
    return number * power(number, degree-1);
}

System.Console.WriteLine(power(3, 5));