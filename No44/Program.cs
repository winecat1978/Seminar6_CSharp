// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if (int.TryParse(ValueFromConsole, out int num))
        {
            return num;
        }
        else 
        {
            Console.WriteLine("Вы ввели не число, попробуйте еще раз!");
        }
    }
}

int [] Fibonacci (int N)
{
    int [] array = new int[N];
    for (int i = 0; i < 2; i++)
    {
        array[i] = i;
    }
    for (int i = 2; i > 1 && i < N; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

string message = "Введите число: ";
int N = GetNumber(message);
int [] result = Fibonacci(N);
Console.WriteLine(string.Join(" ", result));