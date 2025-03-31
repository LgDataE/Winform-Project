create database QLDOANHTHU
use QLDOANHTHU
go

--Create Tables
create table Customer (
   Id int identity (1,1) primary key,
   FirstName nvarchar(40) not null,
   LastName nvarchar(40) not null,
   City nvarchar(40) null,
   Country nvarchar(40) null,
   Phone nvarchar(20) null
)

create table Refill (
   Id int identity (1,1) primary key,
   AccountName nvarchar(40) not null,
   Money BIGINT NOT NULL,
)

create table Product (
   Id int identity (1,1) primary key ,
   FoodName nvarchar(50) not null,
   UnitPrice decimal(12,2) null default 0,
   Package nvarchar(30) null,
   Stock int not null,
   IsDiscontinued bit not null default 0,
)

create table Orders (
   Id int identity(1,1) primary key,
   OrderDate datetime not null,
   OrderNumber nvarchar(10) null,
   CustomerId int not null,
   TotalAmount decimal(12,2)null default 0,
   constraint FK_ORDER_REFERENCE_CUSTOMER foreign key (CustomerId) references Customer (Id)
)

create table OrderItem (
   Id int identity (1,1) primary key ,
   OrderId int not null,
   ProductId int not null,
   UnitPrice decimal(12,2) not null default 0,
   Quantity int not null default 1,
   constraint FK_ORDERITEM_REFERENCE_ORDER foreign key (OrderId) references Orders (Id),
   constraint FK_ORDERITEM_REFERENCE_PRODUCT foreign key (ProductId) references Product (Id)
)

