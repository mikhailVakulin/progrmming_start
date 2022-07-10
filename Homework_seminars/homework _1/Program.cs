//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 5, b = 7, max;
if (a > b)
{
    max = a;
    Console.Write("max= ");
    Console.WriteLine(max);
}
else
{
    max = b;
    Console.Write("max= ");
    Console.WriteLine(max);
}




//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//после просмотра второй лекции захотелось потренироваться работе с массивом:)


int[] array = { 2, 3, 7 };
int index = 0, Max = array[index];
while (index < 3)
{
    if (array[index] > Max) Max = array[index];
    index++;

}
Console.WriteLine(Max);




//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
int count = 4;
if (count % 2 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1, sum = 0;
while (number >= 1 && number <= N)
{
    if (number % 2 == 0)
    {
        Console.Write(number + " ");
    }
    number++;
}

// в последней задаче в условии цикла while, можно обойтись и без логического оператора **И**(&&), но тренировки ради:))
