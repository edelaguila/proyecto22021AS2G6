select * from jugador;
select * from equipo;
select * from deporte;
select * from rol;
INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Fútbol");
INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Tenis");
INSERT INTO deporte(pkId, nombre) VALUES (NULL, "Basketball");
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "Delantero", 1);
INSERT INTO rol(pkId, nombre, fkIdDeporte) VALUES (NULL, "Defensa", 1);
INSERT INTO equipo(pkId, nombre, fkIdDeporte) VALUES (NULL, "Barcelona", "1");
INSERT INTO equipo(pkId, nombre, fkIdDeporte) VALUES (NULL, "Madrid", "1");
select * from vwjugador;
INSERT INTO jugador(pkId, nombre, anotaciones, fotografia, fkIdEquipo, fkIdRol) VALUES (NULL, "Melanie Revolorio", "90", NULL, 1, 1);
INSERT INTO jugador(pkId, nombre, anotaciones, fotografia, fkIdEquipo, fkIdRol) VALUES (NULL, "Jorge González", "50", NULL, 1, 1);

CREATE VIEW `vwJugador` AS
SELECT A.pkId AS pkIdJugador, A.nombre, A.anotaciones, C.pkId AS pkIdRol, C.nombre AS rol, B.pkId AS pkIdEquipo, B.nombre AS equipo
FROM jugador A
LEFT JOIN equipo B ON B.pkId = A.fkIdEquipo
INNER JOIN rol C ON  C.pkId = A.fkIdRol;