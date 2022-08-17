// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

int[] array = new int[15];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int count = array.Length;
int quantityEven = 0;
for (int i = 0; i < count; i++)
{
    if (array[i] % 2 == 0) quantityEven += 1;
}
int quantityOdd = array.Length - quantityEven;
Console.WriteLine("Количество четных чисел равно " + quantityEven);
Console.WriteLine("Количество нечетных чисел равно " + quantityOdd);