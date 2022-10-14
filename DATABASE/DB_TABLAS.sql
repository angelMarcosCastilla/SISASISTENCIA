CREATE DATABASE SIS_IESUP
USE SIS_IESUP

CREATE TABLE GRUPOS
(
	idgrupo		INT IDENTITY(1,1) PRIMARY KEY,
	grado		INT				NOT NULL,
	seccion		CHAR(1)			NOT NULL,
	turno		CHAR(1)			NOT NULL  -- T(tarde) M(mañana)
	CONSTRAINT ck_turno_gru CHECK(turno IN ('T', 'M'))
)
GO

CREATE TABLE MOTIVOSSALIDA
(
	idmotivo		INT IDENTITY(1,1) PRIMARY KEY,
	motivosalida	VARCHAR(100)	NOT NULL
)
GO


CREATE TABLE PERSONAS(
		idpersona			INT IDENTITY(1,1) PRIMARY KEY,
		apellidos			VARCHAR(50) NOT NULL,
		nombres				VARCHAR(50) NOT NULL,
		dni					CHAR(8) NOT NULL,
		fehanacimineto		DATETIME NOT NULL,
		direccion			VARCHAR(100) NOT NULL,
		email				VARCHAR(100) NOT NULL,
		celular				CHAR(9) NOT NULL,

		CONSTRAINT	uk_dni_per	UNIQUE (dni),
		CONSTRAINT	uk_email_per	UNIQUE (email),
		CONSTRAINT ck_celular_per	CHECK (celular LIKE('[9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
)

CREATE TABLE USUARIOS(
		idusuario			INT IDENTITY(1,1) PRIMARY KEY,
		idpersona			INT NOT NULL,
		nombreusuario		VARCHAR(50) NOT NULL,
		claveacceso			VARCHAR(50) NOT NULL,
		fecharegistro		DATE NOT NULL,
		estado				BIT NOT NULL DEFAULT 1,

		CONSTRAINT fk_idpersona	FOREIGN KEY (idpersona)	REFERENCES PERSONAS(idpersona)
)

CREATE TABLE MATRICULAS
(
	idmatricula		INT IDENTITY(1,1) PRIMARY KEY,
	idpersona		INT			NOT NULL,
	idgrupo			INT			NOT NULL,
	fechamatricula	DATETIME	NOT NULL DEFAULT GETDATE(),

	CONSTRAINT fk_idpersona_Tmatricula	FOREIGN KEY (idpersona) REFERENCES PERSONAS(idpersona),
	CONSTRAINT fk_idgrupo_Tmatricula	FOREIGN KEY (idgrupo)	REFERENCES GRUPOS(idgrupo)

)
GO
CREATE TABLE ASISTENCIAS
(
	idasistencia		INT IDENTITY(1,1) PRIMARY KEY,
	idmatricula			INT			NOT NULL,
	fechahoraentrada	DATETIME	NOT NULL DEFAULT GETDATE(),
	fechahorasalida		DATETIME	NULL,
	idusuarioautoriza	INT			NOT NULL,
	fechahorapermiso	DATETIME	NULL,
	idmotivo			INT			NOT NULL,
	descripcion			TEXT		NULL,

	CONSTRAINT fk_idmatricula_Tasistencias FOREIGN KEY (idmatricula) REFERENCES MATRICULAS(idmatricula),
	CONSTRAINT fk_idusuarioaut_Tasistencias FOREIGN KEY(idusuarioautoriza) REFERENCES USUARIOS(idusuarioautoriza),
	CONSTRAINT fk_idmotivo_Tasistencias	FOREIGN KEY (idmotivo) REFERENCES MOTIVOSALIDA(idmotivo)
)
GO

