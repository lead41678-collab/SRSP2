using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== ФАЙЛОВЫЙ МЕНЕДЖЕР ===");

Console.WriteLine("Доступные команды:");
Console.WriteLine("создать - создание файла");
Console.WriteLine("открыть - открытие файла");
Console.WriteLine("удалить - удаление файла");
Console.WriteLine("переименовать - переименование файла");
Console.WriteLine("выход - завершение работы");

Console.Write("\nВведите команду: ");

// Получаем и обрабатываем текст пользователя
string command = (Console.ReadLine() ?? "").Trim().ToLower();

// Определяем выбранную команду
switch (command)
{
    case "создать":
        Console.WriteLine("Команда принята.");
        Console.WriteLine("Файл успешно создан (имитация).");
        break;

    case "открыть":
        Console.WriteLine("Команда принята.");
        Console.WriteLine("Файл открыт (имитация).");
        break;

    case "удалить":
        Console.WriteLine("Команда принята.");
        Console.WriteLine("Файл удалён (имитация).");
        break;

    case "выход":
        Console.WriteLine("Завершение работы программы.");
        break;

    case "переименовать":
        Console.WriteLine("Файл переименован (имитация).");
        break;

    default:
        Console.WriteLine("Ошибка! Неизвестная команда.");
        break;
}
