// Напишите программу, которая будет преобразовывать десятичное число в двоичное
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

int [] OneZeroOneReverser(int N)
{
    int count = 0;
    int M = N;
    do 
    {
        M = M/2;
        count +=1;
    }
    while (M >= 1);
    int [] arr = new int [count];
    for (int i = 0; i < count; i++)
    {
        if(N%2 == 0) 
        {
            arr[i] = 0;
            N=N/2;
        }
        else if(N%2 == 1)
        {
            arr[i] = 1;
            N = N/2;
        }    
    }
    Array.Reverse(arr);
    return arr;
}
string message = "Введите число, которое хотите перевести в двоичную систему счисления: ";
int N = GetNumber(message);
Console.WriteLine($"Вы ввели число {N} в десятичной системе счисления. В двоичной это:");
int [] result = OneZeroOneReverser(N);
Console.WriteLine(string.Join("", result));