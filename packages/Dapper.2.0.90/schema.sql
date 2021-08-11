-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema bdpolideportivo
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `bdpolideportivo` ;

-- -----------------------------------------------------
-- Schema bdpolideportivo
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bdpolideportivo` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `bdpolideportivo` ;

-- -----------------------------------------------------
-- Table `bdpolideportivo`.`deporte`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`deporte` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`deporte` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`pkId`),
  UNIQUE INDEX `nombre_UNIQUE` (`nombre` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`equipo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`equipo` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`equipo` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `fkIdDeporte` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_equipo_deporte1_idx` (`fkIdDeporte` ASC) VISIBLE,
  CONSTRAINT `fk_equipo_deporte1`
    FOREIGN KEY (`fkIdDeporte`)
    REFERENCES `bdpolideportivo`.`deporte` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`rol`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`rol` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`rol` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  `fkIdDeporte` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_rol_deporte1_idx` (`fkIdDeporte` ASC) VISIBLE,
  CONSTRAINT `fk_rol_deporte1`
    FOREIGN KEY (`fkIdDeporte`)
    REFERENCES `bdpolideportivo`.`deporte` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`jugador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`jugador` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`jugador` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `anotaciones` INT NOT NULL,
  `fotografia` BLOB NULL DEFAULT NULL,
  `fkIdEquipo` INT NULL DEFAULT NULL,
  `fkIdRol` INT NULL DEFAULT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_jugador_equipo1_idx` (`fkIdEquipo` ASC) VISIBLE,
  INDEX `fk_jugador_rol1_idx` (`fkIdRol` ASC) VISIBLE,
  CONSTRAINT `fk_jugador_equipo1`
    FOREIGN KEY (`fkIdEquipo`)
    REFERENCES `bdpolideportivo`.`equipo` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_jugador_rol1`
    FOREIGN KEY (`fkIdRol`)
    REFERENCES `bdpolideportivo`.`rol` (`pkId`)
    ON DELETE SET NULL
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`tipocampeonato`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`tipocampeonato` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`tipocampeonato` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `tipo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`pkId`),
  UNIQUE INDEX `tipo_UNIQUE` (`tipo` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`campeonato`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`campeonato` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`campeonato` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `fechaInicio` DATE NOT NULL,
  `fechaFinal` DATE NOT NULL,
  `fkIdDeporte` INT NOT NULL,
  `fkIdTipoCampeonato` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_campeonato_deporte1_idx` (`fkIdDeporte` ASC) VISIBLE,
  INDEX `fk_campeonato_tipo_campeonato1_idx` (`fkIdTipoCampeonato` ASC) VISIBLE,
  CONSTRAINT `fk_campeonato_deporte1`
    FOREIGN KEY (`fkIdDeporte`)
    REFERENCES `bdpolideportivo`.`deporte` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_campeonato_tipo_campeonato1`
    FOREIGN KEY (`fkIdTipoCampeonato`)
    REFERENCES `bdpolideportivo`.`tipocampeonato` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`puestoempleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`puestoempleado` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`puestoempleado` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`pkId`),
  UNIQUE INDEX `nombre_UNIQUE` (`nombre` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`empleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`empleado` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`empleado` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `fkIdPuestoEmpleado` INT NULL DEFAULT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_empleado_puestoEmpleaado1_idx` (`fkIdPuestoEmpleado` ASC) VISIBLE,
  CONSTRAINT `fk_empleado_puestoEmpleaado1`
    FOREIGN KEY (`fkIdPuestoEmpleado`)
    REFERENCES `bdpolideportivo`.`puestoempleado` (`pkId`)
    ON DELETE SET NULL)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`estadopartido`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`estadopartido` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`estadopartido` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`pkId`),
  UNIQUE INDEX `nombre_UNIQUE` (`nombre` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`fase`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`fase` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`fase` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`pkId`),
  UNIQUE INDEX `nombre_UNIQUE` (`nombre` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`partido`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`partido` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`partido` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `equipo1` VARCHAR(45) NOT NULL,
  `equipo2` VARCHAR(45) NOT NULL,
  `anotacionesEquipo1` INT NULL DEFAULT NULL,
  `anotacionesEquipo2` INT NULL DEFAULT NULL,
  `campo` VARCHAR(45) NOT NULL,
  `fecha` TIMESTAMP NOT NULL,
  `fkIdCampeonato` INT NOT NULL,
  `fkIdEmpleado` INT NULL DEFAULT NULL,
  `fkIdEstadoPartido` INT NULL DEFAULT NULL,
  `fkIdFase` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_partido_campeonato1_idx` (`fkIdCampeonato` ASC) VISIBLE,
  INDEX `fk_partido_empleado1_idx` (`fkIdEmpleado` ASC) VISIBLE,
  INDEX `fk_partido_estado1_idx` (`fkIdEstadoPartido` ASC) VISIBLE,
  INDEX `fk_partido_fase1_idx` (`fkIdFase` ASC) VISIBLE,
  CONSTRAINT `fk_partido_campeonato1`
    FOREIGN KEY (`fkIdCampeonato`)
    REFERENCES `bdpolideportivo`.`campeonato` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_partido_empleado1`
    FOREIGN KEY (`fkIdEmpleado`)
    REFERENCES `bdpolideportivo`.`empleado` (`pkId`)
    ON DELETE SET NULL,
  CONSTRAINT `fk_partido_estado1`
    FOREIGN KEY (`fkIdEstadoPartido`)
    REFERENCES `bdpolideportivo`.`estadopartido` (`pkId`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_partido_fase1`
    FOREIGN KEY (`fkIdFase`)
    REFERENCES `bdpolideportivo`.`fase` (`pkId`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`anotacion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`anotacion` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`anotacion` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `cantidad` INT NOT NULL,
  `fkIdJugador` INT NOT NULL,
  `fkIdPartido` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_puntos_jugador1_idx` (`fkIdJugador` ASC) VISIBLE,
  INDEX `fk_puntos_partido1_idx` (`fkIdPartido` ASC) VISIBLE,
  CONSTRAINT `fk_puntos_jugador1`
    FOREIGN KEY (`fkIdJugador`)
    REFERENCES `bdpolideportivo`.`jugador` (`pkId`),
  CONSTRAINT `fk_puntos_partido1`
    FOREIGN KEY (`fkIdPartido`)
    REFERENCES `bdpolideportivo`.`partido` (`pkId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`entrenador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`entrenador` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`entrenador` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  `fkIdEquipo` INT NULL DEFAULT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_entrenador_equipo1_idx` (`fkIdEquipo` ASC) VISIBLE,
  CONSTRAINT `fk_entrenador_equipo1`
    FOREIGN KEY (`fkIdEquipo`)
    REFERENCES `bdpolideportivo`.`equipo` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`estadoparticipante`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`estadoparticipante` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`estadoparticipante` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`pkId`),
  UNIQUE INDEX `nombre_UNIQUE` (`nombre` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`tipofalta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`tipofalta` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`tipofalta` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `tipo` VARCHAR(45) NULL DEFAULT NULL,
  `fkIdDeporte` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_tipo_deporte1_idx` (`fkIdDeporte` ASC) VISIBLE,
  CONSTRAINT `fk_tipo_deporte1`
    FOREIGN KEY (`fkIdDeporte`)
    REFERENCES `bdpolideportivo`.`deporte` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`infraccion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`infraccion` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`infraccion` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `fkIdJugador` INT NOT NULL,
  `fkIdTipoFalta` INT NULL DEFAULT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_infraccion_jugador1_idx` (`fkIdJugador` ASC) VISIBLE,
  INDEX `fk_infraccion_tipo1_idx` (`fkIdTipoFalta` ASC) VISIBLE,
  CONSTRAINT `fk_infraccion_jugador1`
    FOREIGN KEY (`fkIdJugador`)
    REFERENCES `bdpolideportivo`.`jugador` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_infraccion_tipo1`
    FOREIGN KEY (`fkIdTipoFalta`)
    REFERENCES `bdpolideportivo`.`tipofalta` (`pkId`)
    ON DELETE SET NULL)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`participante`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`participante` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`participante` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `puntos` INT NULL DEFAULT NULL,
  `fkIdCampeonato` INT NOT NULL,
  `fkIdEquipo` INT NOT NULL,
  `fkIdFase` INT NULL DEFAULT NULL,
  `fkIdEstadoParticipante` INT NULL DEFAULT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_participante_campeonato1_idx` (`fkIdCampeonato` ASC) VISIBLE,
  INDEX `fk_participante_equipo1_idx` (`fkIdEquipo` ASC) VISIBLE,
  INDEX `fk_participante_fase1_idx` (`fkIdFase` ASC) VISIBLE,
  INDEX `fk_participante_estadoParticipante1_idx` (`fkIdEstadoParticipante` ASC) VISIBLE,
  CONSTRAINT `fk_participante_campeonato1`
    FOREIGN KEY (`fkIdCampeonato`)
    REFERENCES `bdpolideportivo`.`campeonato` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_participante_equipo1`
    FOREIGN KEY (`fkIdEquipo`)
    REFERENCES `bdpolideportivo`.`equipo` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_participante_estadoParticipante1`
    FOREIGN KEY (`fkIdEstadoParticipante`)
    REFERENCES `bdpolideportivo`.`estadoparticipante` (`pkId`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_participante_fase1`
    FOREIGN KEY (`fkIdFase`)
    REFERENCES `bdpolideportivo`.`fase` (`pkId`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`posicion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`posicion` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`posicion` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `puntos` INT NULL DEFAULT NULL,
  `fkIdCampeonato` INT NOT NULL,
  `fkIdEquipo` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_posicion_campeonato1_idx` (`fkIdCampeonato` ASC) VISIBLE,
  INDEX `fk_posicion_equipo1_idx` (`fkIdEquipo` ASC) VISIBLE,
  CONSTRAINT `fk_posicion_campeonato1`
    FOREIGN KEY (`fkIdCampeonato`)
    REFERENCES `bdpolideportivo`.`campeonato` (`pkId`),
  CONSTRAINT `fk_posicion_equipo1`
    FOREIGN KEY (`fkIdEquipo`)
    REFERENCES `bdpolideportivo`.`equipo` (`pkId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`tipousuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`tipousuario` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`tipousuario` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`pkId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`usuario` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`usuario` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `contraseña` VARCHAR(61) NOT NULL,
  `telefono` INT(8) NULL DEFAULT NULL,
  `fkIdTipoUsuario` INT NOT NULL,
  PRIMARY KEY (`pkId`, `fkIdTipoUsuario`),
  INDEX `fk_usuario_tipoUsuario1_idx` (`fkIdTipoUsuario` ASC) VISIBLE,
  UNIQUE INDEX `nombre_UNIQUE` (`nombre` ASC) VISIBLE,
  UNIQUE INDEX `telefono_UNIQUE` (`telefono` ASC) VISIBLE,
  CONSTRAINT `fk_usuario_tipoUsuario1`
    FOREIGN KEY (`fkIdTipoUsuario`)
    REFERENCES `bdpolideportivo`.`tipousuario` (`pkId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

USE `bdpolideportivo` ;

-- -----------------------------------------------------
-- Placeholder table for view `bdpolideportivo`.`vwcampeonato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`vwcampeonato` (`pkIdCampeonato` INT, `campeonato` INT, `fechaInicio` INT, `fechaFinal` INT, `pkIdDeporte` INT, `deporte` INT, `pkIdTipoCampeonato` INT, `tipoCampeonato` INT);

-- -----------------------------------------------------
-- Placeholder table for view `bdpolideportivo`.`vwempleado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`vwempleado` (`pkIdEmpleado` INT, `nombre` INT, `pkIdPuestoEmpleado` INT, `puestoempleado` INT);

-- -----------------------------------------------------
-- Placeholder table for view `bdpolideportivo`.`vwentrenador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`vwentrenador` (`pkIdEntrenador` INT, `nombre` INT, `pkIdEquipo` INT, `equipo` INT, `pkIdDeporte` INT, `deporte` INT);

-- -----------------------------------------------------
-- Placeholder table for view `bdpolideportivo`.`vwequipo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`vwequipo` (`pkIdEquipo` INT, `nombre` INT, `pkIdDeporte` INT, `deporte` INT);

-- -----------------------------------------------------
-- Placeholder table for view `bdpolideportivo`.`vwjugador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`vwjugador` (`pkIdJugador` INT, `nombre` INT, `anotaciones` INT, `pkIdEquipo` INT, `equipo` INT, `pkIdRol` INT, `rol` INT, `pkIdDeporte` INT, `deporte` INT);

-- -----------------------------------------------------
-- Placeholder table for view `bdpolideportivo`.`vwparticipante`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`vwparticipante` (`pkIdParticipante` INT, `puntos` INT, `pkIdCampeonato` INT, `campeonato` INT, `pkIdEquipo` INT, `equipo` INT, `pkIdFase` INT, `fase` INT, `pkIdEstadoParticipante` INT, `estado` INT);

-- -----------------------------------------------------
-- Placeholder table for view `bdpolideportivo`.`vwpartido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`vwpartido` (`pkIdPartido` INT, `equipo1` INT, `equipo2` INT, `campo` INT, `anotacionesEquipo1` INT, `anotacionesEquipo2` INT, `fecha` INT, `pkIdCampeonato` INT, `campeonato` INT, `pkIdEmpleado` INT, `empleado` INT, `pkIdEstadoPartido` INT, `estado` INT, `pkIdFase` INT, `fase` INT);

-- -----------------------------------------------------
-- Placeholder table for view `bdpolideportivo`.`vwrol`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`vwrol` (`pkIdRol` INT, `nombre` INT, `pkIdDeporte` INT, `deporte` INT);

-- -----------------------------------------------------
-- Placeholder table for view `bdpolideportivo`.`vwtipofalta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`vwtipofalta` (`pkIdTipoFalta` INT, `tipo` INT, `pkIdDeporte` INT, `deporte` INT);

-- -----------------------------------------------------
-- View `bdpolideportivo`.`vwcampeonato`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`vwcampeonato`;
DROP VIEW IF EXISTS `bdpolideportivo`.`vwcampeonato` ;
USE `bdpolideportivo`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bdpolideportivo`.`vwcampeonato` AS select `a`.`pkId` AS `pkIdCampeonato`,`a`.`nombre` AS `campeonato`,`a`.`fechaInicio` AS `fechaInicio`,`a`.`fechaFinal` AS `fechaFinal`,`b`.`pkId` AS `pkIdDeporte`,`b`.`nombre` AS `deporte`,`c`.`pkId` AS `pkIdTipoCampeonato`,`c`.`tipo` AS `tipoCampeonato` from ((`bdpolideportivo`.`campeonato` `a` join `bdpolideportivo`.`deporte` `b` on((`b`.`pkId` = `a`.`fkIdDeporte`))) join `bdpolideportivo`.`tipocampeonato` `c` on((`c`.`pkId` = `a`.`fkIdTipoCampeonato`))) order by `a`.`pkId`;

-- -----------------------------------------------------
-- View `bdpolideportivo`.`vwempleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`vwempleado`;
DROP VIEW IF EXISTS `bdpolideportivo`.`vwempleado` ;
USE `bdpolideportivo`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bdpolideportivo`.`vwempleado` AS select `a`.`pkId` AS `pkIdEmpleado`,`a`.`nombre` AS `nombre`,`b`.`pkId` AS `pkIdPuestoEmpleado`,`b`.`nombre` AS `puestoempleado` from (`bdpolideportivo`.`empleado` `a` join `bdpolideportivo`.`puestoempleado` `b` on((`b`.`pkId` = `a`.`fkIdPuestoEmpleado`))) order by `a`.`pkId`;

-- -----------------------------------------------------
-- View `bdpolideportivo`.`vwentrenador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`vwentrenador`;
DROP VIEW IF EXISTS `bdpolideportivo`.`vwentrenador` ;
USE `bdpolideportivo`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bdpolideportivo`.`vwentrenador` AS select `a`.`pkId` AS `pkIdEntrenador`,`a`.`nombre` AS `nombre`,`b`.`pkId` AS `pkIdEquipo`,`b`.`nombre` AS `equipo`,`c`.`pkId` AS `pkIdDeporte`,`c`.`nombre` AS `deporte` from ((`bdpolideportivo`.`entrenador` `a` join `bdpolideportivo`.`equipo` `b` on((`b`.`pkId` = `a`.`fkIdEquipo`))) join `bdpolideportivo`.`deporte` `c` on((`b`.`fkIdDeporte` = `c`.`pkId`))) order by `a`.`pkId`;

-- -----------------------------------------------------
-- View `bdpolideportivo`.`vwequipo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`vwequipo`;
DROP VIEW IF EXISTS `bdpolideportivo`.`vwequipo` ;
USE `bdpolideportivo`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bdpolideportivo`.`vwequipo` AS select `a`.`pkId` AS `pkIdEquipo`,`a`.`nombre` AS `nombre`,`b`.`pkId` AS `pkIdDeporte`,`b`.`nombre` AS `deporte` from (`bdpolideportivo`.`equipo` `a` join `bdpolideportivo`.`deporte` `b` on((`b`.`pkId` = `a`.`fkIdDeporte`))) order by `a`.`pkId`;

-- -----------------------------------------------------
-- View `bdpolideportivo`.`vwjugador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`vwjugador`;
DROP VIEW IF EXISTS `bdpolideportivo`.`vwjugador` ;
USE `bdpolideportivo`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bdpolideportivo`.`vwjugador` AS select `a`.`pkId` AS `pkIdJugador`,`a`.`nombre` AS `nombre`,`a`.`anotaciones` AS `anotaciones`,`b`.`pkId` AS `pkIdEquipo`,`b`.`nombre` AS `equipo`,`c`.`pkId` AS `pkIdRol`,`c`.`nombre` AS `rol`,`d`.`pkId` AS `pkIdDeporte`,`d`.`nombre` AS `deporte` from (((`bdpolideportivo`.`jugador` `a` join `bdpolideportivo`.`equipo` `b` on((`b`.`pkId` = `a`.`fkIdEquipo`))) join `bdpolideportivo`.`deporte` `d` on((`b`.`fkIdDeporte` = `d`.`pkId`))) join `bdpolideportivo`.`rol` `c` on((`c`.`pkId` = `a`.`fkIdRol`))) order by `a`.`pkId`;

-- -----------------------------------------------------
-- View `bdpolideportivo`.`vwparticipante`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`vwparticipante`;
DROP VIEW IF EXISTS `bdpolideportivo`.`vwparticipante` ;
USE `bdpolideportivo`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bdpolideportivo`.`vwparticipante` AS select `a`.`pkId` AS `pkIdParticipante`,`a`.`puntos` AS `puntos`,`b`.`pkId` AS `pkIdCampeonato`,`b`.`nombre` AS `campeonato`,`c`.`pkId` AS `pkIdEquipo`,`c`.`nombre` AS `equipo`,`d`.`pkId` AS `pkIdFase`,`d`.`nombre` AS `fase`,`e`.`pkId` AS `pkIdEstadoParticipante`,`e`.`nombre` AS `estado` from ((((`bdpolideportivo`.`participante` `a` join `bdpolideportivo`.`campeonato` `b` on((`b`.`pkId` = `a`.`fkIdCampeonato`))) join `bdpolideportivo`.`equipo` `c` on((`c`.`pkId` = `a`.`fkIdEquipo`))) join `bdpolideportivo`.`fase` `d` on((`d`.`pkId` = `a`.`fkIdFase`))) join `bdpolideportivo`.`estadoparticipante` `e` on((`e`.`pkId` = `a`.`fkIdEstadoParticipante`)));

-- -----------------------------------------------------
-- View `bdpolideportivo`.`vwpartido`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`vwpartido`;
DROP VIEW IF EXISTS `bdpolideportivo`.`vwpartido` ;
USE `bdpolideportivo`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bdpolideportivo`.`vwpartido` AS select `a`.`pkId` AS `pkIdPartido`,`a`.`equipo1` AS `equipo1`,`a`.`equipo2` AS `equipo2`,`a`.`campo` AS `campo`,`a`.`anotacionesEquipo1` AS `anotacionesEquipo1`,`a`.`anotacionesEquipo2` AS `anotacionesEquipo2`,`a`.`fecha` AS `fecha`,`b`.`pkId` AS `pkIdCampeonato`,`b`.`nombre` AS `campeonato`,`c`.`pkId` AS `pkIdEmpleado`,`c`.`nombre` AS `empleado`,`d`.`pkId` AS `pkIdEstadoPartido`,`d`.`nombre` AS `estado`,`e`.`pkId` AS `pkIdFase`,`e`.`nombre` AS `fase` from ((((`bdpolideportivo`.`partido` `a` join `bdpolideportivo`.`campeonato` `b` on((`b`.`pkId` = `a`.`fkIdCampeonato`))) join `bdpolideportivo`.`empleado` `c` on((`c`.`pkId` = `a`.`fkIdEmpleado`))) join `bdpolideportivo`.`estadopartido` `d` on((`d`.`pkId` = `a`.`fkIdEstadoPartido`))) join `bdpolideportivo`.`fase` `e` on((`e`.`pkId` = `a`.`fkIdFase`))) order by `a`.`pkId`;

-- -----------------------------------------------------
-- View `bdpolideportivo`.`vwrol`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`vwrol`;
DROP VIEW IF EXISTS `bdpolideportivo`.`vwrol` ;
USE `bdpolideportivo`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bdpolideportivo`.`vwrol` AS select `a`.`pkId` AS `pkIdRol`,`a`.`nombre` AS `nombre`,`b`.`pkId` AS `pkIdDeporte`,`b`.`nombre` AS `deporte` from (`bdpolideportivo`.`rol` `a` join `bdpolideportivo`.`deporte` `b` on((`b`.`pkId` = `a`.`fkIdDeporte`))) order by `a`.`pkId`;

-- -----------------------------------------------------
-- View `bdpolideportivo`.`vwtipofalta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`vwtipofalta`;
DROP VIEW IF EXISTS `bdpolideportivo`.`vwtipofalta` ;
USE `bdpolideportivo`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bdpolideportivo`.`vwtipofalta` AS select `a`.`pkId` AS `pkIdTipoFalta`,`a`.`tipo` AS `tipo`,`b`.`pkId` AS `pkIdDeporte`,`b`.`nombre` AS `deporte` from (`bdpolideportivo`.`tipofalta` `a` join `bdpolideportivo`.`deporte` `b` on((`b`.`pkId` = `a`.`fkIdDeporte`))) order by `a`.`pkId`;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


ALTER TABLE anotacion AUTO_INCREMENT = 1;
ALTER TABLE campeonato AUTO_INCREMENT = 1;
ALTER TABLE deporte AUTO_INCREMENT = 1;
ALTER TABLE empleado AUTO_INCREMENT = 1;

ALTER TABLE entrenador AUTO_INCREMENT = 1;
ALTER TABLE equipo AUTO_INCREMENT = 1;
ALTER TABLE fase AUTO_INCREMENT = 1;
ALTER TABLE infraccion AUTO_INCREMENT = 1;
ALTER TABLE jugador AUTO_INCREMENT = 1;

ALTER TABLE participante AUTO_INCREMENT = 1;
ALTER TABLE partido AUTO_INCREMENT = 1;
ALTER TABLE posicion AUTO_INCREMENT = 1;
ALTER TABLE empleado AUTO_INCREMENT = 1;
ALTER TABLE estadoPartido AUTO_INCREMENT = 1;

ALTER TABLE rol AUTO_INCREMENT = 1;
ALTER TABLE tipocampeonato AUTO_INCREMENT = 1;
ALTER TABLE tipofalta AUTO_INCREMENT = 1;
ALTER TABLE usuario AUTO_INCREMENT = 1;
ALTER TABLE puestoempleado AUTO_INCREMENT = 1;

