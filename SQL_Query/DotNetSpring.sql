create database DotNet;

use DotNet;


select * from category;

select * from product;

desc category;

INSERT INTO category (name) VALUES
('Engine Parts'),
('Brake System'),
('Suspension'),
('Electrical Components'),
('Cooling System'),
('Transmission'),
('Fuel System'),
('Exhaust System'),
('Body Parts'),
('Lighting');



desc product;



INSERT INTO product (name, price, category_id) VALUES
-- Engine Parts (1)
('Oil Filter', 350.00, 1),
('Spark Plug', 250.00, 1),
('Timing Belt', 1200.00, 1),
('Air Filter', 450.00, 1),
('Piston Kit', 2800.00, 1),

-- Brake System (2)
('Brake Pad', 900.00, 2),
('Brake Disc', 1500.00, 2),
('Brake Caliper', 2200.00, 2),
('Brake Fluid', 300.00, 2),
('Brake Booster', 1800.00, 2),

-- Suspension (3)
('Shock Absorber', 2400.00, 3),
('Strut Mount', 800.00, 3),
('Coil Spring', 1300.00, 3),
('Control Arm', 1600.00, 3),
('Ball Joint', 700.00, 3),

-- Electrical Components (4)
('Battery', 4500.00, 4),
('Starter Motor', 3200.00, 4),
('Alternator', 3700.00, 4),
('Fuse Box', 600.00, 4),
('Ignition Coil', 950.00, 4),

-- Cooling System (5)
('Radiator', 2700.00, 5),
('Thermostat', 400.00, 5),
('Coolant Hose', 300.00, 5),
('Water Pump', 1900.00, 5),
('Cooling Fan', 1100.00, 5),

-- Transmission (6)
('Clutch Plate', 2300.00, 6),
('Gearbox', 15000.00, 6),
('Flywheel', 4200.00, 6),
('Shift Lever', 1300.00, 6),
('Transmission Fluid', 600.00, 6),

-- Fuel System (7)
('Fuel Pump', 2800.00, 7),
('Fuel Injector', 1700.00, 7),
('Fuel Tank', 5600.00, 7),
('Fuel Filter', 500.00, 7),
('Carburetor', 2500.00, 7),

-- Exhaust System (8)
('Muffler', 1800.00, 8),
('Catalytic Converter', 7200.00, 8),
('Exhaust Pipe', 1300.00, 8),
('O2 Sensor', 1000.00, 8),
('Exhaust Manifold', 2900.00, 8),

-- Body Parts (9)
('Front Bumper', 3500.00, 9),
('Rear Bumper', 3400.00, 9),
('Door Handle', 300.00, 9),
('Fender', 2200.00, 9),
('Hood', 4500.00, 9),

-- Lighting (10)
('Headlight', 3200.00, 10),
('Tail Light', 2500.00, 10),
('Fog Light', 1800.00, 10),
('Indicator Bulb', 150.00, 10),
('Interior Lamp', 600.00, 10);
