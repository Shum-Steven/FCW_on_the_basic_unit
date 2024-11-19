# Итоговая Контрольная Работа по базовому курсу
- Язык программирования: С#
- Среда разработки: .NET

## Описание проекта
Программа создает новый массив строк, содержащий только строки длинной 3 символа или меньше.

## Функциональность
- Два способа создания массива:
    1. Ручной ввод с клавиатуры
    2. Случайный выбор из предустановленных примеров

## Примеры 
- `["Hello", "2", "world", ":-)"]` → `["2", ":-)")`
- `["1234", "1567", "-2", "computer science"]` → `["-2"]`
- `["Russia", "Denmark", "Kazan"]` → `[]`

## Структура программы
### Основные методы
- `Main()` : Точка входа программы
- `CreateArray()`: Выбор способа создания массива
- `InputArray()` : Ввод массива с клавиатуры
- `PtintArray()` : Вывод массива
- `FilterArray()` : Фильтрация массива по длине строк

### Особенности реализации
- Интерактивное меню выбора
- Проверка корректности ввода
- обработка пустых и null значений
- Случайный выбор примера при использовании готового массива

## Автор
*Шумилин Степан & Клод*