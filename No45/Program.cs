// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] FillArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}

int [] CopyingArray(int length, int [] Array)
{
    int [] copy = new int[length];
    for (int i = 0; i < length; i++)
    {
        copy[i] = Array[i];
    }
    return copy;
}


Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int[] Array = FillArray(length);
Console.WriteLine(string.Join(" ", Array));
int [] result = CopyingArray(length, Array);
Console.WriteLine(string.Join(" ", result));