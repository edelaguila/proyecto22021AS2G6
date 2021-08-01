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
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`entrenador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`entrenador` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`entrenador` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`pkId`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
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
  `fkIdEntrenador` INT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_equipo_deporte1_idx` (`fkIdDeporte` ASC) VISIBLE,
  INDEX `fk_equipo_entrenador1_idx` (`fkIdEntrenador` ASC) VISIBLE,
  CONSTRAINT `fk_equipo_deporte1`
    FOREIGN KEY (`fkIdDeporte`)
    REFERENCES `bdpolideportivo`.`deporte` (`pkId`),
  CONSTRAINT `fk_equipo_entrenador1`
    FOREIGN KEY (`fkIdEntrenador`)
    REFERENCES `bdpolideportivo`.`entrenador` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 4
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
    REFERENCES `bdpolideportivo`.`deporte` (`pkId`))
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
  `fkIdEquipo` INT NOT NULL,
  `fkIdRol` INT NOT NULL,
  `fkIdDeporte` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_jugador_equipo1_idx` (`fkIdEquipo` ASC) VISIBLE,
  INDEX `fk_jugador_rol1_idx` (`fkIdRol` ASC) VISIBLE,
  INDEX `fk_jugador_deporte1_idx` (`fkIdDeporte` ASC) VISIBLE,
  CONSTRAINT `fk_jugador_deporte1`
    FOREIGN KEY (`fkIdDeporte`)
    REFERENCES `bdpolideportivo`.`deporte` (`pkId`),
  CONSTRAINT `fk_jugador_equipo1`
    FOREIGN KEY (`fkIdEquipo`)
    REFERENCES `bdpolideportivo`.`equipo` (`pkId`),
  CONSTRAINT `fk_jugador_rol1`
    FOREIGN KEY (`fkIdRol`)
    REFERENCES `bdpolideportivo`.`rol` (`pkId`))
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
  PRIMARY KEY (`pkId`))
ENGINE = InnoDB
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
    REFERENCES `bdpolideportivo`.`deporte` (`pkId`),
  CONSTRAINT `fk_campeonato_tipo_campeonato1`
    FOREIGN KEY (`fkIdTipoCampeonato`)
    REFERENCES `bdpolideportivo`.`tipocampeonato` (`pkId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`empleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`empleado` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`empleado` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `rol` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`pkId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`resultado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`resultado` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`resultado` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `anotacionEquipo1` INT NOT NULL,
  `anotacionEquipo2` INT NOT NULL,
  PRIMARY KEY (`pkId`))
ENGINE = InnoDB
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
  `campo` VARCHAR(45) NOT NULL,
  `fecha` DATE NOT NULL,
  `estado` VARCHAR(45) NOT NULL,
  `fase` VARCHAR(45) NOT NULL,
  `fkIdCampeonato` INT NOT NULL,
  `fkIdEmpleado` INT NOT NULL,
  `fkIdResultado` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_partido_campeonato1_idx` (`fkIdCampeonato` ASC) VISIBLE,
  INDEX `fk_partido_empleado1_idx` (`fkIdEmpleado` ASC) VISIBLE,
  INDEX `fk_partido_resultado1_idx` (`fkIdResultado` ASC) VISIBLE,
  CONSTRAINT `fk_partido_campeonato1`
    FOREIGN KEY (`fkIdCampeonato`)
    REFERENCES `bdpolideportivo`.`campeonato` (`pkId`),
  CONSTRAINT `fk_partido_empleado1`
    FOREIGN KEY (`fkIdEmpleado`)
    REFERENCES `bdpolideportivo`.`empleado` (`pkId`),
  CONSTRAINT `fk_partido_resultado1`
    FOREIGN KEY (`fkIdResultado`)
    REFERENCES `bdpolideportivo`.`resultado` (`pkId`))
