// Найти сумму чисел одномерного массива стоящих на нечетной позиции.
void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1,20);
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
int summ = 0;
for (int i = 0; i < count; i++)
{
    if ((i+1) % 2 != 0) summ += array[i];
}
Console.WriteLine("Сумма нечетных элементов массива " + summ);

// Задача решалась исходя из того что позиция не равно индекс. Элементы массива из 15 чисел имеют позиции от 1 до 15 и индексы от 0 до 14.