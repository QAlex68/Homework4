// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DegreeConversion(int x, int y) 
{ 
    int product = x; 
    for (int i = 1; i < y; i++) 
    { 
        product *= x; 
    } 
    return product; 
} 
 
int GetInput(string text) 
{ 
    Console.Write(text); 
    return Convert.ToInt32(Console.ReadLine()); 
} 
 
int x = GetInput("Введите число A: "); 
int y = GetInput("Введите степень числа A: "); 
 
Console.WriteLine($"Результат возведнеия числа {x} в степень {y} = {DegreeConversion(x,y)}");
