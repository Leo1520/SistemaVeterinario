-- Script para crear la base de datos del sistema veterinario
USE master;
GO

-- Verificar si la base de datos existe y eliminarla si es necesario
IF DB_ID('dbveterinaria') IS NOT NULL
BEGIN
    ALTER DATABASE dbveterinaria SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE dbveterinaria;
END
GO

-- Crear la base de datos
CREATE DATABASE dbveterinaria
ON 
(
    NAME = 'dbveterinaria_Data',
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbveterinaria.mdf',
    SIZE = 100MB,
    MAXSIZE = 1GB,
    FILEGROWTH = 10MB
)
LOG ON
(
    NAME = 'dbveterinaria_Log',
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbveterinaria.ldf',
    SIZE = 10MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 1MB
);
GO

-- Verificar que la base de datos se creó correctamente
USE dbveterinaria;
GO

PRINT 'Base de datos dbveterinaria creada exitosamente';
GO