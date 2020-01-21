create database BD_Avicola2 go
use BD_Avicola2 go
---------------------------
create table Empleados(
Cod_Empleado int identity,
Tipo varchar(15) ,
Nombre varchar(30),
Usuario varchar (30),
Contrasena varchar(30),
primary key (Cod_Empleado)); 
go

insert into Empleados (Tipo,Nombre,Usuario,Contrasena) values('Vendedor','Nick Apaza Borja','napaza','borjaven14')
insert into Empleados (Tipo,Nombre,Usuario,Contrasena) values('Vendedor','Marcos Alanya Pacheco','malanya','pachechoalan12')
insert into Empleados (Tipo,Nombre,Usuario,Contrasena) values('Dueno','Cirila Carbajal Bernaola','admin','admin')
go
----------------------------
create table Proveedor(
Cod_Proveedor varchar (20), constraint pk_prov primary key (Cod_Proveedor),
Nombre_Proveedor varchar (30),
Direccion_Proveedor varchar (150),
Telefono_Proveedor varchar(15));
go

insert into Proveedor values ('PROVSANF','San Fernando','Av. Jos� Charriarse 496. zona A (Alt. Cdra.15 de Av. San Juan','962389550')
insert into Proveedor values ('PROVREDO','Redondos','Calle General Borgo�o 250 Miraflores 15074','016307000')
go
----------------------------
create table Productos(
Cod_Producto varchar (20), constraint pk_prod primary key (Cod_Producto),
Nombre_Producto varchar (20),
Precio_xkg smallmoney,
Stock DECIMAL(6,2),
Cod_Proveedor varchar (20), constraint fk_prov foreign key (Cod_Proveedor)references Proveedor (Cod_Proveedor));
GO

insert into Productos values ('PR111', 'Pollo', 6.50,0, 'PROVSANF');
insert into Productos values ('PR112', 'Huevo', 2.50,0, 'PROVREDO');
insert into Productos values ('PR113', 'Pavita', 6.50,0, 'PROVREDO');
insert into Productos values ('PR114','Gallina',5.00,0, 'PROVREDO');
insert into Productos values ('PR115','Pato',6.50,0, 'PROVSANF');
insert into Productos values ('PR116','Pavo',8.00,0, 'PROVSANF');
go
----------------------------
create table Cliente(
Documento_Cliente varchar(11), constraint pk_docli primary key (Documento_Cliente),
Nombre_Cliente varchar(20),
Telefono_Cliente varchar(9),
Direccion_Cliente varchar(150));
insert into Cliente values (09833302, 'Alan Baez', '927414044', 'Jiron Castrovirreyna 846');
insert into Cliente values (15151640, 'Martin Valdez', '950412570', 'Av Progreso 540');
go
----------------------------
create table Documento_Venta(
Cod_Documento_Venta int identity, constraint pk_docven primary key (Cod_Documento_Venta),
Tipo char(1),
Numero_FacturaBoleta int,
Documento_Cliente varchar (11), constraint fk_docli foreign key (Documento_Cliente) references Cliente (Documento_Cliente),
Subtotal decimal (4,2),
IGV decimal (4,2),
Total decimal (5,2),
Fecha_Venta date);
go

insert into Documento_Venta values ( 'B', 24, 09833302, 15, 1.6, 20.3, '02/01/2019');
insert into Documento_Venta values ( 'F', 21, 15151640, 13, 0.2, 30.2, '05/01/2019');
go
----------------------------
create table Documento_Detalle(
Cod_Documento_Detalle int identity, constraint pk_coddetal primary key (Cod_Documento_Detalle),
Cod_Producto varchar (20), constraint fk_produc foreign key (Cod_Producto) references Productos (Cod_Producto),
Cantidad decimal(5,2),
Precio_Venta smallmoney,
Cod_Empleado int, constraint fk_codemp foreign key(Cod_Empleado)references Empleados(Cod_Empleado),
Cod_Documento_Venta int, constraint fk_docven foreign key (Cod_Documento_Venta) references Documento_Venta (Cod_Documento_Venta));
go
insert into Documento_Detalle values ('PR111', 5.2, 12.2, 1, 1)
insert into Documento_Detalle values ('PR113', 5.2, 12.2, 1, 1)
insert into Documento_Detalle values ('PR114', 2.2, 12.2, 3,2)
insert into Documento_Detalle values ('PR116', 4.2, 15.2, 3,2)
go
