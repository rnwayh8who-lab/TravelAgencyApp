---------------------------------------------------------
-- 1. Создание базы данных
---------------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TravelAgency')
BEGIN
    CREATE DATABASE TravelAgency;
END
GO

USE TravelAgency;
GO

---------------------------------------------------------
-- 2. Создание таблицы пользователей
---------------------------------------------------------
IF OBJECT_ID('Users', 'U') IS NOT NULL
    DROP TABLE Users;
GO

CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL  -- Manager / Support / Operator
);
GO

---------------------------------------------------------
-- 3. Добавление тестовых аккаунтов
---------------------------------------------------------
INSERT INTO Users (Username, PasswordHash, Role)
VALUES
    ('manager', '12345', 'Manager'),
    ('support', '12345', 'Support'),
    ('operator', '12345', 'Operator');
GO

---------------------------------------------------------
-- Готово. Теперь можно логиниться:
-- manager / 12345
-- support / 12345
-- operator / 12345
---------------------------------------------------------
