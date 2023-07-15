// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitSum (int numberw)
{
    int sum = 0;
    while (numberw > 0)
    {
        int digit = numberw % 10;
        sum = sum + digit;
        numberw /= 10;
    }
    return sum;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите последовательность чисел: ");
int numberw = Math.Abs(number);
Console.WriteLine($"Сумма всех чисел в последовательности {numberw} = {DigitSum(numberw)}");