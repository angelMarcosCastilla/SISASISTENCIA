USE  SIS_IESUP
GO

--TABLA USUARIOS	
CREATE PROCEDURE SPU_USUARIO_LISTAR_ACTIVO
AS BEGIN
	SELECT * FROM USUARIOS WHERE estado = 1
END
GO

CREATE PROCEDURE SPU_USUARIO_LISTAR
AS BEGIN
	SELECT * FROM USUARIOS
END
GO

CREATE PROCEDURE SPU_USUARIO_REGISTRAR
@idpersona			INT,
@nombreusuario		VARCHAR(50),
@claveaccesso		VARCHAR(90)
AS BEGIN
	INSERT INTO USUARIOS(idpersona, nombreusuario, claveacceso) VALUES (@idpersona, @nombreusuario, @claveaccesso)
END
GO

CREATE PROCEDURE SPU_USUARIO_EDITAR
	@nombreusuario		VARCHAR(50),
	@claveaccesso		VARCHAR(90),
	@idusuario			INT
AS BEGIN
	UPDATE USUARIOS SET
	nombreusuario = @nombreusuario,
	claveacceso = @claveaccesso
	WHERE idusuario = @idusuario
END 
GO

CREATE PROCEDURE SPU_USUARIO_ELIMINAR
	@idusuario		INT
AS BEGIN
	UPDATE USUARIOS SET estado = 0 WHERE idusuario = @idusuario
END 
GO

CREATE PROCEDURE SPU_USUARIO_ACTIVAR
	@idusuario		INT
AS BEGIN
	UPDATE USUARIOS SET estado = 1 WHERE idusuario = @idusuario
END 
GO

CREATE PROCEDURE SPU_USUARIO_BUSCAR
@idusuario		INT
AS BEGIN
	SELECT * FROM USUARIOS
	WHERE idpersona=@idusuario
END 
GO

-- tabla personas
CREATE PROCEDURE SPU_PERSONAS_LISTAR_ACTIVO
AS BEGIN
	SELECT * FROM PERSONAS WHERE estado = 1
END
GO

CREATE PROCEDURE SPU_PERSONAS_LISTAR
AS BEGIN
	SELECT * FROM PERSONAS 
END
GO

CREATE PROCEDURE SPU_PERSONAS_REGISTRAR
@apellidos			VARCHAR(50),
@nombres			VARCHAR(50),
@dni				CHAR(8),
@fechanacimineto	DATETIME,
@direccion			VARCHAR(100),
@email				VARCHAR(100),
@celular			CHAR(9),
@sexo				CHAR(1)
AS BEGIN
	INSERT INTO PERSONAS(apellidos, nombres, dni, fechanacimiento, direccion, email, celular, sexo)
	VALUES (@apellidos, @nombres, @dni, @fechanacimineto,@direccion,@email, @celular, @sexo)
END
GO

CREATE PROCEDURE SPU_PERSONA_EDITAR
	@apellidos			VARCHAR(50),
	@nombres			VARCHAR(50),
	@dni				CHAR(8),
	@fechanacimineto	DATETIME,
	@direccion			VARCHAR(100),
	@email				VARCHAR(100),
	@celular			CHAR(9),
	@idpersona			INT,
	@sexo				CHAR(1)
AS BEGIN
	UPDATE PERSONAS SET
	apellidos = @apellidos,
	nombres= @nombres,
	dni=@dni,
	fehanacimineto = @fechanacimineto,
	direccion= @direccion,
	email = @email,
	celular = @celular,
	sexo=@sexo
	WHERE idpersona = @idpersona
END 
GO

CREATE PROCEDURE SPU_PERSONA_ELIMINAR
	@idpersona		BIT
AS BEGIN
	UPDATE PERSONAS SET estado = 0 WHERE idpersona = @idpersona
END 
GO

CREATE PROCEDURE SPU_PERSONA_ACTIVAR
	@idpersona		INT
AS BEGIN
	UPDATE PERSONAS SET estado = 1 WHERE idpersona = @idpersona
END 
GO

CREATE PROCEDURE SPU_PERSONA_BUSCAR
@idpersona			INT
AS BEGIN
	SELECT * FROM PERSONAS
	WHERE idpersona=@idpersona
END 
GO

-- PSU TABLAS GRUPOS

--LISTAR
CREATE PROCEDURE SPU_LISTAR_GRUPOS
AS BEGIN
	SELECT * FROM GRUPOS
END
GO

CREATE PROCEDURE SPU_LISTAR_GRUPOS_ACTIVOS
AS BEGIN
	SELECT * FROM GRUPOS WHERE ESTADO = 1
END
GO

--REGISTRAR
CREATE PROCEDURE SPU_REGISTRAR_GRUPOS
@grado			INT,
@seccion		CHAR(1),
@turno			CHAR(1)
AS BEGIN
	INSERT INTO GRUPOS(grado, seccion, turno) VALUES (@grado, @seccion, @turno)
END
GO

--EDITAR
CREATE PROCEDURE SPU_EDITAR_GRUPOS
	@idgrupo			INT,
	@grado				INT,
	@seccion			CHAR(1),
	@turno				CHAR(1)
AS BEGIN
	UPDATE GRUPOS SET
	grado = @grado,
	seccion = @seccion,
	turno = @turno
	WHERE idgrupo = @idgrupo
END 
GO

