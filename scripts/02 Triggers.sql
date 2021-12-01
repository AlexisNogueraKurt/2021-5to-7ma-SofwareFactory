/*Antes de hacer un Insert en Tarea, si la calificación del empleado es menor a la complejidad del requerimiento no se tiene que permitir el Insert y se tiene que mostrar la leyenda “Calificación insuficiente”*/
DELIMITER $$
SELECT 'Creando Triggers' AS 'Estado'$$
CREATE TRIGGER befInsTarea BEFORE INSERT ON tarea
FOR EACH ROW
BEGIN
      IF (EXISTS(SELECT *
                FROM experiencia
                JOIN requerimiento USING (idTecnologia)
                WHERE calificacion < complejidad
                AND cuil = NEW.cuil
                AND idRequerimiento = NEW.idRequerimiento
                )) THEN
                  SIGNAL SQLSTATE '45000'
                  SET MESSAGE_TEXT = 'Calificacion Insuficiente';
	   END IF;
END $$

/*Realizar un trigger para que al ingresar un usuario, le asigne por defecto experiencia en todas las tecnologías disponibles con calificación igual*/
DELIMITER $$
CREATE TRIGGER aftInsUsuario AFTER INSERT ON empleado
FOR EACH ROW
BEGIN
     INSERT INTO experiencia (cuil,idTecnologia,calificacion)
                 SELECT NEW.cuil,idTecnologia,0
                 FROM tecnologia;
END $$