// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1, 200);
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

int[] array = new int[123];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int count = array.Length;
int quantity = 0;
for (int i = 0; i < count; i++)
{
    if (array[i] >= 10 && array[i] <= 99) quantity += 1;
}
Console.WriteLine("Количество элементов отрезка равно " + quantity);