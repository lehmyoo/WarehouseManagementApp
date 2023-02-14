use master
GO

DROP DATABASE IF EXISTS warehouse_management_db
GO

use warehouse_management_db
GO

INSERT INTO admins (Email, Password) VALUES ('admin@admin.com', 'secret');

INSERT INTO warehouses (Name) VALUES 
('Warehouse 1'), 
('Warehouse 2'),
('Warehouse 3'); 

INSERT INTO products (Name, Description, Category, Price) VALUES 
('iPhone XR', 'Apple smartphone', 'Phones', 1399),
('Galaxy s2', 'Samsung smartphone', 'Phones', 1100),
('Microsoft surface', 'Microsoft laptops', 'Laptops', 2299),
('MX keyboard', '', 'Keyboards', 129),
('Macbook Air', 'Apple laptops', 'Laptops', 1399),
('Tesla 3', 'Tesla car', 'Cars', 45999),
('Boeing 747', '', 'Airplanes', 125000),
('Spicy X3 noodles', '', 'Food', 3.99),
('Mango mochi', '', 'Food', 4.99),
('Michelin x2', '', 'Tires', 499),
('Ferrari', '', 'Cars', 343979),
('Bugatti', '', 'Cars', 200998);

INSERT INTO warehouse_products (ProductID, WarehouseID, Quantity) VALUES 
(3, 1, 99),
(5, 1, 99),
(7, 1, 99),
(8, 1, 99),
(2, 1, 99),
(4, 1, 99),
(6, 1, 99),
(1, 2, 99),
(2, 2, 99),
(4, 2, 99),
(6, 3, 99),
(7, 3, 99),
(1, 3, 99);


INSERT INTO stores (WarehouseID, Name, Email, Password) VALUES 
(1, 'Store', 'store@store.com', 'store');


