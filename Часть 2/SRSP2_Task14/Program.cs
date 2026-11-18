using System;
using System.Text;

// Кириллица корректно отображается в консоли и при перенаправлении ввода.
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== IT-ВИКТОРИНА ===");
Console.WriteLine("1 - Сетевое оборудование");
Console.WriteLine("2 - Комплектующие компьютера");
Console.WriteLine("3 - Сетевые протоколы");
Console.Write("Выберите категорию: ");
if (!int.TryParse(Console.ReadLine(), out int category))
{
    Console.WriteLine("Ошибка! Введите целое число.");
    return;
}

// Выбираем один вопрос и запоминаем правильную букву.
string correctAnswer;
switch (category)
{
    case 1:
        Console.WriteLine("Какое устройство соединяет разные компьютерные сети?");
        Console.WriteLine("А - Коммутатор; Б - Маршрутизатор; В - Монитор");
        correctAnswer = "Б";
        break;
    case 2:
        Console.WriteLine("Как называется оперативная память компьютера?");
        Console.WriteLine("А - SSD; Б - HDD; В - RAM");
        correctAnswer = "В";
        break;
    case 3:
        Console.WriteLine("Какой протокол автоматически назначает IP-адреса?");
        Console.WriteLine("А - DHCP; Б - HTTP; В - FTP");
        correctAnswer = "А";
        break;
    default:
        Console.WriteLine("Ошибка! Несуществующая категория.");
        return;
}

Console.Write("Ваш ответ (русская буква А, Б или В): ");
string answer = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();
// Отличаем неизвестный вариант от неправильного ответа на вопрос.
if (answer != "А" && answer != "Б" && answer != "В")
{
    Console.WriteLine("Ошибка! Введите русскую букву А, Б или В.");
}
else if (answer == correctAnswer)
{
    Console.WriteLine("Правильный ответ!");
}
else
{
    Console.WriteLine($"Неправильный ответ. Правильный ответ: {correctAnswer}.");
}
