# Задача / Task
Приложение показывает страницу с текстом вопроса, вариантами ответов и кнопкой “Далее”, для
перехода к следующему вопросу анкеты.
---
The application shows a page with the text of the question, answer options and a “Next” button to move to the next question.
to go to the next question of the questionnaire.

Нужно сделать SQL-базу и REST-апи бэкенда. Апи должно быть реализовано на
ASP.NET Core + Docker, язык C#. Данные - в базе PostgreSQL. Запуск приложения и
базы - через docker-compose файл.
---
We need to make a SQL database and a REST-api backend. The api should be implemented on
ASP.NET Core + Docker, C# language. Data - in PostgreSQL database. Launching the application and
database - via docker-compose file.

1. В базе должны присутствовать следующие сущности:

Survey - информация об анкете.

Question - вопрос анкеты.

Answer - вариант ответа на вопрос анкеты.

Interview - информация об интервью (отдельной сессии прохождения анкеты
конкретным человеком)

Result - данные ответов людей на вопросы анкеты

Подумать о том, какие поля могут быть у каждой сущности и какие связи должны быть
между ними. Какие индексы должны быть на таблицах, чтобы наша анкета работала
быстро.
---
1. The following entities must be present in the database:

Survey - information about the questionnaire.

Question - question of the questionnaire.

Answer - answer option to the questionnaire question.

Interview - information about the interview (a separate session of questionnaire passing by a particular person).
particular person)

Result - data about people's answers to the questionnaire questions.

Think about what fields each entity can have and what relations there should be between them.
between them. What indexes should be on the tables to make our questionnaire work
Fast.

2. У апи необходимо реализовать два метода:

- Получение данных вопроса для отображения на фронте (текста вопроса и
вариантов ответа)

- Сохранение результатов ответа на вопрос по кнопке “Далее”. Принимает
выбранные радиобаттоны, возвращает айди следующего вопроса.

Подумать, какие URI должны быть у этих двух методов, каким типом http запроса
канонично к ним обратиться.
---
2. Api needs to implement two methods:

- Obtaining question data to be displayed on the front end (question text and
answer options)

- Saving the results of the answer to the question using the “Next” button. Receives
Selected radiobuttons, returns the next question's idiom.

Think about what URIs these two methods should have, what type of http request
canonically address them.
