using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== СИСТЕМА КОНТРОЛЯ ДОСТУПА ===");
Console.WriteLine("1 - Студент");
Console.WriteLine("2 - Преподаватель");
Console.WriteLine("3 - Посетитель");
Console.Write("Ваш выбор: ");
bool roleValid = int.TryParse(Console.ReadLine(), out int userRole);
Console.Write("Введите текущий час (0-23): ");
bool hourValid = int.TryParse(Console.ReadLine(), out int currentHour);
if (!roleValid || !hourValid)
{
    Console.WriteLine("Ошибка! Введите целые числа.");
    return;
}

string roleName;
int startHour;
int endHour;
// Конец каждого интервала не включается в разрешённое время.
switch (userRole)
{
    case 1:
        roleName = "Студент";
        startHour = 8;
        endHour = 18;
        break;
    case 2:
        roleName = "Преподаватель";
        startHour = 7;
        endHour = 20;
        break;
    case 3:
        roleName = "Посетитель";
        startHour = 10;
        endHour = 16;
        break;
    default:
        Console.WriteLine("Ошибка! Некорректная роль.");
        return;
}

if (currentHour < 0 || currentHour > 23)
{
    Console.WriteLine("Ошибка! Час должен быть от 0 до 23.");
    return;
}
Console.WriteLine($"Роль: {roleName}");
Console.WriteLine($"Время посещения: {currentHour:00}:00");
if (currentHour >= startHour && currentHour < endHour)
{
    Console.WriteLine("Результат: ДОСТУП РАЗРЕШЁН");
}
else
{
    Console.WriteLine("Результат: ДОСТУП ЗАПРЕЩЁН");
}
