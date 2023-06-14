create database BDViajes
go

create table pais(
idpais int primary key not null,
nombre varchar(50)
)
go

create table pasajero(
idpasajero int primary key not null,
nombre varchar(20) not null,
apaterno varchar(20) not null,
amaterno varchar(20) not null,
tipo_documento varchar(20) not null,
num_documento char(15) not null,
fecha_nacimiento date not null,
idpais int not null,
telefono varchar(10) not null,
email varchar(50)not null,

FOREIGN KEY (idpais) REFERENCES pais(idpais)
)
go

//////////////////////////

INSERT INTO pais (idpais, nombre)
VALUES 
(1, 'Estados Unidos'),
(2, 'Canadá'),
(3, 'México'),
(4, 'España'),
(5, 'Francia'),
(6, 'Italia');

INSERT INTO pasajero (idpasajero, nombre, apaterno, amaterno, tipo_documento, num_documento, fecha_nacimiento, idpais, telefono, email)
VALUES (1, 'Juan', 'González', 'Pérez', 'DNI', '12345678', '1990-05-15', 1, '987654321', 'juan@example.com'),
       (2, 'María', 'López', 'Martínez', 'Pasaporte', 'AB123456', '1985-09-20', 3, '123456789', 'maria@example.com'),
       (3, 'Carlos', 'Rodríguez', 'Gómez', 'Cédula', '56789012', '1992-11-30', 2, '789456123', 'carlos@example.com'),
       (4, 'Laura', 'Fernández', 'Sánchez', 'DNI', '87654321', '1988-07-10', 3, '654987321', 'laura@example.com'),
       (5, 'Pedro', 'Ramírez', 'García', 'Pasaporte', 'CD987654', '1995-03-25', 4, '321654987', 'pedro@example.com');



	   /////////////////////

create or alter procedure ListarPasajeros
AS
BEGIN
    SELECT P.idpasajero, P.nombre, P.apaterno, P.amaterno, P.tipo_documento, P.num_documento, P.fecha_nacimiento,
           PS.nombre AS nombre_pais, P.telefono, P.email
    FROM pasajero P
    INNER JOIN pais PS ON P.idpais = PS.idpais;
END

EXEC ListarPasajeros;
go

create or alter procedure ConsultarPasajerosPorEmailInicial
    @inicialEmail VARCHAR(1)
AS
BEGIN
    SELECT P.idpasajero, P.nombre, P.apaterno, P.amaterno, P.tipo_documento, P.num_documento, P.fecha_nacimiento,
           pa.nombre AS nombre_pais, P.telefono, P.email
    FROM pasajero P 
	INNER JOIN pais pa ON p.idpais = pa.idpais
    WHERE p.email LIKE @inicialEmail + '%'
END

EXEC ConsultarPasajerosPorEmailInicial 'pe';


