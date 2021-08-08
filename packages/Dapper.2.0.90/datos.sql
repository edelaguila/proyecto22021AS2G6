INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Fútbol");
INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Tenis");
INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Basketball");
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "Delantero", 1);
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "Delantero", 3);
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "Defensa", 1);
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "DefensaTenis", 2);
INSERT INTO equipo(pkId, nombre, fkIdDeporte) VALUES (NULL, "Barcelona", 1);
INSERT INTO equipo(pkId, nombre, fkIdDeporte) VALUES (NULL, "Madrid", 1);
INSERT INTO equipo(pkId, nombre, fkIdDeporte) VALUES (NULL, "TenisSA", 2);
INSERT INTO entrenador(pkId, nombre, fkIdEquipo) VALUES (NULL, "Jorge González", 1);
INSERT INTO entrenador(pkId, nombre, fkIdEquipo) VALUES (NULL, "Luis Herrera", 2);
INSERT INTO entrenador(pkId, nombre, fkIdEquipo) VALUES (NULL, "Hernando Perez", 3);
INSERT INTO tipocampeonato(pkId, tipo) VALUES (NULL, "TcT");
INSERT INTO tipocampeonato(pkId, tipo) VALUES (NULL, "Eliminatorias");
INSERT INTO jugador(pkId, nombre, anotaciones, fotografia, fkIdEquipo, fkIdRol) VALUES (NULL, "Tenis Jorge", "90", NULL, 2, 2);
INSERT INTO jugador(pkId, nombre, anotaciones, fotografia, fkIdEquipo, fkIdRol) VALUES (NULL, "Basket Jorge", "90", NULL, 2, 3);
INSERT INTO jugador(pkId, nombre, anotaciones, fotografia, fkIdEquipo, fkIdRol) VALUES (NULL, "Basket Luis", "50", NULL, 2, 3);
INSERT INTO campeonato(pkId, nombre, fechaInicio, fechaFinal, fkIdDeporte, fkIdTipoCampeonato) VALUES  (NULL, "LaLiga", "2021-01-01", "2021-01-01", 1, 1);
INSERT INTO puestoempleado(pkId, nombre) VALUES  (NULL, "Trabajador");
INSERT INTO puestoempleado(pkId, nombre) VALUES  (NULL, "Conserje");
INSERT INTO puestoempleado(pkId, nombre) VALUES  (NULL, "Secretaria");
INSERT INTO empleado(pkId, nombre, fkIdPuestoEmpleado) VALUES (NULL, "Jorge", 1);
INSERT INTO estadoPartido(pkId, nombre) VALUES (NULL, "En espera");
INSERT INTO estadoPartido(pkId, nombre) VALUES (NULL, "Finalizado");
INSERT INTO partido(pkId, equipo1, equipo2, anotacionesEquipo1, anotacionesEquipo2, campo, fecha, fase, fkIdCampeonato, fkIdEmpleado, fkIdEstadoPartido) VALUES (NULL, "Madrid", "Barcelona", "2","4", "mateo",'2015-12-29 19:48' ,"final", 1 ,1, 1);
INSERT INTO fase(pkId, nombre) VALUES(NULL, "Finales");
INSERT INTO fase(pkId, nombre) VALUES(NULL, "Semifinales");
INSERT INTO fase(pkId, nombre) VALUES(NULL, "Cuartos de final");
INSERT INTO fase(pkId, nombre) VALUES(NULL, "Octavos de final");
INSERT INTO estadoParticipante(pkId, nombre) VALUES (NULL, "Eliminado");
INSERT INTO estadoParticipante(pkId, nombre) VALUES (NULL, "Activo");
INSERT INTO participante(pkId, puntos, fkIdCampeonato, fkIdEquipo, fkIdFase, fkIdEstadoParticipante) VALUES(NULL, 15,1,1,1,1);

select * from participante;
DROP VIEW IF EXISTS `vwParticipante`;
CREATE VIEW `vwParticipante` AS
SELECT 
A.pkId AS pkIdParticipante, A.puntos,
B.pkId AS pkIdCampeonato, B.nombre AS campeonato,
C.pkId AS pkIdEquipo, C.nombre AS equipo,
D.pkId AS pkIdFase, D.nombre AS fase,
E.pkId AS pkIdEstadoParticipante, E.nombre AS estado
FROM participante A
INNER JOIN campeonato B ON B.pkId = A.fkIdCampeonato
INNER JOIN equipo C ON C.pkId = A.fkIdEquipo
INNER JOIN fase D ON D.pkId = A.fkIdFase
INNER JOIN estadoparticipante E ON E.pkId = A.fkIdEstadoParticipante;
select * from vwParticipante;

