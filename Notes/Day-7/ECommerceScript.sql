use infowayecommercedb;
/*INSERT INTO Categories(CategoryName,Description) VALUES
('Boot','Genuine Leather'),
('Casual','Running Shoe'),
('Casual','Casual Soft Leather'),
('Casual','Party Ware Leather'),
('Casual','Fashion ware'),
('Sneakers','Anywhere wear product'),
('Sports','Football Sports Shoes');
*/

INSERT INTO Products(CategoryId,BrandId,ProductName,Description,UnitPrice,ManufacturingDate,MadeIn,Gender,WarrantyPeriod,ReturnPolicy,ProductQuantity,Discount,Picture) VALUES
(1,1,'Bata','Genuine Leather',4200,'2023-01-05','India','Male','1 year','14 days',452,10,'~/Images/bata_b_m_1.jpg'),
(1,2,'Campus','Genuine Leather',1599,'2023-01-05','India','Male','3 months','7 days',73,5,'~/Images/campus_b_m_1.jpg'),
(1,3,'Woodland','Genuine Leather',4599,'2023-01-05','India','Male','1 year','14 days',547,10,'~/Images/woodland_b_m_1.jpeg'),
(1,3,'Woodland','Genuine Leather',2399,'2023-01-05','India','Male','6 months','7 days',78,5,'~/Images/woodland_b_m_2.jpg'),
(2,4,'Puma','Genuine Leather',1200,'2023-01-05','India','Male','6 months','14 days',54,5,'~/Images/puma_c_m_1.jpg'),
(3,1,'Bata','Genuine Leather',1199,'2023-01-05','India','Male','2 months','7 days',97,5,'~/Images/bata_c_m_1.jpeg'),
(4,1,'Bata','Genuine Leather',1899,'2023-01-05','India','Male','3 months','7 days',78,10,'~/Images/bata_c_m_2.jpeg'),
(5,2,'Campus','Genuine Leather',1599,'2023-01-05','India','Male','1 months','7 days',567,5,'~/Images/campus_c_m_1.jpeg'),
(6,2,'Campus','Genuine Leather',999,'2023-01-05','India','Male','0 months','7 days',453,5,'~/Images/campus_l_m_2.jpg'),
(6,5,'Nike','Genuine Leather',1599,'2023-01-05','India','Male','1 months','7 days',789,5,'~/Images/nikp_l_m_1.jpg'),
(6,5,'Nike','Genuine Leather',2099,'2023-01-05','India','Male','1 months','7 days',665,5,'~/Images/nikp_l_m_2.jpg'),
(6,5,'Nike','Genuine Leather',1599,'2023-01-05','India','Male','3 months','14 days',478,10,'~/Images/nikp_l_m_3.jpg'),
(7,6,'Adidas','Genuine Leather',4599,'2023-01-05','India','Male','6 Months','14 Days',465,5,'~/Images/adidas_soc_m_1.jpeg'),
(7,5,'Nike','Genuine Leather',3499,'2023-01-05','India','Male','3 Months','7 days',546,5,'~/Images/nikp_soc_m_1.jpeg'),
(7,4,'Puma','Genuine Leather',3455,'2023-01-05','India','Male','1 months','7 days',75,5,'~/Images/puma_soc_m_1.jpeg'),
(7,4,'Puma','Genuine Leather',2999,'2023-01-05','India','Male','1 months','7 days',75,5,'~/Images/puma_soc_m_2.png');