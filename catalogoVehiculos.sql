GO
create database catalogo;

GO
use catalogo;

GO
create table fabricantes
(
	id int identity(1,1) primary key,
	nombre varchar(50) not null
)

Go
create table propietario
(
	documento int primary key,
	nombre varchar(50) not null,
	telefono varchar(20) not null
)

GO
create table vehiculos
(
	placa varchar(7) primary key,
	fabricante int foreign key references fabricantes(id),
	referencia varchar(50) not null,
	modelo int not null,
	foto varchar(20),
	precio real,
	propietario int foreign key references propietario(documento)
)

GO
insert into fabricantes 
values
('Renault'),('Mazda'),('Kia'),('Chevrolet'),('Suzuki'),
('Fiat'),('Honda'),('Ford'),('Nissan'),('Toyota');
