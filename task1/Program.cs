// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void FillArray(int[] collection)
{
    int length = collection.Length;
    for(int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(0,2);
    }
}

void PrintArray(int[] collect)
{
    int count = collect.Length;
    for(int position = 0; position < count; position++)
    {
        Console.Write(collect[position] + " ");
    }
}

int [] array = new int [8];

FillArray(array);
PrintArray(array);