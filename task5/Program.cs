// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void FillArray(int[] collection)
{
    int length = collection.Length;
    for(int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    for(int i = 0; i < length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

int SummOfEven(int[] collection)
{
    int count = collection.Length;
    int summEven = 0;
        for(int i = 0; i < count; i++)
    {
        if (collection[i] % 2 == 0) summEven += 1;
    }
    return summEven;
}

int SummOfOdd(int[] collection)
{
    int count = collection.Length;
    int summOdd = 0;
    for(int i = 0; i < count; i++)
    {
        if (collection[i] % 2 != 0) summOdd += 1;
    }
    return summOdd;
}

int [] array = new int [15];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int quantityEven = SummOfEven(array);
int quantityOdd = SummOfOdd(array);
Console.WriteLine("Количество четных чисел равно " + quantityEven);
Console.WriteLine("Количество нечетных чисел равно " + quantityOdd);