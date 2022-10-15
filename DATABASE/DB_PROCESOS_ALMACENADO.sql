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
@claveaccesso		VARCHAR(50)
AS BEGIN
	INSERT INTO USUARIOS(idpersona, nombreusuario, claveacceso) VALUES (@idpersona, @nombreusuario, @claveaccesso)
END
GO

CREATE PROCEDURE SPU_USUARIO_EDITAR
	@nombreusuario		VARCHAR(50),
	@claveaccesso		VARCHAR(50),
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
@celular			CHAR(9)
AS BEGIN
	INSERT INTO PERSONAS(apellidos, nombres, dni, fehanacimineto, direccion, email, celular) VALUES (@apellidos, @nombres, @dni, @fechanacimineto,@direccion,@email, @celular)
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
	@idpersona			INT
AS BEGIN
	UPDATE PERSONAS SET
	apellidos = @apellidos,
	nombres= @nombres,
	dni=@dni,
	fehanacimineto = @fechanacimineto,
	direccion= @direccion,
	email = @email,
	celular = @celular
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

