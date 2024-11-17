﻿// Напистаь программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньчше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнение алгоритма. 
//      Пример:
// ["Hello", "2", "world", ":-)"]   ->  ["2", ":-)"]
// ["1234", "1567", "-2"' "computer science"]   ->  ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


void Main()
{
    string[] array = CreateArray();
    PrintArray(array, "Исходный массив:");
    string[] resultArray = FilterArray(array);
    PrintArray(resultArray, "Результат:");
}

string[] CreateArray()
{
    Console.WriteLine("Выберите способ создания массива:");
    Console.WriteLine("1 - Ввод с клавиатуры");
    Console.WriteLine("2 - Использовать готовый массив");
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        return InputArray();
    }
    else
    {
        return new string[] {"Hello", "2", "world", ":-)"};
    }
}

string[] InputArray()
{
    int size = DataEntry("ВВедите размер массива: ");
    string[] tempArray = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите строку {i + 1}: ");
        tempArray[i] = Console.ReadLine():
    }
    return tempArray;
}

void PrintArray(string[] arr, string message)
{
    Console.WriteLine(message);
    Console.WriteLine("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"\"{arr[i]}\"");
        if (i < arr.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int DataEntry(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();