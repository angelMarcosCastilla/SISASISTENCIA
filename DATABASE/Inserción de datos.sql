--INSERTANDO DATOS 

exec SPU_REGISTRAR_GRUPOS 1, 'A','T'
exec SPU_REGISTRAR_GRUPOS 1, 'B','M'
exec SPU_REGISTRAR_GRUPOS 1, 'C','T'
exec SPU_REGISTRAR_GRUPOS 1, 'D','M'
exec SPU_REGISTRAR_GRUPOS 1, 'E','T'

EXEC SPU_LISTAR_GRUPOS

EXEC SPU_EDITAR_GRUPOS 1, 1, 'A', 'M'
EXEC SPU_EDITAR_GRUPOS 3, 1, 'C', 'M'
EXEC SPU_EDITAR_GRUPOS 4, 1, 'D', 'T'


-- insertar personas

EXEC SPU_PERSONAS_REGISTRAR 'MARCOS CASTILLA', 'ANGEL JOEL', '73963911', '15-05-2000', 'CALLE SAN JUAN - GROCIO PRADO', 'angelmarcoscastilla15@gmaul.com','924463095', 'M'
EXEC SPU_PERSONAS_REGISTRAR 'MEDINA LLANOS', 'LUCIO', '27381823', '15-07-2000', 'CALLE SAN LUIS ', 'lucio@gmail.com','923463095', 'M'
EXEC SPU_PERSONAS_LISTAR

-- insertar usuario
EXEC SPU_USUARIO_REGISTRAR 2 ,'lucio','1234'
EXEC SPU_USUARIO_LISTAR

-- insertar