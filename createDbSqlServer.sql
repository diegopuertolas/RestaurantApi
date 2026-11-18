CREATE DATABASE RestauranteDB;

SELECT name, database_id, create_date 
FROM sys.databases 
WHERE name = 'RestauranteDB';

USE RestauranteDB;

CREATE TABLE PlatoPrincipal (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL CHECK (Precio >= 0),
    Ingredientes NVARCHAR(MAX) NOT NULL
);

CREATE TABLE Bebidas (
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL CHECK (Precio >= 0),
    EsAlcoholica BIT NOT NULL
);

INSERT INTO PlatoPrincipal (Nombre, Precio, Ingredientes)
VALUES 
('Plato combinado', 12.50, 'Pollo, patatas, tomate'),
('Plato vegetariano', 10.00, 'Tofu, verduras, arroz');

INSERT INTO Bebidas (Nombre, Precio, EsAlcoholica)
VALUES 
('Cocacola', 2.00, 0),
('1/3 Ambar', 1.80, 1)

SELECT * FROM PlatoPrincipal;

SELECT * 
FROM PlatoPrincipal
WHERE Ingredientes LIKE '%Tofu%';

SELECT * 
FROM PlatoPrincipal
ORDER BY Precio ASC;

SELECT DISTINCT Nombre, Precio FROM PlatoPrincipal;
