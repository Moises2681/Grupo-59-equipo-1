-- MySQL Script generated by MySQL Workbench
-- Sat Sep 25 21:22:54 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Table `usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `usuario` (
  `usu_Id` INT NOT NULL AUTO_INCREMENT,
  `usu_cedula` VARCHAR(45) NOT NULL,
  `usu_nombre` VARCHAR(45) NOT NULL,
  `usu_apellidos` VARCHAR(45) NOT NULL,
  `usu_direccion` VARCHAR(80) NOT NULL,
  `usu_telefono` VARCHAR(45) NOT NULL,
  `usu_correo` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`usu_Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `marca`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `marca` (
  `mar_Id` INT NOT NULL AUTO_INCREMENT,
  `mar_marca` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`mar_Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tipoCaja`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tipoCaja` (
  `tipCaj_Id` INT NOT NULL AUTO_INCREMENT,
  `tipCaja_marca` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`tipCaj_Id`))
ENGINE = InnoDB
COMMENT = '	';


-- -----------------------------------------------------
-- Table `tipoCombustible`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tipoCombustible` (
  `tipCom_Id` INT NOT NULL AUTO_INCREMENT,
  `tipCom_combustible` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`tipCom_Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `hojaVida`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `hojaVida` (
  `hojVid_Id` INT NOT NULL AUTO_INCREMENT,
  `hojVid_codigo` VARCHAR(45) NOT NULL,
  `hojVid_fechaTecnomecanica` DATE NOT NULL,
  `hojVid_fechaSoat` DATE NOT NULL,
  PRIMARY KEY (`hojVid_Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `vehiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `vehiculo` (
  `veh_Id` INT NOT NULL AUTO_INCREMENT,
  `veh_placa` VARCHAR(45) NOT NULL,
  `veh_modelo` INT NULL,
  `veh_capacodad` VARCHAR(45) NULL,
  `veh_color` VARCHAR(45) NULL,
  `veh_imagen` VARCHAR(45) NULL,
  `veh_hojaVida_Id` INT NOT NULL,
  `veh_marca_Id` INT NOT NULL,
  `veh_tipoCaja_Id` INT NOT NULL,
  `veh_tipoCombustible_Id` INT NOT NULL,
  PRIMARY KEY (`veh_Id`),
  CONSTRAINT `fk_vehiculo_hojaVida1`
    FOREIGN KEY (`veh_hojaVida_Id`)
    REFERENCES `hojaVida` (`hojVid_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vehiculo_marca1`
    FOREIGN KEY (`veh_marca_Id`)
    REFERENCES `marca` (`mar_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vehiculo_tipoCaja1`
    FOREIGN KEY (`veh_tipoCaja_Id`)
    REFERENCES `tipoCaja` (`tipCaj_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vehiculo_tipoCombustible1`
    FOREIGN KEY (`veh_tipoCombustible_Id`)
    REFERENCES `tipoCombustible` (`tipCom_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `fk_vehiculo_hojaVida1_idx` ON `vehiculo` (`veh_hojaVida_Id` ASC) VISIBLE;

CREATE INDEX `fk_vehiculo_marca1_idx` ON `vehiculo` (`veh_marca_Id` ASC) VISIBLE;

CREATE INDEX `fk_vehiculo_tipoCaja1_idx` ON `vehiculo` (`veh_tipoCaja_Id` ASC) VISIBLE;

CREATE INDEX `fk_vehiculo_tipoCombustible1_idx` ON `vehiculo` (`veh_tipoCombustible_Id` ASC) VISIBLE;


-- -----------------------------------------------------
-- Table `estadoEntrega`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `estadoEntrega` (
  `estEnt_Id` INT NOT NULL AUTO_INCREMENT,
  `estEnt_estadoEntrega` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`estEnt_Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `estadoAlquiler`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `estadoAlquiler` (
  `estAlq_Id` INT NOT NULL AUTO_INCREMENT,
  `estAlq_estadoAlquiler` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`estAlq_Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `formaPago`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `formaPago` (
  `forPag_Id` INT NOT NULL AUTO_INCREMENT,
  `forPag_nombre` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`forPag_Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `alquiler`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `alquiler` (
  `alq_Id` INT NOT NULL AUTO_INCREMENT,
  `alq_codigo` VARCHAR(45) NOT NULL,
  `alq_fechaInicio` DATE NOT NULL,
  `alq_fechaFin` DATE NOT NULL,
  `alq_lugarRecogida` VARCHAR(45) NOT NULL,
  `alq_lugarEntrega` VARCHAR(45) NOT NULL,
  `alq_usuario_Id` INT NOT NULL,
  `alq_vehiculo_Id` INT NOT NULL,
  `alq_estadoEntrega_Id` INT NOT NULL,
  `alq_estadoAlquiler_Id` INT NOT NULL,
  `alq_formaPago` INT NULL,
  `alq_valorPagar` INT NULL,
  `alq_formaPago_Id` INT NOT NULL,
  PRIMARY KEY (`alq_Id`),
  CONSTRAINT `fk_alquiler_usuario`
    FOREIGN KEY (`alq_usuario_Id`)
    REFERENCES `usuario` (`usu_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_alquiler_vehiculo1`
    FOREIGN KEY (`alq_vehiculo_Id`)
    REFERENCES `vehiculo` (`veh_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_alquiler_estadoEntrega1`
    FOREIGN KEY (`alq_estadoEntrega_Id`)
    REFERENCES `estadoEntrega` (`estEnt_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_alquiler_estadoAlquiler1`
    FOREIGN KEY (`alq_estadoAlquiler_Id`)
    REFERENCES `estadoAlquiler` (`estAlq_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_alquiler_formaPago1`
    FOREIGN KEY (`alq_formaPago_Id`)
    REFERENCES `formaPago` (`forPag_Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE INDEX `fk_alquiler_usuario_idx` ON `alquiler` (`alq_usuario_Id` ASC) VISIBLE;

CREATE INDEX `fk_alquiler_vehiculo1_idx` ON `alquiler` (`alq_vehiculo_Id` ASC) VISIBLE;

CREATE INDEX `fk_alquiler_estadoEntrega1_idx` ON `alquiler` (`alq_estadoEntrega_Id` ASC) VISIBLE;

CREATE INDEX `fk_alquiler_estadoAlquiler1_idx` ON `alquiler` (`alq_estadoAlquiler_Id` ASC) VISIBLE;

CREATE INDEX `fk_alquiler_formaPago1_idx` ON `alquiler` (`alq_formaPago_Id` ASC) VISIBLE;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;