--ELIMINAR
CREATE PROCEDURE SPU_ELIMINAR_GRUPOS
	@idgrupo		INT
AS BEGIN
	UPDATE GRUPOS SET estado = 0 WHERE idgrupo = @idgrupo
END
GO

--ACTIVAR
CREATE PROCEDURE SPU_ACTIVAR_GRUPOS
	@idgrupo		INT
AS BEGIN
	UPDATE GRUPOS SET estado = 1 WHERE idgrupo = @idgrupo
END 
GO

--BUSCAR
CREATE PROCEDURE SPU_BUSCAR_GRUPOS
@idgrupo		INT
AS BEGIN
	SELECT * FROM GRUPOS
	WHERE idgrupo = @idgrupo
END 
GO


-- PSU TABLA MOTIVOSSALIDA

--LISTAR
CREATE PROCEDURE SPU_LISTAR_MOTIVOSSALIDA
AS BEGIN
	SELECT * FROM MOTIVOSSALIDA
END
GO

--REGISTRAR
CREATE PROCEDURE SPU_REGISTRAR_MOTIVOSSALIDA
@motivosalida			VARCHAR(100)
AS BEGIN
	INSERT INTO MOTIVOSSALIDA(motivosalida) VALUES (@motivosalida)
END
GO

--EDITAR
CREATE PROCEDURE SPU_EDITAR_MOTIVOSSALIDA
	@idmotivo			INT,
	@motivosalida		VARCHAR(100)
AS BEGIN
	UPDATE MOTIVOSSALIDA SET
	motivosalida = @motivosalida
	WHERE idmotivo = @idmotivo
END 
GO

--BUSCAR
CREATE PROCEDURE SPU_BUSCAR_MOTIVOSSALIDA
@idmotivo		INT
AS BEGIN
	SELECT * FROM MOTIVOSSALIDA
	WHERE idmotivo = @idmotivo
END 
GO




-- TABLA MATRICULAS
CREATE PROCEDURE SPU_MATRICULA_LISTAR
AS BEGIN
	SELECT * FROM MATRICULAS
END
GO

CREATE PROCEDURE SPU_MATRICULA_LISTAR_ACTIVO
AS BEGIN
	SELECT * FROM MATRICULAS
	WHERE estado = 1
END
GO

CREATE PROCEDURE SPU_MATRICULA_BUSCAR
	 @idmatricula     INT
AS BEGIN
	SELECT * FROM MATRICULAS
	WHERE idmatricula = @idmatricula
END
GO

CREATE PROCEDURE SPU_MATRICULA_REGISTRAR
	@idpersona				INT,
	@idgrupo				INT,
	@fechamatricula		DATETIME
AS BEGIN
	INSERT INTO MATRICULAS(idpersona, idgrupo, fechamatricula) VALUES (@idpersona, @idgrupo, @fechamatricula)
END
GO

CREATE PROCEDURE SPU_MATRICULA_EDITAR
	@idpersona				INT,
	@idgrupo				INT,
	@fechamatricula		DATETIME,
	@idmatricula		INT
AS BEGIN
	UPDATE MATRICULAS SET idpersona = @idpersona, idgrupo = @idgrupo, fechamatricula = @fechamatricula
END
GO

CREATE PROCEDURE SPU_MATRICULA_ELIMINAR
	@idmatricula			INT
AS BEGIN
	UPDATE MATRICULAS SET  estado = 0 WHERE idmatricula = @idmatricula
END
GO

CREATE PROCEDURE SPU_MATRICULA_ACTIVAR
	@idmatricula			INT
AS BEGIN
	UPDATE MATRICULAS SET  estado = 1 WHERE idmatricula = @idmatricula
END
GO

-- TABLA ASISTENCIAS


CREATE PROCEDURE SPU_ASISTENCIA_LISTAR
AS BEGIN
	SELECT * FROM ASISTENCIAS
END 
GO

CREATE PROCEDURE SPU_ASISTENCIA_REGISTRAR_ENTRADA
	@idmatricula		INT
AS BEGIN
	INSERT INTO ASISTENCIAS(idmatricula) VALUES(@idmatricula)		
END
GO

CREATE PROCEDURE SPU_ASISTENCIA_REGISTRAR_SALIDA
	@fechahorasalida		DATETIME,
	@idusuarioautoriza		INT,
	@fechahorapermiso		DATETIME,
	@idmotivo				INT,
	@descripcion			TEXT,
	@idmatricula			INT
AS BEGIN
	UPDATE ASISTENCIAS SET
	fechahorasalida = @fechahorasalida,
	idusuarioautoriza = @idusuarioautoriza,
	fechahorapermiso = @fechahorapermiso,
	descripcion = @descripcion,
	idmotivo = @idmotivo
	WHERE idmatricula = @idmatricula
END
GO


-- sesion 
CREATE PROCEDURE SPU_USUARIO_LOGIN
@nombreusuario     VARCHAR(50)
AS BEGIN
	SELECT 
	USUARIOS.idusuario,
	USUARIOS.nombreusuario,
	USUARIOS.claveacceso,
	PERSONAS.nombres,
	PERSONAS.apellidos
	FROM USUARIOS
	INNER JOIN PERSONAS ON USUARIOS.idpersona = PERSONAS.idpersona
	WHERE USUARIOS.nombreusuario = @nombreusuario AND USUARIOS.estado = 1
END
GO

