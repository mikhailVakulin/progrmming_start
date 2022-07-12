Console.Clear();
//создаем функции по заполнени и выводу на печать массива
void FillArray(int[] massive)
{
    int index = 0;
    int size = massive.Length;


    while (index < size)
    {
        massive[index] = new Random().Next(1, 30);
        index++;
    }
}
void PrintArray(int[] massive)
{
    int index = 0;
    int size = massive.Length;
    while (index < size)
    {
        Console.Write(massive[index] + " ");
        index++;
    }
}

//задаем размер массива
int[] array = new int[10];
//запускаем функции к нашему массиву
FillArray(array);
PrintArray(array);
//программа по поиску среднего арифмитического среди всех элементов массива
int arraySize = array.Length;
int index = 0, sum = 0;
while (index < arraySize)
{
    sum = sum + array[index];
    index++;
}
int arithmetic_mean = sum / arraySize;
Console.WriteLine();
Console.Write("Среднее арифмитическое массива= ");
Console.Write(arithmetic_mean);
Console.WriteLine();




//Найти сумму элементов массива, лежащих между максимальным и
//минимальным по значению элементами
//заполненный массив берем из предыдущего блока программы)
// переменная arraySize тоже из предыдущего блока
int imax = 0, imin = 0;
index = 0;
sum = 0;
while (index < arraySize)
{
    if (array[index] > array[imax]) imax = index;
    if (array[index] < array[imin]) imin = index;
    index++;
}
Console.WriteLine(imin);
Console.WriteLine(imax);
index = imin + 1;
if (imax > imin)
{
    while (index < imax)
    {
        sum = sum + array[index];
        index++;
    }
}

else
{
    index = imax + 1;
    while (index < imin)
    {
        sum = sum + array[index];
        index++;
    }

}
Console.Write("Сумма элементов= ");
Console.Write(sum);
//Всё работает, ура!!!