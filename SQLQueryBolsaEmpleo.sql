--Crear la base de datos
CREATE DATABASE BolsaDeEmpleo;
go

--Usar la base de datos
USE BolsaDeEmpleo;
go

--Crear las tablas
CREATE TABLE Empresas( --tabla Empresas
	Id INT PRIMARY KEY NOT NULL, --EntityFramework no trabaja con autoincremento
	Cod_Empresa INT NOT NULL,
	Nombre NVARCHAR(100) NOT NULL,
	Direccion NVARCHAR(100)
);
go

CREATE TABLE Personas( --Tabla Personas
	Id INT PRIMARY KEY NOT NULL,
	Cedula NVARCHAR(10) NOT NULL,
	Nombre NVARCHAR(100) NOT NULL,
	Direccion NVARCHAR(100)
);
go

CREATE TABLE Estudios( --Tabla Estudios
	Id INT PRIMARY KEY NOT NULL,
	Cod_Estudio INT NOT NULL,
	Nombre NVARCHAR(100) NOT NULL
);
go

CREATE TABLE Cargos( --Tabla Cargos
	Id INT PRIMARY KEY NOT NULL,
	Nombre NVARCHAR(100) NOT NULL
);
go

CREATE TABLE Personas_Estudios( --Tabla relacion Personas_Estudios
	Id INT PRIMARY KEY NOT NULL,
	Persona_Id INT NOT NULL,
	Estudio_Id INT NOT NULL,

	FOREIGN KEY (Persona_Id) REFERENCES Personas(Id),
	FOREIGN KEY (Estudio_Id) REFERENCES Estudios(Id)
);
go

CREATE TABLE Cargos_Estudios( --Tabla relacion Cargos_Estudios
	Id INT PRIMARY KEY NOT NULL,
	Cargo_Id INT NOT NULL,
	Estudio_Id INT NOT NULL,

	FOREIGN KEY (Cargo_Id) REFERENCES Cargos(Id),
	FOREIGN KEY (Estudio_Id) REFERENCES Estudios(Id)
);
go

--TABLAS SIN CREAR POR DUDAS
CREATE TABLE Vacantes( --Incomplete
	Id INT PRIMARY KEY NOT NULL,
	Empresa_Id INT NOT NULL,
	Cargo_Id INT NOT NULL,
	Disponibilidad BIT NOT NULL,
	Postulacion_Id INT NOT NULL --En c# tenemos lista de postulaciones
	--Entonces eso significa que Vacantes hereda de Postulaciones?

	FOREIGN KEY (Postulacion_Id) REFERENCES Postulaciones(Id)
)

CREATE TABLE Postulaciones( --Incompleta
	Id INT PRIMARY KEY NOT NULL,
	Vacante_Id INT NOT NULL,
	Persona_Id INT NOT NULL,
	Elegido BIT NOT NULL,
	
	FOREIGN KEY (Vacante_Id) REFERENCES Vacantes(Id),
	FOREIGN KEY (Persona_Id) REFERENCES Personas(Id)
)


