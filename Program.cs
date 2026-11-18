using System;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

// После выполнения задания возвращаемся к выбору. 0 завершает программу.
while (true)
{
    Console.WriteLine("\n=== СРСП № 2 ===");
    Console.WriteLine("--- Часть 1 ---");
    Console.WriteLine("1 - Определение знака числа");
    Console.WriteLine("2 - Электронный помощник преподавателя");
    Console.WriteLine("3 - Сравнение результатов студентов");
    Console.WriteLine("4 - Определение времени суток");
    Console.WriteLine("5 - Проверка високосного года");
    Console.WriteLine("6 - Определение дня недели");
    Console.WriteLine("7 - Определение времени года");
    Console.WriteLine("8 - Симулятор управления файлами");
    Console.WriteLine("9 - Выбор учебного направления");
    Console.WriteLine("10 - Диагностика оборудования");
    Console.WriteLine("--- Часть 2 ---");
    Console.WriteLine("11 - Допуск к экзамену");
    Console.WriteLine("12 - Режимы компьютера");
    Console.WriteLine("13 - Свободные компьютеры");
    Console.WriteLine("14 - IT-викторина");
    Console.WriteLine("15 - Контроль доступа");
    Console.WriteLine("0 - Выход");
    Console.Write("Выберите задание (1-15): ");
    string? input = Console.ReadLine();
    // Закрытый поток ввода также завершает программу, без бесконечного цикла.
    if (input is null || input.Trim() == "0")
    {
        break;
    }
    if (!int.TryParse(input, out int taskNumber))
    {
        Console.WriteLine("Ошибка! Введите целый номер задания.");
        continue;
    }

    switch (taskNumber)
    {
        case 1:
            Task01();
            break;
        case 2:
            Task02();
            break;
        case 3:
            Task03();
            break;
        case 4:
            Task04();
            break;
        case 5:
            Task05();
            break;
        case 6:
            Task06();
            break;
        case 7:
            Task07();
            break;
        case 8:
            Task08();
            break;
        case 9:
            Task09();
            break;
        case 10:
            Task10();
            break;
        case 11:
            Task11();
            break;
        case 12:
            Task12();
            break;
        case 13:
            Task13();
            break;
        case 14:
            Task14();
            break;
        case 15:
            Task15();
            break;
        default:
            Console.WriteLine("Ошибка! Номер задания должен быть от 1 до 15.");
            break;
    }
}

#region Часть 1 — задания 1–10

// Задание 1. Определение знака числа
static void Task01()
{
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
}

// Задание 2. Электронный помощник преподавателя
static void Task02()
{
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
}

// Задание 3. Сравнение результатов студентов
static void Task03()
{
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
}

// Задание 4. Определение времени суток
static void Task04()
{
    Console.WriteLine("=== ОПРЕДЕЛЕНИЕ ВРЕМЕНИ СУТОК ===");

    Console.Write("Введите текущий час (0-23): ");

    if (int.TryParse(Console.ReadLine(), out int hour))
    {
        if (hour < 0 || hour > 23)
        {
            Console.WriteLine("Ошибка! Час должен быть от 0 до 23.");
        }
        else if (hour >= 0 && hour < 6)
        {
            Console.WriteLine("Сейчас ночь.");
            Console.WriteLine("Пора отдыхать!");
        }
        else if (hour >= 6 && hour < 12)
        {
            Console.WriteLine("Сейчас утро.");
            Console.WriteLine("Доброе утро!");
        }
        else if (hour >= 12 && hour < 18)
        {
            Console.WriteLine("Сейчас день.");
            Console.WriteLine("Хорошего дня!");
        }
        else
        {
            Console.WriteLine("Сейчас вечер.");
            Console.WriteLine("Добрый вечер!");
        }
    }
    else
    {
        Console.WriteLine("Ошибка! Введите целый час.");
    }

    // Дополнительный интервал учебного времени, включая обе границы.
    if (hour >= 8 && hour <= 16)
    {
        Console.WriteLine("Учебное время");
    }
}

// Задание 5. Проверка високосного года
static void Task05()
{
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
}

// Задание 6. Определение дня недели
static void Task06()
{
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
}

// Задание 7. Определение времени года
static void Task07()
{
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
}

// Задание 8. Симулятор управления файлами
static void Task08()
{
    Console.WriteLine("=== ФАЙЛОВЫЙ МЕНЕДЖЕР ===");

    Console.WriteLine("Доступные команды:");
    Console.WriteLine("создать - создание файла");
    Console.WriteLine("открыть - открытие файла");
    Console.WriteLine("удалить - удаление файла");
    Console.WriteLine("переименовать - переименование файла");
    Console.WriteLine("выход - завершение работы");

    Console.Write("\nВведите команду: ");

    // Получаем и обрабатываем текст пользователя
    string command = (Console.ReadLine() ?? "").Trim().ToLower();

    // Определяем выбранную команду
    switch (command)
    {
        case "создать":
            Console.WriteLine("Команда принята.");
            Console.WriteLine("Файл успешно создан (имитация).");
            break;

        case "открыть":
            Console.WriteLine("Команда принята.");
            Console.WriteLine("Файл открыт (имитация).");
            break;

        case "удалить":
            Console.WriteLine("Команда принята.");
            Console.WriteLine("Файл удалён (имитация).");
            break;

        case "выход":
            Console.WriteLine("Завершение работы программы.");
            break;

        case "переименовать":
            Console.WriteLine("Файл переименован (имитация).");
            break;

        default:
            Console.WriteLine("Ошибка! Неизвестная команда.");
            break;
    }
}

