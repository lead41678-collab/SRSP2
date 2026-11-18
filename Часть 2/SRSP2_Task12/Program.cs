using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== РЕЖИМЫ КОМПЬЮТЕРА ===");
Console.WriteLine("1 - Режим обучения");
Console.WriteLine("2 - Режим тестирования");
Console.WriteLine("3 - Режим перерыва");
Console.WriteLine("4 - Завершение работы");
Console.Write("Выберите режим: ");
if (!int.TryParse(Console.ReadLine(), out int mode))
{
    Console.WriteLine("Ошибка! Введите целое число.");
    return;
}

// Каждому пункту меню соответствует отдельная ветвь.
switch (mode)
{
    case 1:
        Console.WriteLine("Режим обучения активирован. Можно приступать к заданиям.");
        break;
    case 2:
        Console.WriteLine("Режим тестирования активирован. Подготовьтесь к проверке знаний.");
        break;
    case 3:
        Console.WriteLine("Режим перерыва активирован. Время отдохнуть.");
        break;
    case 4:
        Console.WriteLine("Завершение работы программы.");
        break;
    default:
        Console.WriteLine("Ошибка! Неизвестный режим.");
        break;
}
