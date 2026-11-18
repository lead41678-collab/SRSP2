using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== ПОМОЩНИК СТУДЕНТА ===");

Console.WriteLine("Выберите направление:");
Console.WriteLine("1 - Программирование");
Console.WriteLine("2 - Компьютерные сети");
Console.WriteLine("3 - Компьютерная графика");
Console.WriteLine("4 - Информационная безопасность");

Console.Write("Ваш выбор: ");
bool directionValid = int.TryParse(
    Console.ReadLine(), out int direction);

Console.Write("Введите количество баллов (0-100): ");
bool scoreValid = int.TryParse(
    Console.ReadLine(), out int score);

// Проверяем правильность ввода
if (!directionValid || !scoreValid)
{
    Console.WriteLine("Ошибка! Необходимо ввести целые числа.");
}
else if (score < 0 || score > 100)
{
    Console.WriteLine("Ошибка! Баллы должны быть от 0 до 100.");
}
else
{
    string directionName = "";

    // Определяем учебное направление
    switch (direction)
    {
        case 1:
            directionName = "Программирование";
            break;

        case 2:
            directionName = "Компьютерные сети";
            break;

        case 3:
            directionName = "Компьютерная графика";
            break;

        case 4:
            directionName = "Информационная безопасность";
            break;

        default:
            Console.WriteLine("Ошибка! Неверное направление.");
            break;
    }

    if (directionName != "")
    {
        Console.WriteLine($"\nНаправление: {directionName}");

        // Определяем уровень подготовки
        if (score >= 85)
        {
            Console.WriteLine("Высокий уровень подготовки.");
        }
        else if (score >= 50)
        {
            Console.WriteLine("Базовый уровень подготовки.");
        }
        else
        {
            Console.WriteLine("Необходимо повторить материал.");
        }
    }
}
