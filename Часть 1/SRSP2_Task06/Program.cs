using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== ДНИ НЕДЕЛИ ===");

Console.Write("Введите номер дня недели (1-7): ");

if (int.TryParse(Console.ReadLine(), out int dayNumber))
{
    // Определяем день недели
    switch (dayNumber)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;

        case 2:
            Console.WriteLine("Вторник");
            break;

        case 3:
            Console.WriteLine("Среда");
            break;

        case 4:
            Console.WriteLine("Четверг");
            break;

        case 5:
            Console.WriteLine("Пятница");
            break;

        case 6:
            Console.WriteLine("Суббота");
            break;

        case 7:
            Console.WriteLine("Воскресенье");
            break;

        default:
            Console.WriteLine("Ошибка! Такого дня недели нет.");
            break;
    }
}
else
{
    Console.WriteLine("Ошибка! Введите целое число.");
}

// Не выводим тип дня для ошибочного номера.
if (dayNumber >= 1 && dayNumber <= 5)
{
    Console.WriteLine("Учебный день");
}
else if (dayNumber >= 6 && dayNumber <= 7)
{
    Console.WriteLine("Выходной день");
}
