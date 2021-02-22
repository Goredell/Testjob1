IF db_id('Food') IS NULL 
    CREATE DATABASE Food
	
GO
USE Food
GO


CREATE TABLE [Продукты](
  id integer PRIMARY KEY IDENTITY(1,1),
  name varchar(255) NULL,
);

CREATE TABLE [Категории](
  id integer PRIMARY KEY IDENTITY(1,1),
  name varchar(255) NULL
);

CREATE TABLE [ПродКат](
	product_id integer	NOT NULL,
	category_id integer	NOT NULL,
	FOREIGN KEY (product_id)	REFERENCES Продукты(id),
	FOREIGN KEY (category_id)	REFERENCES Категории(id)
);

	
INSERT INTO Продукты (name)
VALUES 
	('Керамическая тарелка'),
	('Металлическая вилка'),
	('Пластиковая тарелка'),
	('Пластиковая вилка'),
	('Медицинская маска'),
	('Шприц'),
	('Валидол'),
	('Ничего')


INSERT INTO Категории (name)
VALUES 
	('Посуда'),
	('Одноразовое'),
	('Медицина')


INSERT INTO ПродКат (product_id, category_id)
VALUES 
	('1','1'),
	('2','1'),
	('3','1'),
	('3','2'),
	('4','1'),
	('4','2'),
	('5','3'),
	('5','2'),
	('6','3'),
	('6','2'),
	('7','3')

SELECT Продукты.name + ' - ' + ISNULL(Категории.name, '') as Результат
FROM Продукты
	LEFT JOIN ПродКат on Продукты.id = ПродКат.product_id
	LEFT JOIN Категории on ПродКат.category_id = Категории.id