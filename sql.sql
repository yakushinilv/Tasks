CREATE TABLE Category (
	id INT PRIMARY KEY,
	name NVARCHAR(255) NOT NULL
);

INSERT INTO Category 
VALUES  (1, 'ТО'),
        (2, 'Подвеска');
        
        CREATE TABLE AutoParts (id int PRIMARY KEY,name varchar(255) NOT NULL);

INSERT INTO AutoParts
VALUES  (1, 'Shell Helix 5w30'),
	(2, 'Фильтр масляный MANN'),
	(3, 'Шаровая опора LEMFOERDER'),
        (4, 'Аккумулятор');
        
        CREATE TABLE AutoPartsCategory (
	part_id  INT not null,
	category_id INT not null
);

INSERT INTO AutoPartsCategory
VALUES  (1, 1),
	(2, 1),
	(3, 2);
	
	select parts.name,cat.name
from AutoParts parts
left join AutoPartsCategory partcat on parts.id = partcat.part_id
left join Category cat on cat.id = partcat.category_id
