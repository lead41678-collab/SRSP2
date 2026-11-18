using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== ОПРЕДЕЛЕНИЕ ВРЕМЕНИ ГОДА ===");

Console.Write("Введите номер месяца (1-12): ");

if (int.TryParse(Console.ReadLine(), out int month))
{
    // Определяем время года
    switch (month)
    {
        case 12:
        case 1:
        case 2:
            Console.WriteLine("Время года: Зима");
            Console.WriteLine("Время снега и морозов");
            break;

        case 3:
        case 4:
        case 5:
            Console.WriteLine("Время года: Весна");
            Console.WriteLine("Природа просыпается");
            break;

        case 6:
        case 7:
        case 8:
            Console.WriteLine("Время года: Лето");
            Console.WriteLine("Время солнечных дней");
            break;

        case 9:
        case 10:
        case 11:
            Console.WriteLine("Время года: Осень");
            Console.WriteLine("Начинается новый учебный год");
            break;

        default:
            Console.WriteLine("Ошибка! Такого месяца не существует.");
            break;
    }
}
else
{
    Console.WriteLine("Ошибка! Введите целое число.");
}
