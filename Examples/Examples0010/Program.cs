void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.Write(collection[index] + " ");
        index++;
    }
}

int IndexOf(int[] colectiont, int find)
{
    int count = colectiont.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (colectiont[index] == find)
        {
            position = index;
            break;

        }
        {
            index++;
        }
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 5);

Console.WriteLine(pos);



