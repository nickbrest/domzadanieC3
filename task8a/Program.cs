// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1, 10);
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

int size = array.Length;
int[] paire = new int[size / 2];
for (int i = 0; i < size / 2; i++)
{
    paire[i] = array[i] * array[size - i - 1];
}

Console.WriteLine("Произведения пар чисел равны");
PrintArray(paire);
Console.WriteLine();
if (size % 2 != 0) Console.WriteLine("Числу " + array[size / 2] + " пары нет");