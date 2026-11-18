using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== ПРОВЕРКА ВИСОКОСНОГО ГОДА ===");

Console.Write("Введите год: ");

if (int.TryParse(Console.ReadLine(), out int year))
{
    if (year <= 0)
    {
        Console.WriteLine("Ошибка! Год должен быть положительным.");
    }
    else
    {
        // Проверяем условия високосного года
        bool isLeapYear =
            (year % 400 == 0) ||
            (year % 4 == 0 && year % 100 != 0);

        if (isLeapYear)
        {
            Console.WriteLine($"{year} год является високосным и содержит 366 дней");
        }
        else
        {
            Console.WriteLine($"{year} год является обычным и содержит 365 дней");
        }
    }
}
else
{
    Console.WriteLine("Ошибка! Введите целый год.");
}
