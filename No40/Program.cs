// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
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

string TriangleChecker(int num1, int num2, int num3)
{
    string answer = " ";
    if ((num1 < num2 + num3) && (num2 < num1 + num3) && (num3 < num1 + num2))
    {
        answer = "Треугольник с такими сторонами может существовать.";
    }
    else answer = "Треугольник с такими сторонами не может существовать.";
    return answer;
}

string message1 = "Введите первое число: ";
string message2 = "Введите второе число: ";
string message3 = "Введите третье число: ";
int num1 = GetNumber(message1);
int num2 = GetNumber(message2);
int num3 = GetNumber(message3);
Console.WriteLine($"Вы ввели числа {num1}, {num2}, {num3}.");
string result = TriangleChecker(num1, num2, num3);
Console.WriteLine(result);