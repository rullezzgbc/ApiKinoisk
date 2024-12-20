# Интернет-магазин для продажи и аренды цифрового медиаконтента

## 1. Название продукта
**Digital Media Store API** — RESTful API для управления цифровым медиаконтентом.

---

## 2. Введение или краткое описание
Digital Media Store API — это RESTful API, разработанное на платформе ASP.NET Core, которое позволяет управлять цифровым медиаконтентом, таким как фильмы, сериалы, музыкальные видео и другие медиаформаты. API предоставляет возможности для создания, чтения, обновления и удаления (CRUD) данных о пользователях, контенте, покупках и арендах.

Этот проект предназначен для разработчиков, которые хотят создать интернет-магазин или платформу для продажи и аренды цифрового медиаконтента.

---

## 3. Необходимые условия для использования продукта
Для использования проекта необходимо иметь следующие знания и инструменты:

1. **ASP.NET Core**: Для разработки и запуска веб-приложения.
2. **Entity Framework Core**: Для работы с базой данных.
3. **MS SQL Server**: Для хранения данных.
4. **Visual Studio или Visual Studio Code**: Для разработки и отладки.
5. **Postman или аналогичный инструмент**: Для тестирования API.
6. **Базовые знания C#**: Для понимания кода.
7. **Базовые знания RESTful API**: Для работы с API.

---

## 4. Как установить программу

### Шаг 1: Установка .NET SDK
1. Скачайте и установите .NET SDK с официального сайта: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
2. Убедитесь, что .NET SDK установлен, выполнив команду:
   ```bash
   dotnet --version
   ```

### Шаг 2: Клонирование репозитория
1. Клонируйте репозиторий с GitHub:
   ```bash
   git clone https://github.com/ваш-репозиторий/digital-media-store.git
   ```
2. Перейдите в папку проекта:
   ```bash
   cd digital-media-store
   ```

### Шаг 3: Настройка базы данных
1. Откройте файл `appsettings.json` и настройте строку подключения к вашей базе данных:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=ваш-сервер;Database=DigitalMediaStore;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```
2. Выполните миграции для создания базы данных:
   ```bash
   dotnet ef database update
   ```

### Шаг 4: Запуск проекта
1. Запустите проект с помощью команды:
   ```bash
   dotnet run
   ```
2. Откройте браузер и перейдите по адресу `http://localhost:5000/swagger` для просмотра документации API через Swagger.

---

## 5. Порядок использования

### Регистрация и авторизация
1. Отправьте POST-запрос на `/api/User` для создания нового пользователя:
   ```json
   {
       "email": "user@example.com",
       "passwordHash": "hashedPassword",
       "fullName": "John Doe",
       "registrationDate": "2023-10-01T00:00:00Z"
   }
   ```
2. Используйте GET-запрос на `/api/User/{id}` для получения данных пользователя.

### Управление контентом
1. Отправьте POST-запрос на `/api/Content` для добавления нового контента:
   ```json
   {
       "title": "Example Movie",
       "description": "A great movie",
       "type": "Movie",
       "duration": 120,
       "releaseDate": "2023-01-01",
       "price": 9.99,
       "rentalPrice": 4.99,
       "rentalDuration": 7
   }
   ```
2. Используйте GET-запрос на `/api/Content` для получения списка всего контента.

### Покупка и аренда
1. Отправьте POST-запрос на `/api/Purchases` для покупки контента:
   ```json
   {
       "userId": 1,
       "contentId": 1,
       "price": 9.99
   }
   ```
2. Отправьте POST-запрос на `/api/Rentals` для аренды контента:
   ```json
   {
       "userId": 1,
       "contentId": 2,
       "rentalEndDate": "2023-10-10",
       "rentalPrice": 4.99
   }
   ```

### Примеры запросов
- Получение всех пользователей:
  ```bash
  GET /api/User
  ```
- Получение всего контента:
  ```bash
  GET /api/Content
  ```
- Удаление пользователя:
  ```bash
  DELETE /api/User/1
  ```

### Дополнительная документация
Подробная документация по API доступна через Swagger по адресу `http://localhost:5000/swagger`.

---

## 6. Ссылки
- [Документация по ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-7.0)
- [Документация по Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [Репозиторий проекта на GitHub](#) (укажите ссылку на ваш репозиторий).
