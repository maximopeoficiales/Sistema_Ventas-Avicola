/* Empleados */
create proc insertar_empleado /* listo */
@Tipo	varchar(15),
@Nombre varchar(30),
@Usuario varchar(30),
@Contrasena varchar(30)
as
if exists (select Usuario from Empleados WHERE Usuario=@Usuario)
RAISERROR ('Ya existe un usuario con ese Usuario, Por favor ingrese de nuevo',16,1)
insert into Empleados(Tipo,Nombre,Usuario,Contrasena) values (@Tipo,@Nombre,@Usuario,@Contrasena);
GO

CREATE PROC actualizar_empleado /* listo */
@cod_empleado int,
@Tipo	varchar(15),
@Nombre varchar(30),
@Usuario varchar(30),
@Contrasena varchar(30)
as
UPDATE Empleados SET Tipo=@Tipo ,Nombre=@Nombre ,Usuario=@Usuario,Contrasena=@Contrasena
WHERE cod_empleado=@cod_empleado;
GO

create proc eliminar_empleado /* listo */
@cod_empleado int
as
DELETE FROM Empleados Where cod_empleado=@cod_empleado;
GO

CREATE PROC mostrar_empleados_vendedor /* listo */
as
SELECT Cod_empleado,Tipo,Nombre,Usuario from Empleados;
GO
/* solo para el dueño */

CREATE PROC mostrar_empleados_dueno /* listo */
as
SELECT * FROM Empleados;
GO


CREATE PROC Contador_Empleados /* listo */
as
SELECT count(*) FROM Empleados;
GO

/*PROCEDIMIENTOS CLIENTES*/
create proc mostrar_clientes /* listo */
as
SELECT * FROM Cliente;
GO

CREATE PROC actualizar_clientes /* listo */
@Documento_Cliente varchar(11),
@Nombre_Cliente varchar(20),
@Telefono_Cliente varchar(9),
@Direccion_Cliente varchar(150)
as
UPDATE Cliente SET Nombre_Cliente=@Nombre_Cliente, Telefono_Cliente=@Telefono_Cliente,
Direccion_Cliente=@Direccion_Cliente WHERE Documento_Cliente=@Documento_Cliente;
GO


CREATE PROC eliminar_cliente  /* listo */
@Documento_Cliente varchar(11)
as 
DELETE FROM Cliente WHERE Documento_Cliente=@Documento_Cliente;
GO

CREATE PROC insertar_cliente /* listo */
@Documento_Cliente varchar(11),
@Nombre_Cliente varchar(150),
@Telefono_Cliente varchar(9),
@Direccion_Cliente varchar(150)
as
if exists (SELECT Documento_Cliente FROM Cliente WHERE Documento_Cliente=@Documento_Cliente)
RAISERROR ('Ya existe este cliente,Por favor ingrese un cliente nuevo',16,1)
INSERT INTO Cliente VALUES 
(@Documento_Cliente,
@Nombre_Cliente,
@Telefono_Cliente,
@Direccion_Cliente);
GO



/* Proovedores */
create proc mostrar_proveedores /* listo */
as
SELECT * FROM Proveedor;
GO

create proc mostrar_proveedores_nombres /* falta */
as
SELECT Nombre_Proveedor FROM Proveedor;
GO

CREATE PROC actualizar_proveedor /* listo */
@Cod_Proveedor varchar (20),
@Nombre_Proveedor varchar(20),
@Direccion_Proveedor varchar(150),
@Telefono_Proveedor varchar(15)
as
UPDATE Proveedor SET Nombre_Proveedor=@Nombre_Proveedor, 
Direccion_Proveedor=@Direccion_Proveedor,
Telefono_Proveedor=@Telefono_Proveedor WHERE Cod_Proveedor=@Cod_Proveedor;
GO


CREATE PROC eliminar_proveedor /* listo */
@Cod_Proveedor varchar(20) 
as 
DELETE FROM Proveedor WHERE Cod_Proveedor=@Cod_Proveedor;
GO

CREATE PROC insertar_proveedor /* listo */
@Cod_Proveedor varchar(20),
@Nombre_Proveedor varchar(20),
@Direccion_Proveedor varchar(150),
@Telefono_Proveedor varchar(15)
as
if exists (SELECT Cod_Proveedor FROM Proveedor WHERE Cod_Proveedor=@Cod_Proveedor)
RAISERROR ('Ya existe este Proveedor,Por favor ingrese un Proveedor nuevo',16,1)
INSERT INTO Proveedor VALUES 
(@Cod_Proveedor,
@Nombre_Proveedor,
@Direccion_Proveedor,
@Telefono_Proveedor);
GO

