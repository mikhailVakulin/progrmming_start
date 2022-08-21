// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""


string allNaturalNumbers(int m, int n)
{
    if (m == n) return n.ToString();
    return (m + ", " + allNaturalNumbers(m + 1, n));
}

System.Console.WriteLine(allNaturalNumbers(1, 5));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


System.Console.WriteLine();
int sumElements(int m, int n)
{
    if (m == n) return n;
    return m + sumElements(m + 1, n);
}
System.Console.WriteLine(sumElements(1, 15));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

System.Console.WriteLine();
int akkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return akkermanFunction(m - 1, 1);
    return akkermanFunction(m - 1, akkermanFunction(m, n - 1));
}

System.Console.WriteLine(akkermanFunction(2,3));