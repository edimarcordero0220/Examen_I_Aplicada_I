use Cliente;


create table Cliente(
	ClienteId int identity(1,1) primary key,
	Nombre varchar(20),
	FechaNacimiento varchar (10),
	LimiteCredito varchar (15)

);

use Cliente;

SELECT * FROM Usuario;