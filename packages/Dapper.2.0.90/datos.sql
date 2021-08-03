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
        JOIN `equipo` `b` ON ((`b`.`pkId` = `a`.`fkIdDeporte`)))
        JOIN `tipocampeonato` `c` ON ((`c`.`pkId` = `a`.`fkIdTipoCampeonato`)))
    ORDER BY `a`.`pkId`;
    
select * from campeonato;
select * from tipocampeonato;

INSERT INTO campeonato(pkId, nombre, fechaInicio, fechaFinal, fkIdDeporte, fkIdTipoCampeonato) VALUES  