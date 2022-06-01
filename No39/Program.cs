//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

int[] Reverse(int[] Array) // Array.reverse();
{
    int[] result = new int[Array.Length];
    int ResultCount = 0;
    for (int i = Array.Length - 1; i >= 0; i--)
    {
        result[ResultCount] = Array[i];
        ResultCount++;
    }
    return result;
}

// void ReverseByItSelf (int[] Array)
// {
//     Array.Reverse();
// }

Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int[] Array = FillArray(length);
Console.WriteLine(string.Join(" ", Array));
int [] Result = Reverse(Array);
Console.WriteLine(string.Join(" ", Result));