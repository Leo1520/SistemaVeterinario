-- Script para crear la tabla de usuarios en la base de datos dbveterinaria
USE dbveterinaria;
GO

-- Verificar si la tabla existe y eliminarla si es necesario
IF OBJECT_ID('dbo.Usuarios', 'U') IS NOT NULL
    DROP TABLE dbo.Usuarios;
GO

-- Crear la tabla de usuarios
CREATE TABLE dbo.Usuarios (
    UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario NVARCHAR(50) NOT NULL UNIQUE,
    Contrasena NVARCHAR(255) NOT NULL,
    NombreCompleto NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Telefono NVARCHAR(20),
    Rol NVARCHAR(20) NOT NULL DEFAULT 'Usuario',
    Estado BIT NOT NULL DEFAULT 1,
    FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
    FechaUltimoAcceso DATETIME NULL,
    CreadoPor NVARCHAR(50) DEFAULT 'Sistema',
    ModificadoPor NVARCHAR(50) NULL,
    FechaModificacion DATETIME NULL
);
GO

-- Crear indices para mejorar el rendimiento
CREATE INDEX IX_Usuarios_NombreUsuario ON dbo.Usuarios(NombreUsuario);
CREATE INDEX IX_Usuarios_Email ON dbo.Usuarios(Email);
CREATE INDEX IX_Usuarios_Rol ON dbo.Usuarios(Rol);
GO

-- Insertar usuario administrador por defecto
INSERT INTO dbo.Usuarios (
    NombreUsuario, 
    Contrasena, 
    NombreCompleto, 
    Email, 
    Telefono, 
    Rol, 
    Estado
) VALUES (
    'admin',
    'admin123',
    'Administrador del Sistema',
    'admin@veterinaria.com',
    '0000000000',
    'Administrador',
    1
);
GO

-- Verificar que la tabla se creo correctamente
SELECT COUNT(*) AS TotalUsuarios FROM dbo.Usuarios;
GO

PRINT 'Tabla de usuarios creada exitosamente con usuario administrador por defecto';
PRINT 'Usuario: admin';
PRINT 'Contrasena: admin123';
GO