// Задание 9. Выбор учебного направления
static void Task09()
{
    Console.WriteLine("=== ПОМОЩНИК СТУДЕНТА ===");

    Console.WriteLine("Выберите направление:");
    Console.WriteLine("1 - Программирование");
    Console.WriteLine("2 - Компьютерные сети");
    Console.WriteLine("3 - Компьютерная графика");
    Console.WriteLine("4 - Информационная безопасность");

    Console.Write("Ваш выбор: ");
    bool directionValid = int.TryParse(
        Console.ReadLine(), out int direction);

    Console.Write("Введите количество баллов (0-100): ");
    bool scoreValid = int.TryParse(
        Console.ReadLine(), out int score);

    // Проверяем правильность ввода
    if (!directionValid || !scoreValid)
    {
        Console.WriteLine("Ошибка! Необходимо ввести целые числа.");
    }
    else if (score < 0 || score > 100)
    {
        Console.WriteLine("Ошибка! Баллы должны быть от 0 до 100.");
    }
    else
    {
        string directionName = "";

        // Определяем учебное направление
        switch (direction)
        {
            case 1:
                directionName = "Программирование";
                break;

            case 2:
                directionName = "Компьютерные сети";
                break;

            case 3:
                directionName = "Компьютерная графика";
                break;

            case 4:
                directionName = "Информационная безопасность";
                break;

            default:
                Console.WriteLine("Ошибка! Неверное направление.");
                break;
        }

        if (directionName != "")
        {
            Console.WriteLine($"\nНаправление: {directionName}");

            // Определяем уровень подготовки
            if (score >= 85)
            {
                Console.WriteLine("Высокий уровень подготовки.");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Базовый уровень подготовки.");
            }
            else
            {
                Console.WriteLine("Необходимо повторить материал.");
            }
        }
    }
}

// Задание 10. Диагностика оборудования
static void Task10()
{
    Console.WriteLine("=== ДИАГНОСТИКА ОБОРУДОВАНИЯ ===");

    Console.WriteLine("Выберите устройство:");
    Console.WriteLine("1 - Монитор");
    Console.WriteLine("2 - Сетевое подключение");
    Console.WriteLine("3 - Клавиатура");
    Console.WriteLine("4 - Принтер");

    Console.Write("Номер устройства: ");
    bool deviceValid = int.TryParse(
        Console.ReadLine(), out int device);

    Console.WriteLine("\nУкажите состояние:");
    Console.WriteLine("1 - Не работает");
    Console.WriteLine("2 - Работает исправно");

    Console.Write("Состояние: ");
    bool statusValid = int.TryParse(
        Console.ReadLine(), out int status);

    // Проверка введённых данных
    if (!deviceValid || !statusValid)
    {
        Console.WriteLine("Ошибка! Введите целые числа.");
    }
    else if (status != 1 && status != 2)
    {
        Console.WriteLine("Ошибка! Неверное состояние.");
    }
    else
    {
        string deviceName = "";
        string advice = "";

        // Определяем устройство и рекомендацию
        switch (device)
        {
            case 1:
                deviceName = "Монитор";
                advice = "Проверьте питание и видеокабель.";
                break;

            case 2:
                deviceName = "Сетевое подключение";
                advice = "Проверьте сетевой кабель или Wi-Fi.";
                break;

            case 3:
                deviceName = "Клавиатура";
                advice = "Проверьте подключение клавиатуры.";
                break;

            case 4:
                deviceName = "Принтер";
                advice = "Проверьте подключение принтера, бумагу и состояние печати.";
                break;

            default:
                Console.WriteLine("Ошибка! Неизвестное устройство.");
                break;
        }

        if (deviceName != "")
        {
            Console.WriteLine($"\nУстройство: {deviceName}");

            // Проверяем состояние устройства
            if (status == 1)
            {
                Console.WriteLine("Состояние: Не работает");
                Console.WriteLine($"Рекомендация: {advice}");
            }
            else
            {
                Console.WriteLine("Состояние: Исправно");
                Console.WriteLine("Дополнительные действия не требуются.");
            }
        }
    }
}

#endregion

#region Часть 2 — задания 11–15

// Задание 11. Допуск к экзамену
static void Task11()
{
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
}

// Задание 12. Режимы компьютера
static void Task12()
{
    Console.WriteLine("=== РЕЖИМЫ КОМПЬЮТЕРА ===");
    Console.WriteLine("1 - Режим обучения");
    Console.WriteLine("2 - Режим тестирования");
    Console.WriteLine("3 - Режим перерыва");
    Console.WriteLine("4 - Завершение работы");
    Console.Write("Выберите режим: ");
    if (!int.TryParse(Console.ReadLine(), out int mode))
    {
        Console.WriteLine("Ошибка! Введите целое число.");
        return;
    }

    // Каждому пункту меню соответствует отдельная ветвь.
    switch (mode)
    {
        case 1:
            Console.WriteLine("Режим обучения активирован. Можно приступать к заданиям.");
            break;
        case 2:
            Console.WriteLine("Режим тестирования активирован. Подготовьтесь к проверке знаний.");
            break;
        case 3:
            Console.WriteLine("Режим перерыва активирован. Время отдохнуть.");
            break;
        case 4:
            Console.WriteLine("Завершение работы программы.");
            break;
        default:
            Console.WriteLine("Ошибка! Неизвестный режим.");
            break;
    }
}

// Задание 13. Свободные компьютеры
static void Task13()
{
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
}

// Задание 14. IT-викторина
static void Task14()
{
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
}

// Задание 15. Контроль доступа
static void Task15()
{
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
}

#endregion
