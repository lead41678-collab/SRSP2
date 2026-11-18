using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== ОПРЕДЕЛЕНИЕ ВРЕМЕНИ СУТОК ===");

Console.Write("Введите текущий час (0-23): ");

if (int.TryParse(Console.ReadLine(), out int hour))
{
    if (hour < 0 || hour > 23)
    {
        Console.WriteLine("Ошибка! Час должен быть от 0 до 23.");
    }
    else if (hour >= 0 && hour < 6)
    {
        Console.WriteLine("Сейчас ночь.");
        Console.WriteLine("Пора отдыхать!");
    }
    else if (hour >= 6 && hour < 12)
    {
        Console.WriteLine("Сейчас утро.");
        Console.WriteLine("Доброе утро!");
    }
    else if (hour >= 12 && hour < 18)
    {
        Console.WriteLine("Сейчас день.");
        Console.WriteLine("Хорошего дня!");
    }
    else
    {
        Console.WriteLine("Сейчас вечер.");
        Console.WriteLine("Добрый вечер!");
    }
}
else
{
    Console.WriteLine("Ошибка! Введите целый час.");
}

// Дополнительный интервал учебного времени, включая обе границы.
if (hour >= 8 && hour <= 16)
{
    Console.WriteLine("Учебное время");
}
