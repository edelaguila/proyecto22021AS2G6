select * from jugador;
select * from equipo;
select * from deporte;
select * from deporte;
INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Fútbol");
INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Tenis");
INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Basketball");
select * from rol;
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "Delantero", 1);
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "Delantero", 3);
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "Defensa", 1);
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "DefensaTenis", 2);
select * from rol;
select * from equipo;
select * from deporte;
INSERT INTO equipo(pkId, nombre, fkIdDeporte) VALUES (NULL, "Barcelona", "1");
INSERT INTO equipo(pkId, nombre, fkIdDeporte) VALUES (NULL, "Madrid", "1");
INSERT INTO equipo(pkId, nombre, fkIdDeporte) VALUES (NULL, "TenisSA", "2");
INSERT INTO equipo(pkId, nombre, fkIdDeporte) VALUES (NULL, "Celtics", "3");
select * from vwjugador;
select * from jugador;
INSERT INTO jugador(pkId, nombre, anotaciones, fotografia, fkIdEquipo, fkIdRol, fkIdDeporte) VALUES (NULL, "Tenis Jorge", "90", NULL, 2, 2, 1);
INSERT INTO jugador(pkId, nombre, anotaciones, fotografia, fkIdEquipo, fkIdRol, fkIdDeporte) VALUES (NULL, "Basket Jorge", "90", NULL, 2, 3,2);
INSERT INTO jugador(pkId, nombre, anotaciones, fotografia, fkIdEquipo, fkIdRol, fkIdDeporte) VALUES (NULL, "Basket Luis", "50", NULL, 2, 3,3);
select * from equipo;
select * from deporte;

/* Vista de jugador */
DROP VIEW `vwJugador`;
CREATE VIEW `vwJugador` AS
SELECT 
A.pkId AS pkIdJugador, A.nombre, A.anotaciones, 
C.pkId AS pkIdRol, C.nombre AS rol, 
B.pkId AS pkIdEquipo, B.nombre AS equipo, 
D.pkId as pkIdDeporte, D.nombre AS deporte
FROM jugador A
INNER JOIN equipo B ON B.pkId = A.fkIdEquipo
INNER JOIN rol C ON  C.pkId = A.fkIdRol
INNER JOIN deporte D ON D.pkId = A.fkIdDeporte ORDER BY pkIdJugador ASC;


select * from vwJugador;
select * from deporte;
select * from jugador;
select * from equipo;

UPDATE jugador SET nombre = ?nombre?, anotaciones = ?anotaciones?, fkIdEquipo = ?fkIdEquipo?, fkIdRol = ?fkIdRol?, fkIdDeporte = ?fkIdDeporte? WHERE pkId = ?pkId?;

select * from deporte;
DROP PROCEDURE roles;
DELIMITER //
CREATE PROCEDURE roles(IN deporte int)
BEGIN
 SELECT pkId, nombre FROM rol WHERE fkIdDeporte = deporte;

END //
DELIMITER ;
select * from rol;
SELECT pkId, nombre, fkIdDeporte FROM rol WHERE fkIdDeporte = 1;
CALL roles(1);

SELECT pkId, nombre, fkIdDeporte FROM rol WHERE fkIdDeporte = 2;
select * from jugador;
select * from equipo;
SELECT pkId, nombre, fkIdDeporte FROM equipo WHERE fkIdDeporte = 1;