// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива (массив задал [-9,9])
void FillArray(int[] collection)
{
    int length = collection.Length;
    for(int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(-9,9);
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

int SummOfPos(int[] collection)
{
    int count = collection.Length;
    int summPositive = 0;
        for(int index = 0; index < count; index++)
    {
        if (collection[index] > 0) summPositive = summPositive + collection[index];
    }
    return summPositive;
}

int SummOfNeg(int[] collection)
{
    int count = collection.Length;
    int summNegative = 0;
    for(int index = 0; index < count; index++)
    {
        if (collection[index] < 0) summNegative = summNegative + collection[index];
    }
    return summNegative;
}

int [] array = new int [12];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int summPos = SummOfPos(array);
int summNeg = SummOfNeg(array);
Console.Write("Сумма положительных элементов: ");
Console.WriteLine(summPos);
Console.Write("Сумма отрицательных элементов: ");
Console.WriteLine(summNeg);
