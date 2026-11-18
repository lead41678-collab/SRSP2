using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== ДИАГНОСТИКА ОБОРУДОВАНИЯ ===");

Console.WriteLine("Выберите устройство:");
Console.WriteLine("1 - Монитор");
Console.WriteLine("2 - Сетевое подключение");
Console.WriteLine("3 - Клавиатура");
Console.WriteLine("4 - Принтер");

Console.Write("Номер устройства: ");
bool deviceValid = int.TryParse(
    Console.ReadLine(), out int device);

Console.WriteLine("\nУкажите состояние:");
Console.WriteLine("1 - Не работает");
Console.WriteLine("2 - Работает исправно");

Console.Write("Состояние: ");
bool statusValid = int.TryParse(
    Console.ReadLine(), out int status);

// Проверка введённых данных
if (!deviceValid || !statusValid)
{
    Console.WriteLine("Ошибка! Введите целые числа.");
}
else if (status != 1 && status != 2)
{
    Console.WriteLine("Ошибка! Неверное состояние.");
}
else
{
    string deviceName = "";
    string advice = "";

    // Определяем устройство и рекомендацию
    switch (device)
    {
        case 1:
            deviceName = "Монитор";
            advice = "Проверьте питание и видеокабель.";
            break;

        case 2:
            deviceName = "Сетевое подключение";
            advice = "Проверьте сетевой кабель или Wi-Fi.";
            break;

        case 3:
            deviceName = "Клавиатура";
            advice = "Проверьте подключение клавиатуры.";
            break;

        case 4:
            deviceName = "Принтер";
            advice = "Проверьте подключение принтера, бумагу и состояние печати.";
            break;

        default:
            Console.WriteLine("Ошибка! Неизвестное устройство.");
            break;
    }

    if (deviceName != "")
    {
        Console.WriteLine($"\nУстройство: {deviceName}");

        // Проверяем состояние устройства
        if (status == 1)
        {
            Console.WriteLine("Состояние: Не работает");
            Console.WriteLine($"Рекомендация: {advice}");
        }
        else
        {
            Console.WriteLine("Состояние: Исправно");
            Console.WriteLine("Дополнительные действия не требуются.");
        }
    }
}