/* esto no sera un proceso almacenado solo devuelve un dato */
CREATE PROC Contador_proveedores /* listo */
as
SELECT count(*) FROM Proveedor;
GO


/* PRODUCTOS */

create proc mostrar_productos /* listo */
as
SELECT * FROM Productos;
GO


CREATE PROC actualizar_producto /* listo */
@Cod_producto varchar (20),
@Nombre_producto varchar(20),
@Precio_xkg smallmoney,
@Stock DECIMAL(6,2),
@Cod_Proveedor varchar(20)
as
UPDATE Productos SET Nombre_producto=@Nombre_producto, 
Precio_xkg=@Precio_xkg,
Stock=@Stock,
Cod_Proveedor=@Cod_Proveedor
WHERE Cod_producto=@Cod_producto;
GO



CREATE PROC eliminar_producto /* listo */
@Cod_producto varchar(20)
as 
DELETE FROM Productos WHERE Cod_producto=@Cod_producto;
GO



CREATE PROC insertar_producto /* listo */
@Cod_producto varchar(20),
@Nombre_producto varchar(20),
@Precio_xkg smallmoney,
@Stock DECIMAL(6,2),
@Cod_Proveedor varchar(20)
as
if exists (SELECT Cod_producto FROM Productos WHERE Cod_producto=@Cod_producto)
RAISERROR ('Ya existe este producto,Por favor ingrese un producto nuevo',16,1)
INSERT INTO Productos VALUES 
(@Cod_producto, 
@Nombre_producto,
@Precio_xkg,
@Stock,
@Cod_Proveedor);
GO

/* este seria la tabla */
CREATE PROC TopMenorCantidadProductos /* listo */
as
SELECT  Nombre_Producto,MIN(Stock) as Stock
FROM Productos GROUP BY Nombre_Producto,Stock;
GO
--mejor empezemos a hacer que funcione, asi vemos si estan bien las funciones o no, para conrregir de una vez xd
CREATE PROC menor_cantidad_productos_stock  --LISTO--
as
SELECT  MIN(Stock) as Stock
FROM Productos GROUP BY Nombre_Producto,Stock;
GO




CREATE PROC nombres_productos --LISTO--
as
SELECT Nombre_Producto FROM Productos;
GO

CREATE PROC buscar_xnombres_productos --LISTO--
@Nombre_producto varchar(20)
as
SELECT * FROM Productos WHERE Nombre_producto=@Nombre_producto;
GO



/* validacion de usuarios */

CREATE PROC validar_usuarios --FALTA--
@Usuario varchar(30),
@Contrasena varchar(30)
as
SELECT * FROM Empleados WHERE Usuario=@Usuario 
AND Contrasena=@Contrasena;
GO



CREATE PROC obtener_num_factura as --Listo--
SELECT Format(max(numero_facturaboleta)+1,'000000') from Documento_Venta;
GO

/* SELECT cod_empleado FROM Empleados where Usuario = 'ADMIN' */
/* obtener_cod_empleado */
/* INSERTAR documento_venta */
CREATE PROC insertar_documento_venta --LISTO--
@Tipo char(1),
@Numero_FacturaBoleta int,
@Documento_Cliente varchar(11),
@Subtotal decimal(4,2),
@IGV decimal(4,2),
@Total decimal (4,2),
@Fecha_Venta date
as 
INSERT INTO Documento_Venta
VALUES (@Tipo,@Numero_FacturaBoleta,@Documento_Cliente,@Subtotal,@IGV,@Total,@Fecha_Venta);
GO

/* insertar documento_detalle */ --LISTO--
CREATE PROC insertar_documento_detalle
@Cod_Producto varchar (20),
@Cantidad decimal(5,2),
@Precio_Venta smallmoney,
@Cod_Empleado int,
@Cod_Documento_Venta int
as
INSERT INTO Documento_Detalle VALUES (@Cod_Producto,@Cantidad,@Precio_Venta,@Cod_Empleado,@Cod_Documento_Venta);
GO

/* obtener_numeromax_documento venta */ --listo--
CREATE PROC obtener_nmax_documento_venta
as
SELECT MAX(Cod_Documento_Venta) FROM Documento_Venta;
GO

