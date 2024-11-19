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
    else // иначе возвращаем случайный заготовленный массив
    {
        string[][] presetArrays = new string[][] // Двумерный массив строк, означающий что каждэый элемент этого массива тоже является массивом строк
        {
            new string[] {"Hello", "2", "world", ":-)"}, // Пример 1
            new string[] {"1234", "1567", "-2", "computer science"}, // Пример 2
            new string[] {"Russia", "Denmark", "Kazan"} // Пример 3
        }; // Закрытие блока кода с завершением оператора  

        Random random = new Random(); // Генератор случайных чисел
        return presetArrays[random.Next(presetArrays.Length)]; // Возвращает массив по случайному сгенерированному индексу (от 0 до кол-ва массивов - 1)
    }
}

string[] InputArray() // Метод для ввода массива с клавиатуры
{
    Console.WriteLine("Введите размер массива: "); // Вывод сообщения
    int size = Convert.ToInt32(Console.ReadLine()); // Ввод значения от пользователя
        while (size <= 0) // Проверка на дурака
            {
                Console.WriteLine("🤔, Попробуй от 1 и выше.."); // Вывод сообщения о неверном значение
                size = Convert.ToInt32(Console.ReadLine()); // Следующая попытка;
            }
            if (size > 9) // Сарказм
                {
                    Console.WriteLine("Я бы рекомендовал ограничется значением до 10 🧐 Но жребий уже Брошен - к Барьеру! 🧑‍🎓");
                }

    string[] tempArray = new string[size]; // Создаем временный массив

    for (int i = 0; i < size; i++) // Цикл ввода строк
    {
        Console.WriteLine($"Введите строку {i + 1}: "); // Приглашение к вводу
        tempArray[i] = Console.ReadLine() ?? string.Empty; // Возможность ввода строковых значений, с проверкой на Null
    }
    return tempArray; // Возвращаем заполненый массив
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