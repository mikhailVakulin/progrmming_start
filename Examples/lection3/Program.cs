// Подумайте как упорядочить 
// массив от большего к меньшему


void createArray(int[] array)  //функция заполнения массива
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(1, 10);
}


void printArray(int[] array)  //функция печати массива
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}
int[] collection = new int[5];

createArray(collection);
printArray(collection);

void swapCollection(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)

    {
        int maxNumber = i;
        for (int z = i + 1; z < array.Length; z++)
        {
            if (array[z] > array[maxNumber])
            {
                maxNumber = z;
            }
            int temporary = array[maxNumber];
            array[maxNumber] = array[i];
            array[i] = temporary;
        }
    }
}
swapCollection(collection);
Console.WriteLine();
printArray(collection);

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition])
//             {
//                 minPosition = j;
//             }
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }