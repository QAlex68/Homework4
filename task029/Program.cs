// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Задачу не совсем понял!
// Вариант 1 создает массив случайных чисел из указанного количества элементов и выводит на консоль

int[] FillArray(int size)  
{ 
    int[] collection = new int[size];
    
    for (int i = 0; i<size; i++) 
    { 
        collection[i] = new Random().Next(100);         
    } 
    return collection;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
 
int size = GetInput("Введите количество элементов в масиве: ");
int[] array = FillArray(size);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine();

// Вариант 2 принимает строку символов преобразует в массив и выводит на консоль
string GetInput2(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}
string str = GetInput2("Введите последовательность чисел: ");
char[] array1 = str.ToCharArray();
Console.WriteLine($"[{String.Join(",", array1)}]");