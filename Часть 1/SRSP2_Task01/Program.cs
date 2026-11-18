using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

// Заголовок программы
Console.WriteLine("=== ПРОВЕРКА ЧИСЛА ===");

// Запрашиваем число у пользователя
Console.Write("Введите целое число: ");

if (int.TryParse(Console.ReadLine(), out int number))
{
    // Проверяем введённое число
    if (number > 0)
    {
        Console.WriteLine($"Число {number} является положительным");
    }
    else if (number < 0)
    {
        Console.WriteLine($"Число {number} является отрицательным");
    }
    else
    {
        Console.WriteLine($"Вы ввели ноль: {number}");
    }
}
else
{
    Console.WriteLine("Ошибка! Необходимо ввести целое число.");
}
