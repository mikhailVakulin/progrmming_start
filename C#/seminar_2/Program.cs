//Второй семинар по знакомству с прогрммированием
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8
//int number = new Random().Next(10, 100); //[10;99]
//Console.WriteLine(number);
//int firstDigit = number / 10; //Первое число: 64 / 10 = 6
//int secondDigit = number % 10; // Второе число - остаток от деления на 10: 64 % 10 =4

//if (firstDigit > secondDigit)
//{
//    Console.WriteLine($"Первое число {firstDigit} больше");
//}

//else 
//{
//    Console.WriteLine($"Второе число {secondDigit} больше");
//}

// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да
/*int count = new Random().Next(100, 1000);
Console.WriteLine(count);
int firstDigit = count / 100;
int thirdDigit = count % 10;
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine(result);
*/
int count1 = Convert.ToInt32(Console.ReadLine());
int count2 = Convert.ToInt32(Console.ReadLine());

if (count1 % count2 == 0)
{
    Console.WriteLine("Второе исло кратно первому");
}
else
{
    Console.WriteLine($"Остаток от деления: {count1 % count2} ");
}
// 14. Напишите программу,
// которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да - true
 
bool IsMultiplicity (int number)
{
    return(number % 7 == 0 && number % 23 == 0); // True, False
    // and -> True-> True and True
    // and -> False -> False
}

Console.WriteLine(IsMultiplicity(14));
