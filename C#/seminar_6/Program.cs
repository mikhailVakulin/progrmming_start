//Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] array = new int[5];  //задаём массив
for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(10);


Console.Write($"массив = [{String.Join("; ", array)}]");   //Переворачиваем массив при помощи буффера
for (int i = 0; i < array.Length / 2; i++)
{
    int temporary = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temporary;
}
Console.WriteLine();
Console.Write($"перевернутый массив = [{String.Join("; ", array)}]");


int[] reverseArray(int[] array)              //Переворачиваем массив при помои доп массива в методе
{
    int[] resultArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        resultArray[i] = array[array.Length - 1 - i];
    }
    return resultArray;
}
array = reverseArray(array);
Console.WriteLine();
Console.Write($"перевернутый массив = [{String.Join("; ", array)}]");


// используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int N = 7;
int firstNumber = 0;
int secondNumber = 1;
int result = 0;
System.Console.Write($"{firstNumber} {secondNumber} ");
for (int i = 2; i < N; i++)
{
    result=firstNumber+secondNumber;
    System.Console.Write($"{result} ");
    firstNumber=secondNumber;
    secondNumber=result;
}

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.WriteLine();
Console.WriteLine();
int [] array1 = new int[5];
for (int i = 0; i < array1.Length; i++) array1[i]= new Random().Next(10);
int[] copyArray = new int[5];
for (int i = 0; i < array1.Length; i++) copyArray[i]=array1[i];
System.Console.WriteLine(String.Join(" ",array1));
System.Console.WriteLine(String.Join(" ",copyArray));