--INSERT dữ liệu bảng Customer
SET IDENTITY_INSERT Customer ON
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(1,'Maria','Anders','Berlin','Germany','030-0074321')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(2,'Ana','Trujillo','México D.F.','Mexico','(5) 555-4729')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(3,'Antonio','Moreno','México D.F.','Mexico','(5) 555-3932')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(4,'Thomas','Hardy','London','UK','(171) 555-7788')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(5,'Christina','Berglund','Luleå','Sweden','0921-12 34 65')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(6,'Hanna','Moos','Mannheim','Germany','0621-08460')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(7,'Frédérique','Citeaux','Strasbourg','France','88.60.15.31')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(8,'Martín','Sommer','Madrid','Spain','(91) 555 22 82')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(9,'Laurence','Lebihan','Marseille','France','91.24.45.40')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(10,'Elizabeth','Lincoln','Tsawassen','Canada','(604) 555-4729')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(11,'Victoria','Ashworth','London','UK','(171) 555-1212')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(12,'Patricio','Simpson','Buenos Aires','Argentina','(1) 135-5555')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(13,'Francisco','Chang','México D.F.','Mexico','(5) 555-3392')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(14,'Yang','Wang','Bern','Switzerland','0452-076545')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(15,'Pedro','Afonso','Sao Paulo','Brazil','(11) 555-7647')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(16,'Elizabeth','Brown','London','UK','(171) 555-2282')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(17,'Sven','Ottlieb','Aachen','Germany','0241-039123')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(18,'Janine','Labrune','Nantes','France','40.67.88.88')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(19,'Ann','Devon','London','UK','(171) 555-0297')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(20,'Roland','Mendel','Graz','Austria','7675-3425')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(21,'Aria','Cruz','Sao Paulo','Brazil','(11) 555-9857')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(22,'Diego','Roel','Madrid','Spain','(91) 555 94 44')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(23,'Martine','Rancé','Lille','France','20.16.10.16')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(24,'Maria','Larsson','Bräcke','Sweden','0695-34 67 21')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(25,'Peter','Franken','München','Germany','089-0877310')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(26,'Carine','Schmitt','Nantes','France','40.32.21.21')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(27,'Paolo','Accorti','Torino','Italy','011-4988260')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(28,'Lino','Rodriguez','Lisboa','Portugal','(1) 354-2534')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(29,'Eduardo','Saavedra','Barcelona','Spain','(93) 203 4560')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(30,'José','Pedro Freyre','Sevilla','Spain','(95) 555 82 82')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(31,'André','Fonseca','Campinas','Brazil','(11) 555-9482')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(32,'Howard','Snyder','Eugene','USA','(503) 555-7555')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(33,'Manuel','Pereira','Caracas','Venezuela','(2) 283-2951')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(34,'Mario','Pontes','Rio de Janeiro','Brazil','(21) 555-0091')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(35,'Carlos','Hernández','San Cristóbal','Venezuela','(5) 555-1340')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(36,'Yoshi','Latimer','Elgin','USA','(503) 555-6874')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(37,'Patricia','McKenna','Cork','Ireland','2967 542')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(38,'Helen','Bennett','Cowes','UK','(198) 555-8888')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(39,'Philip','Cramer','Brandenburg','Germany','0555-09876')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(40,'Daniel','Tonini','Versailles','France','30.59.84.10')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(41,'Annette','Roulet','Toulouse','France','61.77.61.10')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(42,'Yoshi','Tannamuri','Vancouver','Canada','(604) 555-3392')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(43,'John','Steel','Walla Walla','USA','(509) 555-7969')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(44,'Renate','Messner','Frankfurt a.M.','Germany','069-0245984')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(45,'Jaime','Yorres','San Francisco','USA','(415) 555-5938')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(46,'Carlos','González','Barquisimeto','Venezuela','(9) 331-6954')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(47,'Felipe','Izquierdo','I. de Margarita','Venezuela','(8) 34-56-12')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(48,'Fran','Wilson','Portland','USA','(503) 555-9573')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(49,'Giovanni','Rovelli','Bergamo','Italy','035-640230')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(50,'Catherine','Dewey','Bruxelles','Belgium','(02) 201 24 67')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(51,'Jean','Fresnière','Montréal','Canada','(514) 555-8054')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(52,'Alexander','Feuer','Leipzig','Germany','0342-023176')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(53,'Simon','Crowther','London','UK','(171) 555-7733')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(54,'Yvonne','Moncada','Buenos Aires','Argentina','(1) 135-5333')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(55,'Rene','Phillips','Anchorage','USA','(907) 555-7584')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(56,'Henriette','Pfalzheim','Köln','Germany','0221-0644327')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(57,'Marie','Bertrand','Paris','France','(1) 42.34.22.66')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(58,'Guillermo','Fernández','México D.F.','Mexico','(5) 552-3745')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(59,'Georg','Pipps','Salzburg','Austria','6562-9722')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(60,'Isabel','de Castro','Lisboa','Portugal','(1) 356-5634')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(61,'Bernardo','Batista','Rio de Janeiro','Brazil','(21) 555-4252')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(62,'Lúcia','Carvalho','Sao Paulo','Brazil','(11) 555-1189')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(63,'Horst','Kloss','Cunewalde','Germany','0372-035188')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(64,'Sergio','Gutiérrez','Buenos Aires','Argentina','(1) 123-5555')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(65,'Paula','Wilson','Albuquerque','USA','(505) 555-5939')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(66,'Maurizio','Moroni','Reggio Emilia','Italy','0522-556721')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(67,'Janete','Limeira','Rio de Janeiro','Brazil','(21) 555-3412')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(68,'Michael','Holz','Genève','Switzerland','0897-034214')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(69,'Alejandra','Camino','Madrid','Spain','(91) 745 6200')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(70,'Jonas','Bergulfsen','Stavern','Norway','07-98 92 35')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(71,'Jose','Pavarotti','Boise','USA','(208) 555-8097')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(72,'Hari','Kumar','London','UK','(171) 555-1717')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(73,'Jytte','Petersen','Kobenhavn','Denmark','31 12 34 56')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(74,'Dominique','Perrier','Paris','France','(1) 47.55.60.10')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(75,'Art','Braunschweiger','Lander','USA','(307) 555-4680')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(76,'Pascale','Cartrain','Charleroi','Belgium','(071) 23 67 22 20')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(77,'Liz','Nixon','Portland','USA','(503) 555-3612')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(78,'Liu','Wong','Butte','USA','(406) 555-5834')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(79,'Karin','Josephs','Münster','Germany','0251-031259')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(80,'Miguel','Angel Paolino','México D.F.','Mexico','(5) 555-2933')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(81,'Anabela','Domingues','Sao Paulo','Brazil','(11) 555-2167')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(82,'Helvetius','Nagy','Kirkland','USA','(206) 555-8257')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(83,'Palle','Ibsen','Århus','Denmark','86 21 32 43')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(84,'Mary','Saveley','Lyon','France','78.32.54.86')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(85,'Paul','Henriot','Reims','France','26.47.15.10')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(86,'Rita','Müller','Stuttgart','Germany','0711-020361')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(87,'Pirkko','Koskitalo','Oulu','Finland','981-443655')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(88,'Paula','Parente','Resende','Brazil','(14) 555-8122')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(89,'Karl','Jablonski','Seattle','USA','(206) 555-4112')
INSERT INTO [Customer] ([Id],[FirstName],[LastName],[City],[Country],[Phone])VALUES(90,'Matti','Karttunen','Helsinki','Finland','90-224 8858')
SET IDENTITY_INSERT Customer OFF