DROP VIEW IF EXISTS `vwParticipante`;
CREATE VIEW `vwParticipante` AS
SELECT 
A.pkId AS pkIdPartido, A.puntos, A.estado,
B.pkId AS pkIdCampeonato, B.nombre AS campeonato
FROM participante A
INNER JOIN campeonato B ON B.pkId = A.fkIdCampeonato;

/* Vista de tipofalta */
DROP VIEW IF EXISTS vwTipoFalta;
CREATE VIEW vwTipoFalta AS
SELECT 
A.pkId AS pkIdTipoFalta, A.tipo, 
B.pkId as pkIdDeporte, B.nombre AS deporte
FROM tipofalta A
INNER JOIN deporte B ON B.pkId = A.fkIdDeporte 
ORDER BY pkIdTipoFalta ASC;


/* Vista de jugador */
DROP VIEW  IF EXISTS `vwJugador`;
CREATE VIEW `vwJugador` AS
SELECT 
A.pkId AS pkIdJugador, A.nombre, A.anotaciones, 
B.pkId AS pkIdEquipo, B.nombre AS equipo, 
C.pkId AS pkIdRol, C.nombre AS rol,
D.pkId AS pkIdDeporte, D.nombre AS deporte
FROM jugador A
INNER JOIN equipo B ON B.pkId = A.fkIdEquipo
INNER JOIN deporte D ON B.fkIdDeporte = D.pkId  /* Deporte esta adentro de equipo */
INNER JOIN rol C ON  C.pkId = A.fkIdRol ORDER BY pkIdJugador ASC;

/* Vista de equipo */
DROP VIEW IF EXISTS `vwEquipo`;
CREATE VIEW `vwEquipo` AS
SELECT 
A.pkId AS pkIdEquipo, A.nombre, 
B.pkId as pkIdDeporte, B.nombre AS deporte
FROM equipo A
INNER JOIN deporte B ON B.pkId = A.fkIdDeporte ORDER BY pkIdEquipo ASC;

SELECT * FROM partido;
DROP VIEW IF EXISTS `vwPartido`;
CREATE VIEW `vwPartido` AS
SELECT 
A.pkId AS pkIdPartido, A.equipo1, A.equipo2, A.campo, A.anotacionesEquipo1, A.anotacionesEquipo2, A.fecha, A.fase,
B.pkId AS pkIdCampeonato, B.nombre AS campeonato,
C.pkId AS pkIdEmpleado, C.nombre AS empleado,
D.pkId AS pkIdEstado, D.nombre AS estado
FROM partido A
INNER JOIN campeonato B ON B.pkId = A.fkIdCampeonato
INNER JOIN empleado C ON C.pkId = A.fkIdEmpleado
INNER JOIN estadopartido D ON D.pkId = A.fkIdEstado
ORDER BY pkIdPartido;
select * from estado;

/* Vista de campeonato */
DROP VIEW IF EXISTS `vwcampeonato`;
CREATE VIEW `vwcampeonato` AS
    SELECT 
        `a`.`pkId` AS `pkIdCampeonato`,
        `a`.`nombre` AS `campeonato`,
        `a`.`fechaInicio` AS `fechaInicio`,
        `a`.`fechaFinal` AS `fechaFinal`,
        `b`.`pkId` AS `pkIdDeporte`,
        `b`.`nombre` AS `deporte`,
        `c`.`pkId` AS `pkIdTipoCampeonato`,
        `c`.`tipo` AS `tipoCampeonato`
    FROM
        ((`campeonato` `a`
        JOIN `deporte` `b` ON ((`b`.`pkId` = `a`.`fkIdDeporte`)))
        JOIN `tipocampeonato` `c` ON ((`c`.`pkId` = `a`.`fkIdTipoCampeonato`)))
    ORDER BY `a`.`pkId`;

DROP TABLE vwrol;
/* Vista de Rol*/
DROP VIEW IF EXISTS `vwRol`;
CREATE VIEW `vwRol` AS
	SELECT
A.pkId AS pkIdRol, A.nombre,
B.pkId as pkIdDeporte, B.nombre AS deporte
FROM rol A
INNER JOIN deporte B ON B.pkId = A.fkIdDeporte ORDER BY pkIdRol ASC;

/* Vista de entrenador */
DROP VIEW IF EXISTS vwEntrenador;
CREATE VIEW vwEntrenador AS
SELECT 
A.pkId AS pkIdEntrenador, A.nombre, 
B.pkId as pkIdEquipo, B.nombre AS equipo,
C.pkId AS pkIdDeporte, C.nombre AS deporte
FROM entrenador A
INNER JOIN equipo B ON B.pkId = A.fkIdEquipo
INNER JOIN deporte C ON B.fkIdDeporte = C.pkId ORDER BY pkIdEntrenador ASC;
select * from rol;