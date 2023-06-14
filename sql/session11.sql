use cibertec2023
go

create table curso(
idcurso int identity (1,1)not null,
nombre varchar(50)not null,
creditos int not null,
ciclo varchar(4)not null,
descripcion varchar(250) null,
constraint pk_idcur primary key (idcurso)
)
go

insert into curso values('Base de datos',5,'II','Mysql dYSMESEE 2022')
insert into curso values('POO I',5,'III','Visual Estudio Code')

drop table curso
go
select * from coodinador



create table coodinador(
idcordinador int identity(100,1)not null,
nom varchar (50) not null,
apellido varchar(50)not null,
dni char(8) not null,
genero char(1)not null,
gradoCad varchar(40) not null,
suledo money not null,
fechaNac date not null
constraint pk_idcor primary key (idcordinador)
)




insert into coodinador values('Jose Jose','Perez',48948785,'M','IV',435.12,'2012-11-23')