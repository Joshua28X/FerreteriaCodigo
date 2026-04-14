create database Ferreteria

use FERRETODO;

create table categorias(
idcategoria int primary key,
nombre varchar(50),
);

create table proveedores(
idproveedor int primary key,
nombreEmpkresa varchar(100),
);

create table productos(
idproducto varchar(20) primary key,
nombre varchar(100),
idcategoria int 
foreign key (idcategoria) references categorias(idcategoria),
idproveedor int 
foreign key (idproveedor) references proveedores(idproveedor),
);

create table usuarios(
id_usuario int primary key,
usuarionombre varchar(30),
rol varchar(20),
);

create table ventas(
id_venta int primary key,
fecha datetime,
id_usuario int
foreign key (id_usuario) references usuarios(id_usuario),
);

create table Detalle_Ventas(
id_venta int
foreign key (id_venta) references ventas(id_venta),
idproducto varchar(20)
foreign key (idproducto) references productos(idproducto),
);


ALTER TABLE Productos 
ADD precio DECIMAL(10,2),
stock INT;

ALTER TABLE Proveedores 
ADD telefono VARCHAR(15);

ALTER TABLE Ventas 
ADD total DECIMAL(10,2);

ALTER TABLE Detalle_Ventas 
ADD id_detalle INT IDENTITY(1,1);

ALTER TABLE Detalle_Ventas
ADD CONSTRAINT PK_Detalle_Ventas PRIMARY KEY (id_detalle);

ALTER TABLE Detalle_Ventas 
ADD total DECIMAL(10,2);

alter table Detalle_Ventas
drop column total;

alter table Detalle_Ventas
add cantidad int;