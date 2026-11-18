using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== КОНТРОЛЬ КОМПЬЮТЕРНОГО КАБИНЕТА ===");
Console.Write("Всего компьютеров: ");
bool totalValid = int.TryParse(Console.ReadLine(), out int totalComputers);
Console.Write("Занято компьютеров: ");
bool occupiedValid = int.TryParse(Console.ReadLine(), out int occupiedComputers);

if (!totalValid || !occupiedValid)
{
    Console.WriteLine("Ошибка! Введите целые числа.");
}
else if (totalComputers <= 0 || occupiedComputers < 0 || occupiedComputers > totalComputers)
{
    Console.WriteLine("Ошибка! Всего должно быть больше нуля, занято - от 0 до общего количества.");
}
else
{
    // Вычитаем только после проверки, чтобы получить допустимое количество.
    int freeComputers = totalComputers - occupiedComputers;
    Console.WriteLine($"Свободных компьютеров: {freeComputers}");
    if (freeComputers == 0)
    {
        Console.WriteLine("Результат: Все компьютеры заняты.");
    }
    else if (freeComputers <= 3)
    {
        Console.WriteLine("Результат: Свободных компьютеров мало.");
    }
    else
    {
        Console.WriteLine("Результат: В кабинете достаточно свободных компьютеров.");
    }
}
