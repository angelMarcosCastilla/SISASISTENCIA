
CREATE DATABASE SIS_IESUP
GO
USE SIS_IESUP
GO

CREATE TABLE GRUPOS
(
	idgrupo					INT IDENTITY(1,1) PRIMARY KEY,
	grado					INT				NOT NULL,
	seccion					CHAR(1)			NOT NULL,
	turno					CHAR(1)			NOT NULL,  -- T(tarde) M(mañana)
	estado					BIT NOT NULL DEFAULT 1,

	CONSTRAINT ck_turno_gru CHECK(turno IN ('T', 'M'))
)
GO

CREATE TABLE MOTIVOSSALIDA
(
	idmotivo				INT IDENTITY(1,1) PRIMARY KEY,
	motivosalida			VARCHAR(100)	NOT NULL
)
GO



CREATE TABLE PERSONAS(
		idpersona			INT IDENTITY(1,1) PRIMARY KEY,
		apellidos			VARCHAR(50) NOT NULL,
		nombres				VARCHAR(50) NOT NULL,
		dni					CHAR(8) NOT NULL,
		fechanacimiento		DATETIME NOT NULL,
		direccion			VARCHAR(100) NOT NULL,
		email				VARCHAR(100) NOT NULL,
		celular				CHAR(9) NOT NULL,
		sexo				CHAR(1) NOT NULL,
		estado				BIT NOT NULL DEFAULT 1,

		CONSTRAINT	uk_dni_per	UNIQUE (dni),
		CONSTRAINT	uk_email_per	UNIQUE (email),
		CONSTRAINT ck_celular_per	CHECK (celular LIKE('[9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
		CONSTRAINT ck_sexo_per	CHECK (sexo IN ('M', 'F'))
)

CREATE TABLE USUARIOS(
		idusuario			INT IDENTITY(1,1) PRIMARY KEY,
		idpersona			INT NOT NULL,
		nombreusuario		VARCHAR(50) NOT NULL,
		claveacceso			VARCHAR(90) NOT NULL,
		fecharegistro		DATE NOT NULL	DEFAULT GETDATE(),
		estado				BIT NOT NULL DEFAULT 1,

		CONSTRAINT uk_idpersona_usu UNIQUE (idpersona),
		CONSTRAINT fk_idpersona_usu	FOREIGN KEY (idpersona)	REFERENCES PERSONAS(idpersona)
)

CREATE TABLE MATRICULAS
(
	idmatricula				INT IDENTITY(1,1) PRIMARY KEY,
	idpersona				INT			NOT NULL,
	idgrupo					INT			NOT NULL,
	fechamatricula			DATETIME	NOT NULL DEFAULT GETDATE(),

	CONSTRAINT fk_idpersona_Tmatricula	FOREIGN KEY (idpersona) REFERENCES PERSONAS(idpersona),
	CONSTRAINT fk_idgrupo_Tmatricula	FOREIGN KEY (idgrupo)	REFERENCES GRUPOS(idgrupo)

)
GO
CREATE TABLE ASISTENCIAS
(
	idasistencia			INT IDENTITY(1,1) PRIMARY KEY,
	idmatricula				INT			NOT NULL,
	fechahoraentrada		DATETIME	NOT NULL DEFAULT GETDATE(),
	fechahorasalida			DATETIME	NULL,
	idusuarioautoriza		INT			NULL,
	fechahorapermiso		DATETIME	NULL,
	idmotivo				INT			NULL,
	descripcion				VARCHAR(400)		NULL,

	CONSTRAINT fk_idmatricula_Tasistencias FOREIGN KEY (idmatricula) REFERENCES MATRICULAS(idmatricula),
	CONSTRAINT fk_idusuarioaut_Tasistencias FOREIGN KEY(idusuarioautoriza) REFERENCES USUARIOS(idusuario),
	CONSTRAINT fk_idmotivo_Tasistencias	FOREIGN KEY (idmotivo) REFERENCES MOTIVOSSALIDA(idmotivo)
)
GO




