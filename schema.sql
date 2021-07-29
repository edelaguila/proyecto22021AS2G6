-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema bdPolideportivo
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `bdPolideportivo` ;

-- -----------------------------------------------------
-- Schema bdPolideportivo
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bdPolideportivo` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `bdPolideportivo` ;

-- -----------------------------------------------------
-- Table `bdPolideportivo`.`usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`usuario` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`usuario` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `contraseña` VARCHAR(45) NOT NULL,
  `telefono` INT NULL,
  `tipo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`pkId`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`deporte`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`deporte` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`deporte` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`pkId`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`equipo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`equipo` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`equipo` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `fkIdDeporte` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_equipo_deporte1_idx` (`fkIdDeporte` ASC) VISIBLE,
  CONSTRAINT `fk_equipo_deporte1`
    FOREIGN KEY (`fkIdDeporte`)
    REFERENCES `bdPolideportivo`.`deporte` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`rol`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`rol` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`rol` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `fkIdDeporte` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_rol_deporte1_idx` (`fkIdDeporte` ASC) VISIBLE,
  CONSTRAINT `fk_rol_deporte1`
    FOREIGN KEY (`fkIdDeporte`)
    REFERENCES `bdPolideportivo`.`deporte` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`jugador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`jugador` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`jugador` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `anotaciones` INT NOT NULL,
  `fotografia` BLOB NULL,
  `fkIdEquipo` INT NOT NULL,
  `fkIdRol` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_jugador_equipo1_idx` (`fkIdEquipo` ASC) VISIBLE,
  INDEX `fk_jugador_rol1_idx` (`fkIdRol` ASC) VISIBLE,
  CONSTRAINT `fk_jugador_equipo1`
    FOREIGN KEY (`fkIdEquipo`)
    REFERENCES `bdPolideportivo`.`equipo` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_jugador_rol1`
    FOREIGN KEY (`fkIdRol`)
    REFERENCES `bdPolideportivo`.`rol` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`tipoFalta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`tipoFalta` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`tipoFalta` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `tipo` VARCHAR(45) NULL,
  `fkIdDeporte` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_tipo_deporte1_idx` (`fkIdDeporte` ASC) VISIBLE,
  CONSTRAINT `fk_tipo_deporte1`
    FOREIGN KEY (`fkIdDeporte`)
    REFERENCES `bdPolideportivo`.`deporte` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`infraccion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`infraccion` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`infraccion` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `fkIdJugador` INT NOT NULL,
  `tipo_id` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_infraccion_jugador1_idx` (`fkIdJugador` ASC) VISIBLE,
  INDEX `fk_infraccion_tipo1_idx` (`tipo_id` ASC) VISIBLE,
  CONSTRAINT `fk_infraccion_jugador1`
    FOREIGN KEY (`fkIdJugador`)
    REFERENCES `bdPolideportivo`.`jugador` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_infraccion_tipo1`
    FOREIGN KEY (`tipo_id`)
    REFERENCES `bdPolideportivo`.`tipoFalta` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`posicion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`posicion` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`posicion` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `puntos` INT NULL,
  `fkIdCampeonato` INT NOT NULL,
  `fkIdEquipo` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_posicion_campeonato1_idx` (`fkIdCampeonato` ASC) VISIBLE,
  INDEX `fk_posicion_equipo1_idx` (`fkIdEquipo` ASC) VISIBLE,
  CONSTRAINT `fk_posicion_campeonato1`
    FOREIGN KEY (`fkIdCampeonato`)
    REFERENCES `bdPolideportivo`.`campeonato` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_posicion_equipo1`
    FOREIGN KEY (`fkIdEquipo`)
    REFERENCES `bdPolideportivo`.`equipo` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`tipoCampeonato`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`tipoCampeonato` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`tipoCampeonato` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `tipo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`pkId`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`campeonato`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`campeonato` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`campeonato` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `fechaInicio` DATE NOT NULL,
  `fechaFinal` DATE NOT NULL,
  `fkIdPosicion` INT NOT NULL,
  `fkIdDeporte` INT NOT NULL,
  `fkIdTipoCampeonato` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_campeonato_posicion1_idx` (`fkIdPosicion` ASC) VISIBLE,
  INDEX `fk_campeonato_deporte1_idx` (`fkIdDeporte` ASC) VISIBLE,
  INDEX `fk_campeonato_tipo_campeonato1_idx` (`fkIdTipoCampeonato` ASC) VISIBLE,
  CONSTRAINT `fk_campeonato_posicion1`
    FOREIGN KEY (`fkIdPosicion`)
    REFERENCES `bdPolideportivo`.`posicion` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_campeonato_deporte1`
    FOREIGN KEY (`fkIdDeporte`)
    REFERENCES `bdPolideportivo`.`deporte` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_campeonato_tipo_campeonato1`
    FOREIGN KEY (`fkIdTipoCampeonato`)
    REFERENCES `bdPolideportivo`.`tipoCampeonato` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`participante`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`participante` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`participante` (
  `id` INT NOT NULL,
  `equipos` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  `fase` VARCHAR(45) NULL,
  `campeonato_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_participante_campeonato1_idx` (`campeonato_id` ASC) VISIBLE,
  CONSTRAINT `fk_participante_campeonato1`
    FOREIGN KEY (`campeonato_id`)
    REFERENCES `bdPolideportivo`.`campeonato` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`empleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`empleado` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`empleado` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `rol` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`pkId`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`resultado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`resultado` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`resultado` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `anotacionEquipo1` INT NOT NULL,
  `anotacionEquipo2` INT NOT NULL,
  PRIMARY KEY (`pkId`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`partido`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`partido` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`partido` (
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
    REFERENCES `bdPolideportivo`.`campeonato` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_partido_empleado1`
    FOREIGN KEY (`fkIdEmpleado`)
    REFERENCES `bdPolideportivo`.`empleado` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_partido_resultado1`
    FOREIGN KEY (`fkIdResultado`)
    REFERENCES `bdPolideportivo`.`resultado` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`anotacion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`anotacion` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`anotacion` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `cantidad` INT NOT NULL,
  `fkIdJugador` INT NOT NULL,
  `fkIdPartido` INT NOT NULL,
  PRIMARY KEY (`pkId`),
  INDEX `fk_puntos_jugador1_idx` (`fkIdJugador` ASC) VISIBLE,
  INDEX `fk_puntos_partido1_idx` (`fkIdPartido` ASC) VISIBLE,
  CONSTRAINT `fk_puntos_jugador1`
    FOREIGN KEY (`fkIdJugador`)
    REFERENCES `bdPolideportivo`.`jugador` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_puntos_partido1`
    FOREIGN KEY (`fkIdPartido`)
    REFERENCES `bdPolideportivo`.`partido` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bdPolideportivo`.`entrenador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bdPolideportivo`.`entrenador` ;

CREATE TABLE IF NOT EXISTS `bdPolideportivo`.`entrenador` (
  `pkId` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `fkIdEquipo` INT NOT NULL,
  PRIMARY KEY (`pkId`, `fkIdEquipo`),
  INDEX `fk_entrenador_equipo1_idx` (`fkIdEquipo` ASC) VISIBLE,
  CONSTRAINT `fk_entrenador_equipo1`
    FOREIGN KEY (`fkIdEquipo`)
    REFERENCES `bdPolideportivo`.`equipo` (`pkId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
