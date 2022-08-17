// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillArray(double[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(-10, 10);
    }
}

void PrintArray(double[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

double[] array = new double[15];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int size = array.Length;
int i = 0;
double max = array[i];
while (i < size)
{
    if (array[i] > max) max = array[i];
    i++;
}
int index = 0;
double min = array[index];
while (index < size)
{
    if (array[index] < min) min = array[index];
    index++;
}
double different = max - min;
Console.Write("Максимальное число массива: ");
Console.WriteLine(max);
Console.Write("Минимальное число массива: ");
Console.WriteLine(min);
Console.Write("Разница между максимальным и минимальным: ");
Console.WriteLine(different);