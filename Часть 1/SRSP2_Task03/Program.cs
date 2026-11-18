using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== СРАВНЕНИЕ РЕЗУЛЬТАТОВ ===");

Console.Write("Баллы первого студента: ");
bool firstValid = int.TryParse(
    Console.ReadLine(), out int firstScore);

Console.Write("Баллы второго студента: ");
bool secondValid = int.TryParse(
    Console.ReadLine(), out int secondScore);

// Проверяем правильность введённых данных
if (!firstValid || !secondValid)
{
    Console.WriteLine("Ошибка! Введите целые числа.");
}
else if (firstScore < 0 || firstScore > 100 ||
         secondScore < 0 || secondScore > 100)
{
    Console.WriteLine("Ошибка! Баллы должны быть от 0 до 100.");
}
else
{
    Console.WriteLine($"Разница между результатами: {Math.Abs(firstScore - secondScore)}");

    // Сравниваем результаты
    if (firstScore > secondScore)
    {
        Console.WriteLine("Первый студент набрал больше баллов.");
    }
    else if (firstScore < secondScore)
    {
        Console.WriteLine("Второй студент набрал больше баллов.");
    }
    else
    {
        Console.WriteLine("Результаты равны.");
    }
}