ENGINE = InnoDB
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
    REFERENCES `bdpolideportivo`.`deporte` (`pkId`))
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
  `tipo_id` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_infraccion_jugador1_idx` (`fkIdJugador` ASC) VISIBLE,
  INDEX `fk_infraccion_tipo1_idx` (`tipo_id` ASC) VISIBLE,
  CONSTRAINT `fk_infraccion_jugador1`
    FOREIGN KEY (`fkIdJugador`)
    REFERENCES `bdpolideportivo`.`jugador` (`pkId`),
  CONSTRAINT `fk_infraccion_tipo1`
    FOREIGN KEY (`tipo_id`)
    REFERENCES `bdpolideportivo`.`tipofalta` (`pkId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bdpolideportivo`.`participante`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`participante` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`participante` (
  `id` INT NOT NULL,
  `equipos` VARCHAR(45) NULL DEFAULT NULL,
  `estado` VARCHAR(45) NULL DEFAULT NULL,
  `fase` VARCHAR(45) NULL DEFAULT NULL,
  `campeonato_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_participante_campeonato1_idx` (`campeonato_id` ASC) VISIBLE,
  CONSTRAINT `fk_participante_campeonato1`
    FOREIGN KEY (`campeonato_id`)
    REFERENCES `bdpolideportivo`.`campeonato` (`pkId`))
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
-- Table `bdpolideportivo`.`usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`usuario` ;

CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`usuario` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `contraseña` VARCHAR(45) NOT NULL,
  `telefono` INT NULL DEFAULT NULL,
  `tipo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`pkId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

USE `bdpolideportivo` ;

-- -----------------------------------------------------
-- Placeholder table for view `bdpolideportivo`.`vwjugador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bdpolideportivo`.`vwjugador` (`pkIdJugador` INT, `nombre` INT, `anotaciones` INT, `pkIdRol` INT, `rol` INT, `pkIdEquipo` INT, `equipo` INT, `pkIdDeporte` INT, `deporte` INT);

-- -----------------------------------------------------
-- View `bdpolideportivo`.`vwjugador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdpolideportivo`.`vwjugador`;
DROP VIEW IF EXISTS `bdpolideportivo`.`vwjugador` ;
USE `bdpolideportivo`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bdpolideportivo`.`vwjugador` AS select `a`.`pkId` AS `pkIdJugador`,`a`.`nombre` AS `nombre`,`a`.`anotaciones` AS `anotaciones`,`c`.`pkId` AS `pkIdRol`,`c`.`nombre` AS `rol`,`b`.`pkId` AS `pkIdEquipo`,`b`.`nombre` AS `equipo`,`d`.`pkId` AS `pkIdDeporte`,`d`.`nombre` AS `deporte` from (((`bdpolideportivo`.`jugador` `a` join `bdpolideportivo`.`equipo` `b` on((`b`.`pkId` = `a`.`fkIdEquipo`))) join `bdpolideportivo`.`rol` `c` on((`c`.`pkId` = `a`.`fkIdRol`))) join `bdpolideportivo`.`deporte` `d` on((`d`.`pkId` = `a`.`fkIdDeporte`))) order by `a`.`pkId`;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

ALTER TABLE anotacion AUTO_INCREMENT = 1;
ALTER TABLE campeonato AUTO_INCREMENT = 1;
ALTER TABLE deporte AUTO_INCREMENT = 1;
ALTER TABLE empleado AUTO_INCREMENT = 1;

ALTER TABLE entrenador AUTO_INCREMENT = 1;
ALTER TABLE equipo AUTO_INCREMENT = 1;
ALTER TABLE infraccion AUTO_INCREMENT = 1;
ALTER TABLE jugador AUTO_INCREMENT = 1;

ALTER TABLE participante AUTO_INCREMENT = 1;
ALTER TABLE partido AUTO_INCREMENT = 1;
ALTER TABLE posicion AUTO_INCREMENT = 1;
ALTER TABLE resultado AUTO_INCREMENT = 1;

ALTER TABLE rol AUTO_INCREMENT = 1;
ALTER TABLE tipocampeonato AUTO_INCREMENT = 1;
ALTER TABLE tipofalta AUTO_INCREMENT = 1;
ALTER TABLE usuario AUTO_INCREMENT = 1;

