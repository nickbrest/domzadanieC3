// Определить, присутствует ли в заданном массиве, некоторое число
void FillArray(int[] collection)
{
    int length = collection.Length;
    for(int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(0,10);
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

int serchNum(int[] collection, int num)
{
int length = collection.Length;
int result = 0;
for (int i = 0; i < length; i++)
    {
    if (collection[i] == num) result = 1;
    }
return result;
}

int [] array = new int [12];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine()!);
int find = serchNum(array, number);
if (find == 1) Console.WriteLine("Число " + number + " присутствует в заданном массиве");
else Console.WriteLine("Число " + number + " не присутствует в заданном массиве");