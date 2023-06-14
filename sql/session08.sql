use cibertec2023
go
select * from docente
go

--crear un sp consultar estudiante por apellido
create or alter procedure usp_consultar_estudiante
@ape varchar(45)
as
begin
	select * from estudiante
	where apellido = @ape
end
go

exec usp_consultar_estudiante 'aaaaa'
go


--crear sp para listar todos los estudiantes 
create or alter procedure usp_listar_estudiante
as
begin
	select * from estudiante
	order by apellido asc
end
go

exec usp_listar_estudiante 
go

//////////////////////////////////////////////

create or alter procedure usp_consultar_docente
@dni char(8)
as
begin
	select * from docente
	where dni = @dni
end
go

exec usp_consultar_docente '1122'
go

--------------------------

create or alter procedure usp_listar_docente
as
begin
	select * from docente
	order by nom asc
end
go

exec usp_listar_docente
go

select * from docente
go
