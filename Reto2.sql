create database DataBaseReto2
go

use DataBaseReto2
go

delete from libros
select * from libros
truncate table libros

drop proc sp_manteniminiento_clientes
drop proc sp_buscar_libros
drop proc sp_listar_libros
drop table libros

create table libros
(
   codigo varchar(5),
   titulo varchar(40),
   autor varchar(30),
   editorial varchar(20),
   precio decimal(5,2),
   cantidad smallint,
   primary key(codigo)
)
go



create proc sp_listar_libros
as
select * from libros order by codigo
go



create proc sp_buscar_libros
@titulo varchar(50)
as
select codigo, titulo, autor, editorial, precio, cantidad from libros where titulo like @titulo + '%'
go

create proc sp_buscar_autor
@autor varchar(40)
as
select codigo, titulo, autor, editorial, precio, cantidad from libros where autor like @autor + '%'
go

create proc sp_manteniminiento_clientes
@codigo varchar(5),
@titulo varchar(40),
@autor varchar(30),
@editorial varchar(20),
@precio int,
@cantidad smallint,
@accion varchar(50) output
as
if (@accion = 1)
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax =(select MAX(codigo) from libros)
	set @codmax = ISNULL(@codmax, 'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into libros(codigo,titulo,autor,editorial,precio,cantidad)
	values(@codnuevo,@titulo,@autor,@editorial,@precio,@cantidad)
	set @accion = 'Se generó el código: '+@codnuevo
end
else if(@accion = 2)
begin
	update libros set titulo=@titulo, autor=@autor, editorial=@editorial, precio=@precio, cantidad=@cantidad where codigo=@codigo
	set @accion = 'Se modificó el código: '+@codigo
end
else if (@accion = 3)
begin
	delete from libros where codigo=@codigo
	set @accion = 'Se borró el código: '+@codigo
end
go