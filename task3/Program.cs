// Написать программу замену элементов массива на противоположные
void FillArray(int[] collection)
{
    int length = collection.Length;
    for(int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(0,10);
    }
}

void PrintArray(int[] collect)
{
    int count = collect.Length;
    for(int index = 0; index < count; index++)
    {
        Console.Write(collect[index] + " ");
    }
}

void ReverseArray(int[] collection)
{
    int size = collection.Length;
    for(int index = 0; index < size/2; index++)
    {
        int temp = collection[index];
        collection[index] = collection[size-index-1];
        collection[size-index-1] = temp;
    }
}

int [] array = new int [15];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ReverseArray(array);
PrintArray(array);