SET IDENTITY_INSERT Refill ON
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (1, 'Account1', 10000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (2, 'Account2', 15000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (3, 'Account3', 15000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (4, 'Account4', 35000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (5, 'Account5', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (6, 'Account6', 15000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (7, 'Account7', 13000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (8, 'Account8', 18000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (9, 'Account9', 25000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (10, 'Account10', 30000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (11, 'Account11', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (12, 'Account12', 10000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (13, 'Account13', 40000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (14, 'Account14', 30000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (15, 'Account15', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (16, 'Account16', 30000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (17, 'Account17', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (18, 'Account18', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (19, 'Account19', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (20, 'Account20', 10000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (21, 'Account21', 10000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (22, 'Account22', 30000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (23, 'Account23', 30000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (24, 'Account24', 40000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (25, 'Account25', 40000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (26, 'Account26', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (27, 'Account27', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (28, 'Account28', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (29, 'Account29', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (30, 'Account30', 10000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (31, 'Account31', 10000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (32, 'Account32', 10000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (33, 'Account33', 30000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (34, 'Account34', 50000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (35, 'Account35', 30000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (36, 'Account36', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (37, 'Account37', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (38, 'Account38', 30000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (39, 'Account39', 10000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (40, 'Account40', 10000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (41, 'Account41', 10000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (42, 'Account42', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (43, 'Account43', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (44, 'Account44', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (45, 'Account45', 30000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (46, 'Account46', 30000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (47, 'Account47', 40000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (48, 'Account48', 50000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (49, 'Account49', 20000);
INSERT INTO Refill ([Id], [AccountName], [Money]) VALUES (50, 'Account50', 10000);
SET IDENTITY_INSERT Refill OFF
 
SET IDENTITY_INSERT Product ON
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Bánh mì', 1.00, 'Piece', 100, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Cơm sườn', 1.75, 'Plate', 110, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Cơm gà', 2.00, 'Plate', 120, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Cơm chiên', 1.75, 'Plate', 90, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Mì trứng', 1.00, 'Bowl', 200, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Mì xào trứng', 1.50, 'Plate', 150, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Mì xào bò', 2.00, 'Plate', 100, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Nui xào bò', 2.00, 'Plate', 100, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Nui xào trứng', 1.50, 'Plate', 100, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Cà phê sữa', 1.00, 'Glass', 100, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Cà phê đen', 0.75, 'Glass', 100, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Bạc xỉu', 1.00, 'Glass', 100, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Coca Cola', 0.75, 'Bottle', 200, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Pepsi', 0.75, 'Bottle', 200, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'7Up', 0.50, 'Bottle', 100, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Fanta', 0.50, 'Bottle', 150, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Sting', 0.75, 'Bottle', 150, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Rồng đỏ', 0.50, 'Bottle', 100, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'C2', 0.75, 'Bottle', 150, 0);
INSERT INTO Product (FoodName, UnitPrice, Package, Stock, IsDiscontinued) VALUES (N'Ô long', 0.75, 'Bottle', 100, 0);
SET IDENTITY_INSERT Product OFF

--Cập nhật lại dữ liệu Product	
update Product
set Stock = 5
where Stock = 150

SET IDENTITY_INSERT Orders ON
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(1,'Jul  4 2023 12:00:00:000AM',85,440.00,'542378')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(2,'Jul  5 2023 12:00:00:000AM',79,1863.40,'542379')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(3,'Jul  8 2023 12:00:00:000AM',34,1813.00,'542380')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(4,'Jul  8 2023 12:00:00:000AM',84,670.80,'542381')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(5,'Jul  9 2023 12:00:00:000AM',76,3730.00,'542382')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(6,'Jul 10 2023 12:00:00:000AM',34,1444.80,'542383')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(7,'Jul 11 2023 12:00:00:000AM',14,625.20,'542384')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(8,'Jul 12 2023 12:00:00:000AM',68,2490.50,'542385')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(9,'Jul 15 2023 12:00:00:000AM',88,517.80,'542386')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(10,'Jul 16 2023 12:00:00:000AM',35,1119.90,'542387')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(11,'Jul 17 2023 12:00:00:000AM',20,2018.60,'542388')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(12,'Jul 18 2023 12:00:00:000AM',13,100.80,'542389')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(13,'Jul 19 2023 12:00:00:000AM',56,1746.20,'542390')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(14,'Jul 19 2023 12:00:00:000AM',61,448.00,'542391')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(15,'Jul 22 2023 12:00:00:000AM',65,624.80,'542392')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(16,'Jul 23 2023 12:00:00:000AM',20,2464.80,'542393')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(17,'Jul 24 2023 12:00:00:000AM',24,724.50,'542394')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(18,'Jul 25 2023 12:00:00:000AM',7,1176.00,'542395')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(19,'Jul 26 2023 12:00:00:000AM',87,364.80,'542396')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(20,'Jul 29 2023 12:00:00:000AM',25,4031.00,'542397')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(21,'Jul 30 2023 12:00:00:000AM',33,1101.20,'542398')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(22,'Jul 31 2023 12:00:00:000AM',89,676.00,'542399')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(23,'Aug  1 2023 12:00:00:000AM',87,1376.00,'542400')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(24,'Aug  1 2023 12:00:00:000AM',75,48.00,'542401')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(25,'Aug  2 2023 12:00:00:000AM',65,1456.00,'542402')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(26,'Aug  5 2023 12:00:00:000AM',63,2142.40,'542403')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(27,'Aug  6 2023 12:00:00:000AM',85,538.60,'542404')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(28,'Aug  7 2023 12:00:00:000AM',49,307.20,'542405')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(29,'Aug  8 2023 12:00:00:000AM',80,420.00,'542406')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(30,'Aug  9 2023 12:00:00:000AM',52,1200.80,'542407')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(31,'Aug 12 2023 12:00:00:000AM',5,1488.80,'542408')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(32,'Aug 13 2023 12:00:00:000AM',44,468.00,'542409')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(33,'Aug 14 2023 12:00:00:000AM',5,613.20,'542410')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(34,'Aug 14 2023 12:00:00:000AM',69,86.50,'542411')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(35,'Aug 15 2023 12:00:00:000AM',69,155.40,'542412')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(36,'Aug 16 2023 12:00:00:000AM',46,1414.80,'542413')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(37,'Aug 19 2023 12:00:00:000AM',44,1452.00,'542414')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(38,'Aug 20 2023 12:00:00:000AM',63,2179.20,'542415')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(39,'Aug 21 2023 12:00:00:000AM',63,3016.00,'542416')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(40,'Aug 22 2023 12:00:00:000AM',67,924.00,'542417')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(41,'Aug 23 2023 12:00:00:000AM',66,89.00,'542418')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(42,'Aug 26 2023 12:00:00:000AM',11,479.40,'542419')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(43,'Aug 27 2023 12:00:00:000AM',15,2169.00,'542420')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(44,'Aug 27 2023 12:00:00:000AM',61,552.80,'542421')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(45,'Aug 28 2023 12:00:00:000AM',81,1296.00,'542422')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(46,'Aug 29 2023 12:00:00:000AM',80,848.70,'542423')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(47,'Aug 30 2023 12:00:00:000AM',65,1887.60,'542424')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(48,'Sep  2 2023 12:00:00:000AM',85,121.60,'542425')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(49,'Sep  3 2023 12:00:00:000AM',46,1050.60,'542426')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(50,'Sep  4 2023 12:00:00:000AM',7,1420.00,'542427')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(51,'Sep  5 2023 12:00:00:000AM',37,3127.00,'542428')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(52,'Sep  6 2023 12:00:00:000AM',67,349.50,'542429')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(53,'Sep  9 2023 12:00:00:000AM',49,608.00,'542430')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(54,'Sep  9 2023 12:00:00:000AM',86,755.00,'542431')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(55,'Sep 10 2023 12:00:00:000AM',76,2708.80,'542432')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(56,'Sep 11 2023 12:00:00:000AM',30,1242.00,'542433')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(57,'Sep 12 2023 12:00:00:000AM',80,954.40,'542434')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(58,'Sep 13 2023 12:00:00:000AM',55,4157.00,'542435')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(59,'Sep 16 2023 12:00:00:000AM',69,498.50,'542436')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(60,'Sep 17 2023 12:00:00:000AM',48,424.00,'542437')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(61,'Sep 18 2023 12:00:00:000AM',2,88.80,'542438')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(62,'Sep 19 2023 12:00:00:000AM',37,1762.00,'542439')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(63,'Sep 20 2023 12:00:00:000AM',77,336.00,'542440')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(64,'Sep 20 2023 12:00:00:000AM',18,268.80,'542441')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(65,'Sep 23 2023 12:00:00:000AM',86,1614.80,'542442')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(66,'Sep 24 2023 12:00:00:000AM',63,182.40,'542443')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(67,'Sep 25 2023 12:00:00:000AM',65,2327.00,'542444')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(68,'Sep 26 2023 12:00:00:000AM',38,516.80,'542445')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(69,'Sep 27 2023 12:00:00:000AM',65,2835.00,'542446')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(70,'Sep 30 2023 12:00:00:000AM',48,288.00,'542447')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(71,'Oct  1 2023 12:00:00:000AM',38,240.40,'542448')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(72,'Oct  2 2023 12:00:00:000AM',80,1191.20,'542449')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(73,'Oct  3 2023 12:00:00:000AM',87,516.00,'542450')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(74,'Oct  3 2023 12:00:00:000AM',38,144.00,'542451')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(75,'Oct  4 2023 12:00:00:000AM',58,112.00,'542452')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(76,'Oct  7 2023 12:00:00:000AM',39,164.40,'542453')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(77,'Oct  8 2023 12:00:00:000AM',71,6155.90,'542454')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(78,'Oct  9 2023 12:00:00:000AM',39,1497.00,'542455')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(79,'Oct 10 2023 12:00:00:000AM',8,982.00,'542456')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(80,'Oct 11 2023 12:00:00:000AM',24,2262.50,'542457')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(81,'Oct 14 2023 12:00:00:000AM',28,1168.00,'542458')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(82,'Oct 15 2023 12:00:00:000AM',75,4819.40,'542459')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(83,'Oct 16 2023 12:00:00:000AM',46,1940.00,'542460')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(84,'Oct 16 2023 12:00:00:000AM',9,88.50,'542461')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(85,'Oct 17 2023 12:00:00:000AM',51,2233.60,'542462')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(86,'Oct 18 2023 12:00:00:000AM',87,954.00,'542463')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(87,'Oct 21 2023 12:00:00:000AM',84,144.80,'542464')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(88,'Oct 22 2023 12:00:00:000AM',37,2545.20,'542465')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(89,'Oct 23 2023 12:00:00:000AM',60,316.80,'542466')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(90,'Oct 24 2023 12:00:00:000AM',25,2467.00,'542467')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(91,'Oct 25 2023 12:00:00:000AM',55,934.50,'542468')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(92,'Oct 28 2023 12:00:00:000AM',51,3463.20,'542469')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(93,'Oct 29 2023 12:00:00:000AM',9,2564.40,'542470')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(94,'Oct 29 2023 12:00:00:000AM',73,412.00,'542471')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(95,'Oct 30 2023 12:00:00:000AM',25,2300.80,'542472')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(96,'Oct 31 2023 12:00:00:000AM',44,1586.00,'542473')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(97,'Nov  1 2023 12:00:00:000AM',89,2856.00,'542474')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(98,'Nov  4 2023 12:00:00:000AM',63,2924.80,'542475')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(99,'Nov  5 2023 12:00:00:000AM',65,1731.20,'542476')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(100,'Nov  6 2023 12:00:00:000AM',21,928.00,'542477')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(101,'Nov  7 2023 12:00:00:000AM',86,396.00,'542478')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(102,'Nov  8 2023 12:00:00:000AM',75,141.60,'542479')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(103,'Nov 11 2023 12:00:00:000AM',41,713.40,'542480')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(104,'Nov 11 2023 12:00:00:000AM',20,5677.60,'542481')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(105,'Nov 12 2023 12:00:00:000AM',28,154.00,'542482')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(106,'Nov 13 2023 12:00:00:000AM',59,10741.60,'542483')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(107,'Nov 14 2023 12:00:00:000AM',58,568.80,'542484')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(108,'Nov 15 2023 12:00:00:000AM',4,480.00,'542485')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(109,'Nov 18 2023 12:00:00:000AM',86,1106.40,'542486')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(110,'Nov 19 2023 12:00:00:000AM',46,1360.00,'542487')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(111,'Nov 20 2023 12:00:00:000AM',41,452.00,'542488')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(112,'Nov 21 2023 12:00:00:000AM',72,3654.40,'542489')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(113,'Nov 22 2023 12:00:00:000AM',7,7390.20,'542490')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(114,'Nov 22 2023 12:00:00:000AM',63,2273.60,'542491')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(115,'Nov 25 2023 12:00:00:000AM',9,1549.60,'542492')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(116,'Nov 26 2023 12:00:00:000AM',17,447.20,'542493')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(117,'Nov 26 2023 12:00:00:000AM',19,950.00,'542494')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(118,'Nov 27 2023 12:00:00:000AM',3,403.20,'542495')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(119,'Nov 28 2023 12:00:00:000AM',29,136.00,'542496')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(120,'Nov 28 2023 12:00:00:000AM',83,834.20,'542497')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(121,'Nov 28 2023 12:00:00:000AM',20,1834.20,'542498')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(122,'Nov 28 2023 12:00:00:000AM',75,2527.20,'542499')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(123,'Nov 28 2023 12:00:00:000AM',14,1174.00,'542500')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(124,'Nov 29 2023 12:00:00:000AM',41,91.20,'542501')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(125,'Nov 29 2023 12:00:00:000AM',62,12281.20,'542502')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(126,'Nov 29 2023 12:00:00:000AM',37,1708.00,'542503')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(127,'Nov 29 2023 12:00:00:000AM',91,459.00,'542504')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(128,'Nov 29 2023 12:00:00:000AM',36,338.00,'542505')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(129,'Nov 30 2023 12:00:00:000AM',51,420.00,'542506')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(130,'Nov 30 2023 12:00:00:000AM',72,1016.00,'542507')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(131,'Nov 30 2023 12:00:00:000AM',24,103.20,'542508')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(132,'Nov 30 2023 12:00:00:000AM',61,959.20,'542509')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(133,'Nov 30 2023 12:00:00:000AM',37,1419.80,'542510')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(134,'Dec 1 2023 12:00:00:000AM',46,112.00,'542511')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(135,'Dec 1 2023 12:00:00:000AM',20,2900.00,'542512')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(136,'Dec 1 2023 12:00:00:000AM',4,899.00,'542513')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(137,'Dec 2 2023 12:00:00:000AM',5,2222.40,'542514')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(138,'Dec 2 2023 12:00:00:000AM',75,864.00,'542515')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(139,'Dec 2 2023 12:00:00:000AM',21,166.00,'542516')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(140,'Dec 2 2023 12:00:00:000AM',70,1058.40,'542517')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(141,'Dec 2 2023 12:00:00:000AM',72,1274.00,'542518')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(142,'Dec 3 2023 12:00:00:000AM',10,1832.80,'542519')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(143,'Dec 3 2023 12:00:00:000AM',20,2275.20,'542520')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(144,'Dec 3 2023 12:00:00:000AM',17,86.40,'542521')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(145,'Dec 4 2023 12:00:00:000AM',59,1440.00,'542522')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(146,'Dec 4 2023 12:00:00:000AM',71,3302.60,'542523')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(147,'Dec 4 2023 12:00:00:000AM',36,442.00,'542524')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(148,'Dec 5 2023 12:00:00:000AM',35,2333.20,'542525')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(149,'Dec 5 2023 12:00:00:000AM',25,1903.80,'542526')
INSERT INTO Orders ([Id],[OrderDate],[CustomerId],[TotalAmount],[OrderNumber])VALUES(150,'Dec 5 2023 12:00:00:000AM',60,843.20,'542527')
SET IDENTITY_INSERT Orders OFF

SET IDENTITY_INSERT [OrderItem] ON
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(1,1,11,2.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(2,1,19,1.80,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(3,1,3,3.80,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(4,2,14,1.60,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(5,2,2,2.50,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(6,3,12,1.50,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(7,3,4,2.50,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(8,3,4,1.80,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(9,4,12,1.80,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(10,4,10,1.60,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(11,4,6,1.80,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(12,5,20,2.80,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(13,5,3,2.00,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(14,5,6,2.20,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(15,6,3,2.00,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(16,6,3,1.40,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(17,6,4,1.50,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(18,7,2,3.50,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(19,7,5,1.50,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(20,7,7,2.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(21,8,2,1.20,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(22,8,16,1.90,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(23,8,6,1.20,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(24,8,9,4.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(25,9,5,2.20,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(26,9,7,1.40,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(27,10,2,3.00,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(28,10,3,1.40,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(29,10,7,1.40,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(30,11,2,1.20,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(31,11,5,1.50,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(32,11,3,2.50,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(33,12,2,2.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(34,12,3,2.80,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(35,13,4,1.70,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(36,13,5,1.60,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(37,13,6,2.40,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(38,13,7,2.00,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(39,14,2,2.00,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(40,14,3,1.40,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(41,15,5,1.50,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(42,15,7,2.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(43,15,15,3.40,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(44,16,16,1.90,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(45,16,12,2.60,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(46,16,17,2.70,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(47,16,7,2.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(48,17,2,1.20,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(49,17,19,2.70,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(50,18,17,3.20,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(51,18,7,2.00,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(52,19,12,3.40,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(53,20,13,1.70,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(54,20,11,2.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(55,20,7,1.40,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(56,21,9,2.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(57,21,7,2.80,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(58,22,3,2.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(59,22,7,2.80,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(60,23,3,1.20,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(61,23,4,3.80,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(62,24,3,2.00,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(63,25,20,64.80,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(64,25,11,1.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(65,25,7,2.80,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(66,26,10,2.80,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(67,26,14,1.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(68,26,3,2.00,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(69,26,4,1.70,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(70,26,7,1.40,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(71,27,7,1.20,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(72,27,7,2.80,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(73,28,19,3.60,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(74,28,5,4.00,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(75,29,10,2.80,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(76,29,13,4.80,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(77,30,18,3.40,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(78,30,9,3.40,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(79,31,4,1.50,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(80,31,5,4.00,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(81,31,6,3.10,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(82,31,7,1.00,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(83,32,17,3.20,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(84,33,18,3.60,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(85,33,5,1.20,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(86,33,7,2.20,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(87,34,19,1.30,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(88,34,2,1.60,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(89,34,3,1.40,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(90,35,3,2.70,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(91,35,5,1.60,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(92,36,15,1.40,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(93,36,19,2.30,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(94,36,6,2.20,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(95,36,7,2.80,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(96,37,20,3.10,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(97,37,4,1.50,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(98,37,6,2.20,2)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(99,37,6,1.20,1)
INSERT INTO [OrderItem] ([Id],[OrderId],[ProductId],[UnitPrice],[Quantity])VALUES(100,38,1,1.40,1)
SET IDENTITY_INSERT [OrderItem] OFF

select* from [OrderItem]

UPDATE [OrderItem]
SET ProductId = CAST(RAND() * 20 + 1 AS INT)

UPDATE Orders
SET [TotalAmount] = ROUND(RAND() * (7 - 1.5) + 1.5, 2)  -- Tạo giá trị ngẫu nhiên dưới 7 và lớn hơn 1.5 với 2 chữ số thập phân
WHERE [TotalAmount] >= 7;