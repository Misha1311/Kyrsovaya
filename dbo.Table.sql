CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Название магазина] NVARCHAR(50) NULL, 
    [Адрес магазина] NVARCHAR(50) NULL, 
    [Артикул (код товара)] INT NULL, 
    [Название товара] NVARCHAR(50) NULL, 
    [Количество] INT NULL, 
    [Цена за единицу] INT NULL, 
    [Сумма] INT NULL
)
