using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== ДОПУСК К ЭКЗАМЕНУ ===");
Console.Write("Введите баллы за тестирование (0-100): ");
bool scoreValid = int.TryParse(Console.ReadLine(), out int score);
Console.Write("Количество выполненных работ (0-5): ");
bool worksValid = int.TryParse(Console.ReadLine(), out int completedWorks);

// Сначала проверяем ввод и диапазоны, затем учебные требования.
if (!scoreValid || !worksValid)
{
    Console.WriteLine("Ошибка! Введите целые числа.");
}
else if (score < 0 || score > 100 || completedWorks < 0 || completedWorks > 5)
{
    Console.WriteLine("Ошибка! Баллы должны быть от 0 до 100, работы - от 0 до 5.");
}
else if (score >= 60 && completedWorks >= 4)
{
    Console.WriteLine("Результат: Допущен к экзамену.");
}
else if (score < 60 && completedWorks >= 4)
{
    Console.WriteLine("Результат: Улучшить результат тестирования.");
}
else if (score >= 60 && completedWorks < 4)
{
    Console.WriteLine("Результат: Завершить практические работы.");
}
else
{
    Console.WriteLine("Результат: Улучшить тест и завершить работы.");
}
