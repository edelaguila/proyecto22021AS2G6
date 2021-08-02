INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Fútbol");
INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Tenis");
INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Basketball");
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "Delantero", 1);
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "Delantero", 3);
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "Defensa", 1);
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "DefensaTenis", 2);
INSERT INTO entrenador(pkId, nombre) VALUES (NULL, "Jorge González");
INSERT INTO entrenador(pkId, nombre) VALUES (NULL, "Luis Herrera");
INSERT INTO entrenador(pkId, nombre) VALUES (NULL, "Roberto Perez");
INSERT INTO equipo(pkId, nombre, fkIdDeporte, fkIdEntrenador) VALUES (NULL, "Barcelona", 1, 1);
INSERT INTO equipo(pkId, nombre, fkIdDeporte, fkIdEntrenador) VALUES (NULL, "Madrid", 1, 2);
INSERT INTO equipo(pkId, nombre, fkIdDeporte, fkIdEntrenador) VALUES (NULL, "TenisSA", 2, 3);
INSERT INTO jugador(pkId, nombre, anotaciones, fotografia, fkIdEquipo, fkIdRol, fkIdDeporte) VALUES (NULL, "Tenis Jorge", "90", NULL, 2, 2, 1);
INSERT INTO jugador(pkId, nombre, anotaciones, fotografia, fkIdEquipo, fkIdRol, fkIdDeporte) VALUES (NULL, "Basket Jorge", "90", NULL, 2, 3,2);
INSERT INTO jugador(pkId, nombre, anotaciones, fotografia, fkIdEquipo, fkIdRol, fkIdDeporte) VALUES (NULL, "Basket Luis", "50", NULL, 2, 3,3);

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

/* Vista de equipo */
DROP VIEW `vwEquipo`;
CREATE VIEW `vwEquipo` AS
SELECT 
A.pkId AS pkIdEquipo, A.nombre, 
C.pkId AS pkIdEntrenador, C.nombre AS entrenador,
B.pkId as pkIdDeporte, B.nombre AS deporte
FROM equipo A
INNER JOIN entrenador C ON C.pkId = A.fkIdEntrenador
INNER JOIN deporte B ON B.pkId = A.fkIdDeporte ORDER BY pkIdEquipo ASC;

/* Vista de campeonato */
DROP VIEW `vwcampeonato`;
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
        JOIN `equipo` `b` ON ((`b`.`pkId` = `a`.`fkIdDeporte`)))
        JOIN `tipocampeonato` `c` ON ((`c`.`pkId` = `a`.`fkIdTipoCampeonato`)))
    ORDER BY `a`.`pkId`;