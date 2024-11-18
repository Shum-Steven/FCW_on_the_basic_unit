// Напистаь программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньчше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнение алгоритма. 
//      Пример:
// ["Hello", "2", "world", ":-)"]   ->  ["2", ":-)"]
// ["1234", "1567", "-2"' "computer science"]   ->  ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


void Main() // Главный метод программы, точка входа
{
    string[] array = CreateArray(); // Создаём исходный массив строк
    PrintArray(array, "Исходный массив:"); // Вывод его на экран
    string[] resultArray = FilterArray(array); // Фильтруем массив по условию (строки <= 3 символам)
    PrintArray(resultArray, "Результат:"); // Выводим результат
}

string[] CreateArray() // Метод создания исходного массива
{
    // Меню выбора способа создания массива
    Console.WriteLine("Выберите способ создания массива:");
    Console.WriteLine("1 - Ввод с клавиатуры");
    Console.WriteLine("2 - Использовать готовый массив");
    int choice = Convert.ToInt32(Console.ReadLine()); // Ввод выбора пользователем

    while (choice != 1 && choice != 2) // Проверка на дурака
    {
        Console.WriteLine("Попробуй ещё: 1 или 2 ?"); // Вывод сообщения
        choice = Convert.ToInt32(Console.ReadLine()); // Ввод значения
    }

    if (choice == 1) // Если ввод равен 1
    {
        return InputArray(); // Вызываем метод ввода
    }
    else
    {
        // иначе возвращаем заготовленный массив
        return new string[] {"Hello", "2", "world", ":-)"};
    }
}

string[] InputArray() // Метод для ввода массива с клавиатуры
{
    int size = DataEntry("ВВедите размер массива: "); // Запрашиваем размер массива
    string[] tempArray = new string[size]; // Создаем временный массив

    for (int i = 0; i < size; i++) // Цикл ввода строк
    {
        Console.WriteLine($"Введите строку {i + 1}: "); // Приглашение к вводу
        tempArray[i] = Console.ReadLine() ?? string.Empty; // Возможность ввода строковых значений, с проверкой на Null
    }
    return tempArray; // Возвращаем заполненый массив
}

int DataEntry(string msg) // Вспомогательный метод для ввода числа
{
    Console.WriteLine(msg); // Вывод заданнного сообщения
    int number = Convert.ToInt32(Console.ReadLine()); // Перменная вводимого значения, преобразованного из строки в число
    while (number <= 0) // Проверка на дурака
    {
        Console.WriteLine("🤔, Попробуй от 1 и выше.."); // Вывод сообщения о неверном значение
        number = Convert.ToInt32(Console.ReadLine()); // Следующая попытка
    }
    return number; // Возврат веденного числа
}

void PrintArray(string[] arr, string message) // Метод вывода массива
{
    Console.WriteLine(message); // Вывод сообщения
    Console.Write("["); // Открывающая скобка массива
    for (int i = 0; i < arr.Length; i++) // Цикл по всем элементам
    {
        Console.Write($"\"{arr[i]}\""); // Вывод строки в ковычках
        if (i < arr.Length - 1) // Если это не последний элемент
        {
            Console.Write(","); // Добовляем разделитель (запятую)
        }
    }
    Console.WriteLine("]"); // Закрывающая скобка массива
}

string[] FilterArray(string[] inputArray) // Метод фильтрации массива
{
    // Сначала подсчитаем количество строк, удовлетворяющих условие
    int count = 0; // Счётчик подходящих строк
    for (int i = 0; i < inputArray.Length; i++) // Перебираем все строки входного массива
    {
        if(inputArray[i].Length <= 3) // Если длина строки <= 3
        {
            count++; // Увеличиваем счётчик
        }
    }
    // создаём новый массив нужного размера
    string[] resultArray = new string[count];
    int index = 0; //Индекс для заполнения нового массива
    // Заполняем массив строками, длина которых <= 3
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index] = inputArray[i]; // Копируем подходящую строку
            index++; // Увеличиваем индекс
        }
    }
    return resultArray; // Возвращаем результат
}

Main(); // Вызов главного метода