# MassMailer
Для работы приложения требуется:

    WebView2
    .NET Framework 4.8.1
Аутентификация в приложении только через Яндекс.Почту через пароли приложений. Если после получения пароля приложения для почтового сервиса аутентификация в MassMailer приводит к ошибке ("Неправильный логин или пароль!"), следует:
* Перейти на сайт [Яндекс.Почты](https://mail.yandex.ru) и авторизоваться
* В правом верхнем углу экрана нажать на иконку шестерёнки
* В правой верхней части всплывающего окна нажать на "Все настройки →"  → "Почтовые программы" → отметить галочку напротив "С сервера imap.yandex.ru по протоколу IMAP"
* После этого авторизация в приложении должна работать штатно

Тестовые логин и пароль находятся в виде комментария в классе SMTPBrains в методе Auth().

Из функционала реализовано:
* Авторизация
* Кнопка "Запомнить"
* Ручной ввод темы, имени отправителя, адресов получателей (для добавления получателя нужно нажать на пробел или Enter), текста письма
* Добавление списка получателей в виде CSV-таблицы (в качестве разделителя используется **табуляция**)
* Добавление файлов к письму
* Удаление файлов и получателей (для этого раскройте соответствующий комбобокс и кликните на тот элемент, что требуется удалить)
* Отлов ошибок и вывод соответствующей надписи
+ HTML-шаблоны и CSV-файлов с переменными (тестовые файлы в папке Test)
+ 3 режима работы приложения: для отправки простого текста, для отправки письма в виде статичного HTML и для отправки письма с динамическим содержимым
+ Drag'n'Drop:

    textBox_MessageText → строки, .txt и .html файлы

    textBox_Recipient, comboBox_Recipients, button_RecipientsFile → строки и .csv файлы

    textBox_Topic, textBox_FromWho → строки

    button_HTMLFile → .html файлы

    button_CSVFile → .csv файлы

    button_AttachFiles, comboBox_Files → все типы файлов
+ Быстрая очистка введённого содержимого
+ Предпросмотр добавленного HTML-файла для каждого конкретного пользователя
+ Предпросмотр добавленного CSV-файла и редактирование его содержимого
+ Возможность использования многострочных выражений в качестве переменной в CSV файле (символ перевода каретки в CSV-файле - `||`, в HTML-файле многострочная переменная должна быть заключена в тройные фигурные скобки (`{{{Example}}}`)

Исправления и изменения:
* Проект мигрировал с .NET 6.0 на .NET Framework 4.8.1
* Исправлен вылет приложения из-за некорректной загрузки шрифтов
* Улучшен внешний вид шрифтов
* Временный фикс отключения от SMTP-сервера (проблема на стороне Яндекса)