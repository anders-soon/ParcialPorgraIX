CREATE TABLE [dbo].[Alumnos]
(
	[Id_alumnos] INT NOT NULL PRIMARY KEY,
	[Nombre] varchar(50) null,
	[Apellido] varchar(50) null,
	[Telefono] int null,
)
Go

CREATE TABLE [dbo].[Profesores]
(
	[Id_Profesor] INT NOT NULL PRIMARY KEY,
	[Nombre] varchar(50) null,
	[Apellido] varchar(50) null,
	[Telefono] int null,
	[Direccion] varchar(50)
)
Go
CREATE TABLE [dbo].[Aulas]
(
	[Id_Aulas] INT NOT NULL PRIMARY KEY,
	[Id_Asignatura] int null,
	[Capacidad] varchar(50) null,
	[Material] varchar(50) null,
)
Go
CREATE TABLE [dbo].[Titulaciones]
(
	[Id_Titulaciones] INT NOT NULL PRIMARY KEY,
	[Id_Asignatura] int null,
	[Nombre] varchar(50) null,

)
Go
CREATE TABLE [dbo].[Asignatura]
(
	[Id_Asignatura] INT NOT NULL PRIMARY KEY,
	[Id_Profesor] int null,
	[Id_alumno] int null,
	[Id_Aulas] int null,
	[Id_Titulaciones] int null,
	[Nombre] varchar(50) null,
	[Credito] int null,
	Constraint Fk_Profesor foreign key (Id_Profesor) References Profesores(Id_Profesor),	
	Constraint Fk_Alumno foreign key (Id_alumno) References Alumnos(Id_alumnos),	
	Constraint Fk_titulaciones foreign key (Id_Titulaciones) References Titulaciones(Id_Titulaciones),	
	Constraint Fk_Aulas foreign key (Id_Aulas) References Aulas(Id_Aulas),	
)