/* MOSTRAR VENTAS REGISTRADAS */ --LISTO--
CREATE PROC mostrar_ventas_registradas
as
SELECT dv.Fecha_Venta,dv.Documento_Cliente,c.Nombre_Cliente,dv.Subtotal,dv.IGV,dv.Total,dv.Fecha_Venta,dv.Tipo,dv.Numero_FacturaBoleta FROM Documento_Venta AS dv
INNER JOIN Cliente as c ON dv.Documento_Cliente = c.Documento_Cliente;
GO
/* MOSTRAR_VENTAS_REGISTRADAS_DNI*/ --LISTO--
CREATE PROC mostrar_ventas_registradas_por_dni
@Documento_Cliente varchar(11)
as
SELECT dv.Fecha_Venta,dv.Documento_Cliente,c.Nombre_Cliente,dv.Subtotal,dv.IGV,dv.Total,dv.Fecha_Venta,dv.Tipo,dv.Numero_FacturaBoleta FROM Documento_Venta AS dv
INNER JOIN Cliente as c ON dv.Documento_Cliente = c.Documento_Cliente WHERE c.Documento_Cliente LIKE '%' +@Documento_Cliente+'%';	
GO

/* buscar por rango de una sola fecha */ --LISTO--
CREATE PROC mostrar_ventas_registradas_por_una_sola_fecha
@FECHA1 VARCHAR(20)
as
set dateformat dmy;
SELECT dv.Fecha_Venta,dv.Documento_Cliente,c.Nombre_Cliente,dv.Subtotal,dv.IGV,dv.Total,dv.Tipo,dv.Numero_FacturaBoleta FROM Documento_Venta AS dv
INNER JOIN Cliente as c ON dv.Documento_Cliente = c.Documento_Cliente WHERE dv.Fecha_Venta = @FECHA1;
GO
CREATE PROC mostrar_ventas_registradas_por_una_sola_fecha_dni
@FECHA1 VARCHAR(20),
@Documento_Cliente varchar(11)
as
set dateformat dmy;
SELECT dv.Fecha_Venta,dv.Documento_Cliente,c.Nombre_Cliente,dv.Subtotal,dv.IGV,dv.Total,dv.Tipo,dv.Numero_FacturaBoleta FROM Documento_Venta AS dv
INNER JOIN Cliente as c ON dv.Documento_Cliente = c.Documento_Cliente WHERE dv.Fecha_Venta = @FECHA1 AND c.Documento_Cliente LIKE '%' +@Documento_Cliente+'%';
GO
/* buscar por rango de fecha  dateformart para ponerlo en ddmmyy*/ --LISTO--
CREATE PROC mostrar_ventas_registradas_entre_fechas
@FECHA1 VARCHAR(20),
@FECHA2 VARCHAR(20)
as
set dateformat dmy;
SELECT dv.Fecha_Venta,dv.Documento_Cliente,c.Nombre_Cliente,dv.Subtotal,dv.IGV,dv.Fecha_Venta,dv.Tipo,dv.Numero_FacturaBoleta FROM Documento_Venta AS dv
INNER JOIN Cliente as c ON dv.Documento_Cliente = c.Documento_Cliente WHERE dv.Fecha_Venta BETWEEN @FECHA1 AND @FECHA2;
GO

CREATE PROC mostrar_ventas_registradas_entre_fechas_dni
@FECHA1 VARCHAR(20),
@FECHA2 VARCHAR(20),
@Documento_Cliente varchar(11)
as
set dateformat dmy;
SELECT dv.Fecha_Venta,dv.Documento_Cliente,c.Nombre_Cliente,dv.Subtotal,dv.IGV,dv.Fecha_Venta,dv.Tipo,dv.Numero_FacturaBoleta FROM Documento_Venta AS dv
INNER JOIN Cliente as c ON dv.Documento_Cliente = c.Documento_Cliente WHERE dv.Fecha_Venta BETWEEN @FECHA1 AND @FECHA2 AND c.Documento_Cliente LIKE '%' +@Documento_Cliente+'%';
GO
 
/* Calcular ganancias */
CREATE PROC ver_ganancias
@fecha1 varchar(20)
as
set dateformat dmy
SELECT SUM(Total) FROM Documento_Venta WHERE Fecha_Venta =  @fecha1;
GO

CREATE PROC ver_ganancias_rango
@fecha1 varchar(20),
@fecha2 varchar(20)
as
set dateformat dmy
SELECT SUM(Total) FROM Documento_Venta WHERE Fecha_Venta BETWEEN @fecha1 AND @fecha2;
GO
