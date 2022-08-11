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
array=reverseArray(array);
Console.WriteLine();            
Console.Write($"перевернутый массив = [{String.Join("; ", array)}]");


