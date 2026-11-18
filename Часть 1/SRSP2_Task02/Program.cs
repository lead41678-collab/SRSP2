using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== ЭЛЕКТРОННЫЙ ЖУРНАЛ ===");

Console.Write("Введите баллы студента (0-100): ");

if (int.TryParse(Console.ReadLine(), out int score))
{
    // Проверяем допустимость введённых баллов
    if (score < 0 || score > 100)
    {
        Console.WriteLine("Ошибка! Баллы должны быть от 0 до 100.");
    }
    else if (score >= 90)
    {
        Console.WriteLine("Результат: Отлично");
    }
    else if (score >= 75)
    {
        Console.WriteLine("Результат: Хорошо");
    }
    else if (score >= 50)
    {
        Console.WriteLine("Результат: Удовлетворительно");
    }
    else
    {
        Console.WriteLine("Результат: Неудовлетворительно");
    }
}
else
{
    Console.WriteLine("Ошибка! Введите целое число.");
    return;
}

// Аттестацию оцениваем только при допустимом количестве баллов.
if (score >= 0 && score <= 100)
{
    if (score >= 50)
    {
        Console.WriteLine("Аттестация пройдена");
    }
    else
    {
        Console.WriteLine("Аттестация не пройдена");
    }
}
