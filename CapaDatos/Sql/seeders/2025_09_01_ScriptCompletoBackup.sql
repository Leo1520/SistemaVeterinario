USE [master]
GO
/****** Object:  Database [Sistema_Veterinario]    Script Date: 01/09/2025 14:32:30 ******/
CREATE DATABASE [Sistema_Veterinario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sistema_Veterinario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Sistema_Veterinario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sistema_Veterinario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Sistema_Veterinario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Sistema_Veterinario] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sistema_Veterinario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sistema_Veterinario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Sistema_Veterinario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sistema_Veterinario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sistema_Veterinario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Sistema_Veterinario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sistema_Veterinario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Sistema_Veterinario] SET  MULTI_USER 
GO
ALTER DATABASE [Sistema_Veterinario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sistema_Veterinario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sistema_Veterinario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sistema_Veterinario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sistema_Veterinario] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sistema_Veterinario] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Sistema_Veterinario] SET QUERY_STORE = ON
GO
ALTER DATABASE [Sistema_Veterinario] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Sistema_Veterinario]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](20) NOT NULL,
	[email] [varchar](255) NULL,
	[direccion] [varchar](255) NULL,
	[telefono] [varchar](20) NULL,
	[activo] [bit] NOT NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persona_fisica]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona_fisica](
	[id] [int] NOT NULL,
	[ci] [varchar](15) NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[fecha_nacimiento] [date] NULL,
	[genero] [char](1) NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_persona_fisica] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persona_juridica]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona_juridica](
	[id] [int] NOT NULL,
	[razon_social] [varchar](255) NOT NULL,
	[nit] [varchar](20) NULL,
	[encargado_nombre] [varchar](255) NULL,
	[encargado_cargo] [varchar](100) NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_persona_juridica] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_PersonasCompletas]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Vistas
CREATE VIEW [dbo].[VW_PersonasCompletas] AS
SELECT 
    p.id,
    p.tipo,
    p.email,
    p.direccion,
    p.telefono,
    p.activo,
    p.created_at,
    p.updated_at,
    pf.ci,
    pf.nombre,
    pf.apellido,
    pf.fecha_nacimiento,
    pf.genero,
    CASE
        WHEN p.tipo = 'Física' THEN CONCAT(pf.nombre, ' ', pf.apellido)
        ELSE NULL
    END as nombre_completo,
    pj.razon_social,
    pj.nit,
    pj.encargado_nombre,
    pj.encargado_cargo,
    CASE
        WHEN p.tipo = 'Física' THEN CONCAT(pf.nombre, ' ', pf.apellido)
        WHEN p.tipo = 'Jurídica' THEN pj.razon_social
        ELSE 'Sin nombre'
    END as nombre_mostrar
FROM persona p
    LEFT JOIN persona_fisica pf ON p.id = pf.id AND p.tipo = 'Física'
    LEFT JOIN persona_juridica pj ON p.id = pj.id AND p.tipo = 'Jurídica';
GO
/****** Object:  Table [dbo].[animal]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[animal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[especie] [varchar](50) NOT NULL,
	[raza] [varchar](100) NULL,
	[fecha_nacimiento] [date] NULL,
	[peso] [decimal](5, 2) NULL,
	[color] [varchar](50) NULL,
	[genero] [char](1) NULL,
	[esterilizado] [bit] NULL,
	[microchip] [varchar](50) NULL,
	[persona_id] [int] NOT NULL,
	[activo] [bit] NOT NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_animal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_AnimalesConPropietario]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_AnimalesConPropietario] AS
SELECT 
    a.id,
    a.nombre as animal_nombre,
    a.especie,
    a.raza,
    a.fecha_nacimiento,
    a.peso,
    a.color,
    a.genero,
    a.esterilizado,
    a.microchip,
    a.activo,
    a.created_at,
    a.updated_at,
    p.tipo as tipo_propietario,
    CASE
        WHEN p.tipo = 'Física' THEN CONCAT(pf.nombre, ' ', pf.apellido)
        WHEN p.tipo = 'Jurídica' THEN pj.razon_social
        ELSE 'Sin propietario'
    END as propietario,
    p.telefono as telefono_propietario,
    p.email as email_propietario,
    p.direccion as direccion_propietario,
    pf.ci as ci_propietario,
    pj.nit as nit_propietario
FROM animal a
    INNER JOIN persona p ON a.persona_id = p.id
    LEFT JOIN persona_fisica pf ON p.id = pf.id AND p.tipo = 'Física'
    LEFT JOIN persona_juridica pj ON p.id = pj.id AND p.tipo = 'Jurídica'
WHERE a.activo = 1;
GO
/****** Object:  Table [dbo].[personal]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[contrasena] [varchar](255) NOT NULL,
	[telefono] [varchar](20) NULL,
	[direccion] [varchar](255) NULL,
	[fecha_contratacion] [date] NOT NULL,
	[salario] [decimal](10, 2) NULL,
	[rol] [varchar](20) NOT NULL,
	[activo] [bit] NOT NULL,
	[fecha_ultimo_acceso] [datetime] NULL,
	[creado_por] [varchar](50) NULL,
	[modificado_por] [varchar](50) NULL,
	[fecha_modificacion] [datetime] NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_personal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personal_veterinario]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personal_veterinario](
	[id] [int] NOT NULL,
	[num_licencia] [varchar](50) NOT NULL,
	[especialidad] [varchar](100) NULL,
	[universidad] [varchar](200) NULL,
	[anios_experiencia] [int] NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_personal_veterinario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personal_auxiliar]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personal_auxiliar](
	[id] [int] NOT NULL,
	[area] [varchar](100) NULL,
	[turno] [varchar](10) NOT NULL,
	[nivel] [varchar](20) NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_personal_auxiliar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_PersonalCompleto]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_PersonalCompleto] AS
SELECT 
    p.id,
    p.nombre,
    p.apellido,
    CONCAT(p.nombre, ' ', p.apellido) AS nombre_completo,
    p.email,
    p.usuario,
    p.telefono,
    p.direccion,
    p.fecha_contratacion,
    p.salario,
    p.activo,
    p.created_at,
    p.updated_at,
    CASE
        WHEN pv.id IS NOT NULL THEN 'Veterinario'
        WHEN pa.id IS NOT NULL THEN 'Auxiliar'
        ELSE 'Sin especialidad'
    END as tipo_personal,
    pv.num_licencia,
    pv.especialidad,
    pv.universidad,
    pv.anios_experiencia,
    pa.area,
    pa.turno,
    pa.nivel
FROM personal p
    LEFT JOIN personal_veterinario pv ON p.id = pv.id
    LEFT JOIN personal_auxiliar pa ON p.id = pa.id
WHERE p.activo = 1;
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[descripcion] [varchar](255) NULL,
	[activo] [bit] NOT NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_historico]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_historico](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[historico_id] [int] NOT NULL,
	[tipo_evento] [varchar](20) NOT NULL,
	[fecha_evento] [datetime2](3) NOT NULL,
	[observaciones] [text] NULL,
	[tratamiento] [text] NULL,
	[medicamentos] [text] NULL,
	[dosis] [varchar](255) NULL,
	[veterinario_id] [int] NULL,
	[peso_animal] [decimal](5, 2) NULL,
	[temperatura] [decimal](4, 1) NULL,
	[cobrado] [bit] NOT NULL,
	[costo] [decimal](10, 2) NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_detalle_historico] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_productos]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_productos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[factura_id] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [decimal](10, 2) NOT NULL,
	[descuento_unitario] [decimal](10, 2) NOT NULL,
	[subtotal] [decimal](10, 2) NOT NULL,
	[receta_verificada] [bit] NOT NULL,
	[lote] [varchar](50) NULL,
	[fecha_vencimiento_producto] [date] NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_detalle_productos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_servicios]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_servicios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[factura_id] [int] NOT NULL,
	[diagnostico_id] [int] NOT NULL,
	[detalle_historico_id] [int] NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [decimal](10, 2) NOT NULL,
	[descuento_unitario] [decimal](10, 2) NOT NULL,
	[subtotal] [decimal](10, 2) NOT NULL,
	[veterinario_id] [int] NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_detalle_servicios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diagnostico]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diagnostico](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](20) NULL,
	[nombre] [varchar](200) NOT NULL,
	[descripcion] [text] NULL,
	[precio_base] [decimal](10, 2) NOT NULL,
	[categoria_diagnostico] [varchar](100) NULL,
	[requiere_equipamiento] [bit] NOT NULL,
	[activo] [bit] NOT NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_diagnostico] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero_factura] [varchar](50) NOT NULL,
	[fecha_emision] [date] NOT NULL,
	[fecha_vencimiento] [date] NULL,
	[persona_id] [int] NOT NULL,
	[subtotal] [decimal](10, 2) NOT NULL,
	[impuestos] [decimal](10, 2) NOT NULL,
	[descuentos] [decimal](10, 2) NOT NULL,
	[total] [decimal](10, 2) NOT NULL,
	[estado] [varchar](20) NOT NULL,
	[notas] [text] NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_factura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historico]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historico](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[animal_id] [int] NOT NULL,
	[notas_generales] [text] NULL,
	[alergias] [text] NULL,
	[condiciones_medicas] [text] NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_historico] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movimiento_inventario]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movimiento_inventario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[producto_id] [int] NOT NULL,
	[tipo_movimiento] [varchar](20) NOT NULL,
	[cantidad] [int] NOT NULL,
	[stock_anterior] [int] NOT NULL,
	[stock_nuevo] [int] NOT NULL,
	[motivo] [varchar](255) NULL,
	[referencia] [varchar](100) NULL,
	[ubicacion_origen_id] [int] NULL,
	[ubicacion_destino_id] [int] NULL,
	[usuario] [varchar](50) NULL,
	[fecha_movimiento] [datetime2](3) NOT NULL,
	[created_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_movimiento_inventario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NULL,
	[nombre] [varchar](255) NOT NULL,
	[descripcion] [text] NULL,
	[precio] [decimal](10, 2) NOT NULL,
	[stock_minimo] [int] NOT NULL,
	[stock_actual] [int] NOT NULL,
	[requiere_receta] [bit] NOT NULL,
	[categoria_id] [int] NOT NULL,
	[activo] [bit] NOT NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock_ubicacion]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock_ubicacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[producto_id] [int] NOT NULL,
	[ubicacion_id] [int] NOT NULL,
	[stock_actual] [int] NOT NULL,
	[stock_reservado] [int] NOT NULL,
	[fecha_ultimo_movimiento] [datetime2](3) NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_stock_ubicacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ubicacion_almacen]    Script Date: 01/09/2025 14:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ubicacion_almacen](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](20) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[descripcion] [varchar](255) NULL,
	[activo] [bit] NOT NULL,
	[created_at] [datetime2](3) NOT NULL,
	[updated_at] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_ubicacion_almacen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[animal] ON 

INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (73, N'Max', N'Perro', N'Labrador', CAST(N'2020-03-15' AS Date), CAST(25.50 AS Decimal(5, 2)), N'Dorado', N'M', 1, N'MC001234567890', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (74, N'Bella', N'Perro', N'Golden Retriever', CAST(N'2019-07-22' AS Date), CAST(28.00 AS Decimal(5, 2)), N'Dorado', N'F', 1, N'MC001234567891', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (75, N'Rocky', N'Perro', N'Pastor Alemán', CAST(N'2021-01-10' AS Date), CAST(32.00 AS Decimal(5, 2)), N'Negro y Marrón', N'M', 0, N'MC001234567892', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (76, N'Duke', N'Perro', N'Rottweiler', CAST(N'2020-09-14' AS Date), CAST(38.00 AS Decimal(5, 2)), N'Negro', N'M', 1, N'MC001234567893', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (77, N'Atlas', N'Perro', N'Gran Danés', CAST(N'2019-12-03' AS Date), CAST(45.00 AS Decimal(5, 2)), N'Arlequín', N'M', 1, N'MC001234567894', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (78, N'Zeus', N'Perro', N'San Bernardo', CAST(N'2020-06-18' AS Date), CAST(42.00 AS Decimal(5, 2)), N'Marrón y Blanco', N'M', 0, N'MC001234567895', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (79, N'Luna', N'Perro', N'Husky Siberiano', CAST(N'2021-04-25' AS Date), CAST(23.00 AS Decimal(5, 2)), N'Gris y Blanco', N'F', 1, N'MC001234567896', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (80, N'Sasha', N'Perro', N'Border Collie', CAST(N'2020-11-08' AS Date), CAST(20.00 AS Decimal(5, 2)), N'Negro y Blanco', N'F', 1, N'MC001234567897', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (81, N'Charlie', N'Perro', N'Bulldog Francés', CAST(N'2020-11-30' AS Date), CAST(12.00 AS Decimal(5, 2)), N'Atigrado', N'M', 1, N'MC001234567898', 9, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (82, N'Milo', N'Perro', N'Cocker Spaniel', CAST(N'2021-08-12' AS Date), CAST(15.00 AS Decimal(5, 2)), N'Dorado', N'M', 1, N'MC001234567899', 10, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (83, N'Lola', N'Perro', N'Beagle', CAST(N'2022-02-28' AS Date), CAST(13.00 AS Decimal(5, 2)), N'Tricolor', N'F', 0, N'MC001234567900', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (84, N'Buddy', N'Perro', N'Bulldog Inglés', CAST(N'2019-10-15' AS Date), CAST(18.00 AS Decimal(5, 2)), N'Blanco', N'M', 1, N'MC001234567901', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (85, N'Daisy', N'Perro', N'Boxer', CAST(N'2020-05-20' AS Date), CAST(22.00 AS Decimal(5, 2)), N'Atigrado', N'F', 1, N'MC001234567902', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (86, N'Cooper', N'Perro', N'Springer Spaniel', CAST(N'2021-12-07' AS Date), CAST(16.00 AS Decimal(5, 2)), N'Hígado y Blanco', N'M', 0, N'MC001234567903', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (87, N'Zoe', N'Perro', N'Pointer', CAST(N'2020-07-13' AS Date), CAST(19.00 AS Decimal(5, 2)), N'Blanco y Naranja', N'F', 1, N'MC001234567904', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (88, N'Rex', N'Perro', N'Setter Irlandés', CAST(N'2019-09-05' AS Date), CAST(24.00 AS Decimal(5, 2)), N'Castaño', N'M', 1, N'MC001234567905', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (89, N'Luna', N'Perro', N'Chihuahua', CAST(N'2022-05-08' AS Date), CAST(2.50 AS Decimal(5, 2)), N'Blanco', N'F', 1, N'MC001234567906', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (90, N'Peanut', N'Perro', N'Yorkshire Terrier', CAST(N'2021-11-22' AS Date), CAST(3.20 AS Decimal(5, 2)), N'Dorado y Negro', N'M', 0, N'MC001234567907', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (91, N'Princess', N'Perro', N'Maltés', CAST(N'2020-04-17' AS Date), CAST(2.80 AS Decimal(5, 2)), N'Blanco', N'F', 1, N'MC001234567908', 9, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (92, N'Gizmo', N'Perro', N'Pomerania', CAST(N'2021-07-01' AS Date), CAST(3.50 AS Decimal(5, 2)), N'Naranja', N'M', 1, N'MC001234567909', 10, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (93, N'Coco', N'Perro', N'Shih Tzu', CAST(N'2020-12-14' AS Date), CAST(4.20 AS Decimal(5, 2)), N'Dorado y Blanco', N'F', 1, N'MC001234567910', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (94, N'Bingo', N'Perro', N'Jack Russell', CAST(N'2021-03-30' AS Date), CAST(5.50 AS Decimal(5, 2)), N'Blanco y Marrón', N'M', 0, N'MC001234567911', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (95, N'Nala', N'Perro', N'Cavalier King Charles', CAST(N'2020-08-25' AS Date), CAST(6.00 AS Decimal(5, 2)), N'Tricolor', N'F', 1, N'MC001234567912', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (96, N'Oscar', N'Perro', N'Dachshund', CAST(N'2021-06-18' AS Date), CAST(7.20 AS Decimal(5, 2)), N'Negro y Fuego', N'M', 1, N'MC001234567913', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (97, N'Kira', N'Perro', N'Akita', CAST(N'2019-11-12' AS Date), CAST(26.00 AS Decimal(5, 2)), N'Blanco', N'F', 1, N'MC001234567914', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (98, N'Thor', N'Perro', N'Doberman', CAST(N'2020-01-28' AS Date), CAST(30.00 AS Decimal(5, 2)), N'Negro y Fuego', N'M', 1, N'MC001234567915', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (99, N'Maya', N'Perro', N'Weimaraner', CAST(N'2021-09-15' AS Date), CAST(21.00 AS Decimal(5, 2)), N'Plateado', N'F', 0, N'MC001234567916', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (100, N'Bruno', N'Perro', N'Mastín Español', CAST(N'2019-05-03' AS Date), CAST(55.00 AS Decimal(5, 2)), N'Leonado', N'M', 1, N'MC001234567917', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (101, N'Amber', N'Perro', N'Vizsla', CAST(N'2020-10-20' AS Date), CAST(18.00 AS Decimal(5, 2)), N'Dorado Rojizo', N'F', 1, N'MC001234567918', 9, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (102, N'Rocco', N'Perro', N'Pitbull', CAST(N'2021-02-12' AS Date), CAST(27.00 AS Decimal(5, 2)), N'Blanco y Gris', N'M', 0, N'MC001234567919', 10, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (103, N'Lily', N'Perro', N'Caniche', CAST(N'2020-06-07' AS Date), CAST(8.00 AS Decimal(5, 2)), N'Negro', N'F', 1, N'MC001234567920', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (104, N'Diesel', N'Perro', N'Bullmastiff', CAST(N'2019-08-14' AS Date), CAST(48.00 AS Decimal(5, 2)), N'Atigrado', N'M', 1, N'MC001234567921', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (105, N'Sophie', N'Perro', N'Bichón Frisé', CAST(N'2021-12-25' AS Date), CAST(4.80 AS Decimal(5, 2)), N'Blanco', N'F', 1, N'MC001234567922', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (106, N'Tyson', N'Perro', N'Cane Corso', CAST(N'2020-03-09' AS Date), CAST(41.00 AS Decimal(5, 2)), N'Negro', N'M', 0, N'MC001234567923', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (107, N'Ruby', N'Perro', N'Basenji', CAST(N'2021-05-16' AS Date), CAST(9.50 AS Decimal(5, 2)), N'Castaño y Blanco', N'F', 1, N'MC001234567924', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (108, N'Storm', N'Perro', N'Pastor Belga', CAST(N'2020-07-28' AS Date), CAST(25.00 AS Decimal(5, 2)), N'Negro', N'M', 1, N'MC001234567925', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (109, N'Mia', N'Perro', N'Galgo', CAST(N'2019-12-11' AS Date), CAST(22.00 AS Decimal(5, 2)), N'Blanco y Marrón', N'F', 1, N'MC001234567926', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (110, N'Oreo', N'Perro', N'Boston Terrier', CAST(N'2021-10-04' AS Date), CAST(6.80 AS Decimal(5, 2)), N'Negro y Blanco', N'M', 0, N'MC001234567927', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (111, N'Stella', N'Perro', N'Schnauzer', CAST(N'2020-04-21' AS Date), CAST(11.00 AS Decimal(5, 2)), N'Sal y Pimienta', N'F', 1, N'MC001234567928', 9, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (112, N'Bandit', N'Perro', N'Australian Shepherd', CAST(N'2021-01-18' AS Date), CAST(23.00 AS Decimal(5, 2)), N'Azul Mirlo', N'M', 1, N'MC001234567929', 10, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (113, N'Misu', N'Gato', N'Persa', CAST(N'2021-04-20' AS Date), CAST(4.20 AS Decimal(5, 2)), N'Gris', N'F', 1, N'MC002234567895', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (114, N'Simba', N'Gato', N'Maine Coon', CAST(N'2019-12-05' AS Date), CAST(6.80 AS Decimal(5, 2)), N'Naranja', N'M', 1, N'MC002234567896', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (115, N'Nala', N'Gato', N'Siamés', CAST(N'2022-02-14' AS Date), CAST(3.50 AS Decimal(5, 2)), N'Crema', N'F', 1, N'MC002234567897', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (116, N'Garfield', N'Gato', N'Común Europeo', CAST(N'2020-08-18' AS Date), CAST(5.00 AS Decimal(5, 2)), N'Naranja y Blanco', N'M', 0, N'MC002234567898', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (117, N'Mittens', N'Gato', N'Bengalí', CAST(N'2021-10-12' AS Date), CAST(4.80 AS Decimal(5, 2)), N'Leopardo', N'F', 1, N'MC002234567899', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (118, N'Shadow', N'Gato', N'Bombay', CAST(N'2020-06-30' AS Date), CAST(4.00 AS Decimal(5, 2)), N'Negro', N'M', 1, N'MC002234567900', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (119, N'Luna', N'Gato', N'Ragdoll', CAST(N'2021-03-17' AS Date), CAST(5.50 AS Decimal(5, 2)), N'Colorpoint', N'F', 1, N'MC002234567901', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (120, N'Felix', N'Gato', N'British Shorthair', CAST(N'2019-11-08' AS Date), CAST(5.80 AS Decimal(5, 2)), N'Azul', N'M', 0, N'MC002234567902', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (121, N'Whiskers', N'Gato', N'Scottish Fold', CAST(N'2020-09-22' AS Date), CAST(4.30 AS Decimal(5, 2)), N'Plateado', N'M', 1, N'MC002234567903', 9, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (122, N'Princess', N'Gato', N'Angora Turco', CAST(N'2021-07-05' AS Date), CAST(3.80 AS Decimal(5, 2)), N'Blanco', N'F', 1, N'MC002234567904', 10, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (123, N'Tiger', N'Gato', N'Tabby', CAST(N'2020-12-19' AS Date), CAST(4.50 AS Decimal(5, 2)), N'Atigrado', N'M', 0, N'MC002234567905', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (124, N'Chloe', N'Gato', N'Russian Blue', CAST(N'2021-05-28' AS Date), CAST(3.90 AS Decimal(5, 2)), N'Azul', N'F', 1, N'MC002234567906', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (125, N'Oliver', N'Gato', N'Manx', CAST(N'2020-02-11' AS Date), CAST(4.70 AS Decimal(5, 2)), N'Marrón', N'M', 1, N'MC002234567907', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (126, N'Bella', N'Gato', N'Abisinio', CAST(N'2021-08-14' AS Date), CAST(3.20 AS Decimal(5, 2)), N'Ruddy', N'F', 0, N'MC002234567908', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (127, N'Smokey', N'Gato', N'Chartreux', CAST(N'2019-10-27' AS Date), CAST(5.20 AS Decimal(5, 2)), N'Gris Azulado', N'M', 1, N'MC002234567909', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (128, N'Zara', N'Gato', N'Oriental Shorthair', CAST(N'2020-04-15' AS Date), CAST(3.10 AS Decimal(5, 2)), N'Negro', N'F', 1, N'MC002234567910', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (129, N'Max', N'Gato', N'Sphynx', CAST(N'2021-11-20' AS Date), CAST(3.60 AS Decimal(5, 2)), N'Rosa', N'M', 1, N'MC002234567911', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (130, N'Jade', N'Gato', N'Burmés', CAST(N'2020-07-03' AS Date), CAST(4.10 AS Decimal(5, 2)), N'Champagne', N'F', 0, N'MC002234567912', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (131, N'Romeo', N'Gato', N'Devon Rex', CAST(N'2021-01-09' AS Date), CAST(2.80 AS Decimal(5, 2)), N'Chocolate', N'M', 1, N'MC002234567913', 9, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (132, N'Cleo', N'Gato', N'Egipcio Mau', CAST(N'2020-05-26' AS Date), CAST(3.70 AS Decimal(5, 2)), N'Plateado', N'F', 1, N'MC002234567914', 10, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (133, N'Milo', N'Gato', N'Tonkinés', CAST(N'2021-09-12' AS Date), CAST(4.00 AS Decimal(5, 2)), N'Natural Mink', N'M', 0, N'MC002234567915', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (134, N'Lola', N'Gato', N'Cornish Rex', CAST(N'2020-11-07' AS Date), CAST(3.00 AS Decimal(5, 2)), N'Blanco', N'F', 1, N'MC002234567916', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (135, N'Jasper', N'Gato', N'Selkirk Rex', CAST(N'2021-06-23' AS Date), CAST(4.60 AS Decimal(5, 2)), N'Crema', N'M', 1, N'MC002234567917', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (136, N'Luna', N'Gato', N'Himalayo', CAST(N'2019-08-16' AS Date), CAST(5.10 AS Decimal(5, 2)), N'Colorpoint', N'F', 1, N'MC002234567918', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (137, N'Oscar', N'Gato', N'Savannah', CAST(N'2020-10-01' AS Date), CAST(7.50 AS Decimal(5, 2)), N'Dorado Manchado', N'M', 0, N'MC002234567919', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (138, N'Misty', N'Gato', N'LaPerm', CAST(N'2021-04-08' AS Date), CAST(3.40 AS Decimal(5, 2)), N'Tortoiseshell', N'F', 1, N'MC002234567920', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (139, N'Bruno', N'Gato', N'Ragamuffin', CAST(N'2020-01-24' AS Date), CAST(6.20 AS Decimal(5, 2)), N'Bicolor', N'M', 1, N'MC002234567921', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (140, N'Sasha', N'Gato', N'Balinés', CAST(N'2021-12-10' AS Date), CAST(3.30 AS Decimal(5, 2)), N'Seal Point', N'F', 0, N'MC002234567922', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (141, N'Gizmo', N'Gato', N'Munchkin', CAST(N'2020-03-29' AS Date), CAST(2.90 AS Decimal(5, 2)), N'Calico', N'M', 1, N'MC002234567923', 9, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (142, N'Neko', N'Gato', N'Bobtail Japonés', CAST(N'2021-07-17' AS Date), CAST(3.80 AS Decimal(5, 2)), N'Mi-ke', N'F', 1, N'MC002234567924', 10, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (143, N'Polly', N'Ave', N'Loro Amazonas', CAST(N'2018-06-10' AS Date), CAST(0.45 AS Decimal(5, 2)), N'Verde', N'F', 0, N'MC004234567001', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (144, N'Tweety', N'Ave', N'Canario', CAST(N'2022-07-08' AS Date), CAST(0.03 AS Decimal(5, 2)), N'Amarillo', N'M', 0, N'MC004234567002', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (145, N'Rio', N'Ave', N'Guacamayo', CAST(N'2017-03-22' AS Date), CAST(1.20 AS Decimal(5, 2)), N'Azul y Amarillo', N'M', 0, N'MC004234567003', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (146, N'Coco', N'Ave', N'Cacatúa', CAST(N'2019-11-15' AS Date), CAST(0.60 AS Decimal(5, 2)), N'Blanco', N'F', 0, N'MC004234567004', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (147, N'Kiwi', N'Ave', N'Periquito', CAST(N'2021-09-03' AS Date), CAST(0.04 AS Decimal(5, 2)), N'Verde y Azul', N'M', 0, N'MC004234567005', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (148, N'Sunny', N'Ave', N'Conure Solar', CAST(N'2020-05-18' AS Date), CAST(0.12 AS Decimal(5, 2)), N'Naranja', N'F', 0, N'MC004234567006', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (149, N'Charlie', N'Ave', N'Gris Africano', CAST(N'2016-12-07' AS Date), CAST(0.50 AS Decimal(5, 2)), N'Gris', N'M', 0, N'MC004234567007', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (150, N'Ruby', N'Ave', N'Cardenal', CAST(N'2022-04-12' AS Date), CAST(0.05 AS Decimal(5, 2)), N'Rojo', N'F', 0, N'MC004234567008', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (151, N'Pepe', N'Ave', N'Agapornis', CAST(N'2021-08-25' AS Date), CAST(0.06 AS Decimal(5, 2)), N'Verde y Rosa', N'M', 0, N'MC004234567009', 9, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (152, N'Sky', N'Ave', N'Ninfa', CAST(N'2020-10-30' AS Date), CAST(0.09 AS Decimal(5, 2)), N'Gris y Amarillo', N'F', 0, N'MC004234567010', 10, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (153, N'Phoenix', N'Ave', N'Fénix Dorado', CAST(N'2019-02-14' AS Date), CAST(0.08 AS Decimal(5, 2)), N'Dorado', N'M', 0, N'MC004234567011', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (154, N'Luna', N'Ave', N'Diamante Mandarín', CAST(N'2022-01-20' AS Date), CAST(0.01 AS Decimal(5, 2)), N'Blanco y Negro', N'F', 0, N'MC004234567012', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (155, N'Echo', N'Ave', N'Loro Eclectus', CAST(N'2018-09-11' AS Date), CAST(0.40 AS Decimal(5, 2)), N'Verde', N'M', 0, N'MC004234567013', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (156, N'Pearl', N'Ave', N'Canario Belga', CAST(N'2021-06-05' AS Date), CAST(0.02 AS Decimal(5, 2)), N'Blanco', N'F', 0, N'MC004234567014', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (157, N'Mango', N'Ave', N'Loro de Meyer', CAST(N'2020-03-28' AS Date), CAST(0.15 AS Decimal(5, 2)), N'Verde y Azul', N'M', 0, N'MC004234567015', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (158, N'Stella', N'Ave', N'Jilguero', CAST(N'2022-11-02' AS Date), CAST(0.02 AS Decimal(5, 2)), N'Amarillo y Negro', N'F', 0, N'MC004234567016', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (159, N'Captain', N'Ave', N'Loro Pirata', CAST(N'2017-07-19' AS Date), CAST(0.35 AS Decimal(5, 2)), N'Verde y Rojo', N'M', 0, N'MC004234567017', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (160, N'Iris', N'Ave', N'Arcoíris Lorikeet', CAST(N'2021-12-16' AS Date), CAST(0.13 AS Decimal(5, 2)), N'Multicolor', N'F', 0, N'MC004234567018', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (161, N'Bolt', N'Ave', N'Halcón Peregrino', CAST(N'2019-04-07' AS Date), CAST(0.75 AS Decimal(5, 2)), N'Gris y Blanco', N'M', 0, N'MC004234567019', 9, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (162, N'Angel', N'Ave', N'Paloma Blanca', CAST(N'2020-08-23' AS Date), CAST(0.25 AS Decimal(5, 2)), N'Blanco', N'F', 0, N'MC004234567020', 10, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (163, N'Bunny', N'Conejo', N'Holandés', CAST(N'2022-03-25' AS Date), CAST(1.80 AS Decimal(5, 2)), N'Blanco y Negro', N'F', 1, N'MC003234567900', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (164, N'Coco', N'Conejo', N'Angora', CAST(N'2021-09-30' AS Date), CAST(2.20 AS Decimal(5, 2)), N'Blanco', N'M', 0, N'MC003234567901', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (165, N'Hoppy', N'Conejo', N'Rex', CAST(N'2020-11-14' AS Date), CAST(1.90 AS Decimal(5, 2)), N'Chinchilla', N'F', 1, N'MC003234567902', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (166, N'Cotton', N'Conejo', N'Lop Inglés', CAST(N'2021-05-07' AS Date), CAST(2.50 AS Decimal(5, 2)), N'Gris', N'M', 1, N'MC003234567903', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (167, N'Clover', N'Conejo', N'Cabeza de León', CAST(N'2022-01-19' AS Date), CAST(1.60 AS Decimal(5, 2)), N'Dorado', N'F', 0, N'MC003234567904', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (168, N'Nibbles', N'Conejo', N'Mini Lop', CAST(N'2021-07-28' AS Date), CAST(1.40 AS Decimal(5, 2)), N'Marrón', N'M', 1, N'MC003234567905', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (169, N'Daisy', N'Conejo', N'Gigante Flandes', CAST(N'2020-04-03' AS Date), CAST(4.20 AS Decimal(5, 2)), N'Gris Acero', N'F', 1, N'MC003234567906', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (170, N'Pepper', N'Conejo', N'Nueva Zelanda', CAST(N'2021-10-15' AS Date), CAST(3.10 AS Decimal(5, 2)), N'Blanco', N'M', 0, N'MC003234567907', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (171, N'Snowball', N'Conejo', N'Californiano', CAST(N'2022-08-22' AS Date), CAST(2.80 AS Decimal(5, 2)), N'Blanco y Negro', N'F', 1, N'MC003234567908', 9, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
GO
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (172, N'Oreo', N'Conejo', N'Holandés Enano', CAST(N'2021-02-11' AS Date), CAST(1.10 AS Decimal(5, 2)), N'Negro y Blanco', N'M', 1, N'MC003234567909', 10, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (173, N'Peanut', N'Hámster', N'Dorado', CAST(N'2023-01-15' AS Date), CAST(0.15 AS Decimal(5, 2)), N'Dorado', N'M', 0, N'MC005234567001', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (174, N'Nibbles', N'Hámster', N'Ruso', CAST(N'2023-02-20' AS Date), CAST(0.12 AS Decimal(5, 2)), N'Gris', N'F', 0, N'MC005234567002', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (175, N'Squeaky', N'Hámster', N'Chino', CAST(N'2022-12-05' AS Date), CAST(0.08 AS Decimal(5, 2)), N'Gris y Blanco', N'M', 0, N'MC005234567003', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (176, N'Fluffy', N'Cobaya', N'Peruana', CAST(N'2022-11-10' AS Date), CAST(0.90 AS Decimal(5, 2)), N'Tricolor', N'F', 1, N'MC005234567004', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (177, N'Patches', N'Cobaya', N'Americana', CAST(N'2021-08-17' AS Date), CAST(1.10 AS Decimal(5, 2)), N'Blanco y Marrón', N'M', 0, N'MC005234567005', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (178, N'Ginger', N'Cobaya', N'Abisinia', CAST(N'2022-06-03' AS Date), CAST(0.85 AS Decimal(5, 2)), N'Rojizo', N'F', 1, N'MC005234567006', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (179, N'Chip', N'Chinchilla', N'Estándar', CAST(N'2021-04-28' AS Date), CAST(0.60 AS Decimal(5, 2)), N'Gris', N'M', 0, N'MC005234567007', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (180, N'Dusty', N'Chinchilla', N'Beige', CAST(N'2022-09-14' AS Date), CAST(0.55 AS Decimal(5, 2)), N'Beige', N'F', 0, N'MC005234567008', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (181, N'Spike', N'Reptil', N'Iguana Verde', CAST(N'2019-04-15' AS Date), CAST(2.80 AS Decimal(5, 2)), N'Verde', N'M', 0, N'MC006234567001', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (182, N'Shelly', N'Reptil', N'Tortuga Rusa', CAST(N'2017-05-20' AS Date), CAST(0.80 AS Decimal(5, 2)), N'Marrón', N'F', 0, N'MC006234567002', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (183, N'Rex', N'Reptil', N'Dragón Barbudo', CAST(N'2020-08-12' AS Date), CAST(0.40 AS Decimal(5, 2)), N'Marrón y Amarillo', N'M', 0, N'MC006234567003', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (184, N'Slinky', N'Reptil', N'Pitón Bola', CAST(N'2018-11-30' AS Date), CAST(1.50 AS Decimal(5, 2)), N'Marrón y Negro', N'F', 0, N'MC006234567004', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (185, N'Gecko', N'Reptil', N'Gecko Leopardo', CAST(N'2021-07-18' AS Date), CAST(0.06 AS Decimal(5, 2)), N'Amarillo y Negro', N'M', 0, N'MC006234567005', 5, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (186, N'Emerald', N'Reptil', N'Camaleón', CAST(N'2020-02-25' AS Date), CAST(0.15 AS Decimal(5, 2)), N'Verde', N'F', 0, N'MC006234567006', 6, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (187, N'Slider', N'Reptil', N'Tortuga de Orejas Rojas', CAST(N'2019-09-07' AS Date), CAST(1.20 AS Decimal(5, 2)), N'Verde y Amarillo', N'M', 0, N'MC006234567007', 7, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (188, N'Scales', N'Reptil', N'Monitor de Sabana', CAST(N'2018-06-14' AS Date), CAST(3.50 AS Decimal(5, 2)), N'Gris y Negro', N'F', 0, N'MC006234567008', 8, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (189, N'Nemo', N'Pez', N'Pez Payaso', CAST(N'2023-03-01' AS Date), CAST(0.05 AS Decimal(5, 2)), N'Naranja y Blanco', N'M', 0, N'MC007234567001', 1, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (190, N'Dory', N'Pez', N'Tang Azul', CAST(N'2023-03-01' AS Date), CAST(0.08 AS Decimal(5, 2)), N'Azul', N'F', 0, N'MC007234567002', 2, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (191, N'Goldie', N'Pez', N'Goldfish', CAST(N'2022-11-20' AS Date), CAST(0.12 AS Decimal(5, 2)), N'Dorado', N'F', 0, N'MC007234567003', 3, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
INSERT [dbo].[animal] ([id], [nombre], [especie], [raza], [fecha_nacimiento], [peso], [color], [genero], [esterilizado], [microchip], [persona_id], [activo], [created_at], [updated_at]) VALUES (192, N'Bubbles', N'Pez', N'Betta', CAST(N'2023-01-10' AS Date), CAST(0.03 AS Decimal(5, 2)), N'Azul y Rojo', N'M', 0, N'MC007234567004', 4, 1, CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2), CAST(N'2025-09-01T12:49:57.9000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[animal] OFF
GO
SET IDENTITY_INSERT [dbo].[categoria] ON 

INSERT [dbo].[categoria] ([id], [nombre], [descripcion], [activo], [created_at], [updated_at]) VALUES (1, N'Medicamentos', N'Medicamentos veterinarios', 1, CAST(N'2025-08-29T19:33:43.8530000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8530000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[diagnostico] ON 

INSERT [dbo].[diagnostico] ([id], [codigo], [nombre], [descripcion], [precio_base], [categoria_diagnostico], [requiere_equipamiento], [activo], [created_at], [updated_at]) VALUES (1, N'SERV001', N'Consulta Veterinaria General', NULL, CAST(50.00 AS Decimal(10, 2)), N'Consultas', 0, 1, CAST(N'2025-08-29T19:33:43.8930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8930000' AS DateTime2))
INSERT [dbo].[diagnostico] ([id], [codigo], [nombre], [descripcion], [precio_base], [categoria_diagnostico], [requiere_equipamiento], [activo], [created_at], [updated_at]) VALUES (2, N'SERV002', N'Vacunación', NULL, CAST(40.00 AS Decimal(10, 2)), N'Prevención', 0, 1, CAST(N'2025-08-29T19:33:43.8970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8970000' AS DateTime2))
INSERT [dbo].[diagnostico] ([id], [codigo], [nombre], [descripcion], [precio_base], [categoria_diagnostico], [requiere_equipamiento], [activo], [created_at], [updated_at]) VALUES (3, N'SERV003', N'Desparasitación', NULL, CAST(30.00 AS Decimal(10, 2)), N'Prevención', 0, 1, CAST(N'2025-08-29T19:33:43.8970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8970000' AS DateTime2))
INSERT [dbo].[diagnostico] ([id], [codigo], [nombre], [descripcion], [precio_base], [categoria_diagnostico], [requiere_equipamiento], [activo], [created_at], [updated_at]) VALUES (4, N'SERV004', N'Cirugía Menor', NULL, CAST(200.00 AS Decimal(10, 2)), N'Cirugía', 0, 1, CAST(N'2025-08-29T19:33:43.8970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8970000' AS DateTime2))
INSERT [dbo].[diagnostico] ([id], [codigo], [nombre], [descripcion], [precio_base], [categoria_diagnostico], [requiere_equipamiento], [activo], [created_at], [updated_at]) VALUES (5, N'SERV005', N'Examen de Laboratorio', NULL, CAST(80.00 AS Decimal(10, 2)), N'Diagnóstico', 0, 1, CAST(N'2025-08-29T19:33:43.8970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8970000' AS DateTime2))
INSERT [dbo].[diagnostico] ([id], [codigo], [nombre], [descripcion], [precio_base], [categoria_diagnostico], [requiere_equipamiento], [activo], [created_at], [updated_at]) VALUES (6, N'SERV006', N'Radiografía', NULL, CAST(120.00 AS Decimal(10, 2)), N'Diagnóstico', 0, 1, CAST(N'2025-08-29T19:33:43.9000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.9000000' AS DateTime2))
INSERT [dbo].[diagnostico] ([id], [codigo], [nombre], [descripcion], [precio_base], [categoria_diagnostico], [requiere_equipamiento], [activo], [created_at], [updated_at]) VALUES (7, N'SERV007', N'Limpieza Dental', NULL, CAST(150.00 AS Decimal(10, 2)), N'Odontología', 0, 1, CAST(N'2025-08-29T19:33:43.9000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.9000000' AS DateTime2))
INSERT [dbo].[diagnostico] ([id], [codigo], [nombre], [descripcion], [precio_base], [categoria_diagnostico], [requiere_equipamiento], [activo], [created_at], [updated_at]) VALUES (8, N'SERV008', N'Esterilización', NULL, CAST(300.00 AS Decimal(10, 2)), N'Cirugía', 0, 1, CAST(N'2025-08-29T19:33:43.9000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.9000000' AS DateTime2))
INSERT [dbo].[diagnostico] ([id], [codigo], [nombre], [descripcion], [precio_base], [categoria_diagnostico], [requiere_equipamiento], [activo], [created_at], [updated_at]) VALUES (9, N'SERV009', N'Ecografía', NULL, CAST(100.00 AS Decimal(10, 2)), N'Diagnóstico', 0, 1, CAST(N'2025-08-29T19:33:43.9000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.9000000' AS DateTime2))
INSERT [dbo].[diagnostico] ([id], [codigo], [nombre], [descripcion], [precio_base], [categoria_diagnostico], [requiere_equipamiento], [activo], [created_at], [updated_at]) VALUES (10, N'SERV010', N'Hospitalización', NULL, CAST(75.00 AS Decimal(10, 2)), N'Hospitalización', 0, 1, CAST(N'2025-08-29T19:33:43.9000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.9000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[diagnostico] OFF
GO
SET IDENTITY_INSERT [dbo].[factura] ON 

INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (101, N'VNT-0001', CAST(N'2025-08-28' AS Date), CAST(N'2025-09-27' AS Date), 106, CAST(51.00 AS Decimal(10, 2)), CAST(6.63 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(57.63 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #1', CAST(N'2025-08-29T19:33:45.1200000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1200000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (102, N'VNT-0002', CAST(N'2025-08-27' AS Date), CAST(N'2025-09-26' AS Date), 63, CAST(52.00 AS Decimal(10, 2)), CAST(6.76 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(58.76 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #2', CAST(N'2025-08-29T19:33:45.1200000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1200000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (103, N'VNT-0003', CAST(N'2025-08-26' AS Date), CAST(N'2025-09-25' AS Date), 189, CAST(53.00 AS Decimal(10, 2)), CAST(6.89 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(59.89 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #3', CAST(N'2025-08-29T19:33:45.1200000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1200000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (104, N'VNT-0004', CAST(N'2025-08-25' AS Date), CAST(N'2025-09-24' AS Date), 149, CAST(54.00 AS Decimal(10, 2)), CAST(7.02 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(61.02 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #4', CAST(N'2025-08-29T19:33:45.1200000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1200000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (105, N'VNT-0005', CAST(N'2025-08-24' AS Date), CAST(N'2025-09-23' AS Date), 63, CAST(55.00 AS Decimal(10, 2)), CAST(7.15 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(62.15 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #5', CAST(N'2025-08-29T19:33:45.1200000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1200000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (106, N'VNT-0006', CAST(N'2025-08-23' AS Date), CAST(N'2025-09-22' AS Date), 114, CAST(56.00 AS Decimal(10, 2)), CAST(7.28 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(63.28 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #6', CAST(N'2025-08-29T19:33:45.1230000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1230000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (107, N'VNT-0007', CAST(N'2025-08-22' AS Date), CAST(N'2025-09-21' AS Date), 89, CAST(57.00 AS Decimal(10, 2)), CAST(7.41 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(64.41 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #7', CAST(N'2025-08-29T19:33:45.1230000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1230000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (108, N'VNT-0008', CAST(N'2025-08-21' AS Date), CAST(N'2025-09-20' AS Date), 70, CAST(58.00 AS Decimal(10, 2)), CAST(7.54 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(65.54 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #8', CAST(N'2025-08-29T19:33:45.1230000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1230000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (109, N'VNT-0009', CAST(N'2025-08-20' AS Date), CAST(N'2025-09-19' AS Date), 76, CAST(59.00 AS Decimal(10, 2)), CAST(7.67 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(66.67 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #9', CAST(N'2025-08-29T19:33:45.1270000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1270000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (110, N'VNT-0010', CAST(N'2025-08-19' AS Date), CAST(N'2025-09-18' AS Date), 40, CAST(60.00 AS Decimal(10, 2)), CAST(7.80 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(67.80 AS Decimal(10, 2)), N'Pendiente', N'Venta de ejemplo #10', CAST(N'2025-08-29T19:33:45.1270000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1270000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (111, N'VNT-0011', CAST(N'2025-08-18' AS Date), CAST(N'2025-09-17' AS Date), 12, CAST(61.00 AS Decimal(10, 2)), CAST(7.93 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(68.93 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #11', CAST(N'2025-08-29T19:33:45.1270000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1270000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (112, N'VNT-0012', CAST(N'2025-08-17' AS Date), CAST(N'2025-09-16' AS Date), 163, CAST(62.00 AS Decimal(10, 2)), CAST(8.06 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(70.06 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #12', CAST(N'2025-08-29T19:33:45.1300000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1300000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (113, N'VNT-0013', CAST(N'2025-08-16' AS Date), CAST(N'2025-09-15' AS Date), 79, CAST(63.00 AS Decimal(10, 2)), CAST(8.19 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(71.19 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #13', CAST(N'2025-08-29T19:33:45.1300000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1300000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (114, N'VNT-0014', CAST(N'2025-08-15' AS Date), CAST(N'2025-09-14' AS Date), 188, CAST(64.00 AS Decimal(10, 2)), CAST(8.32 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(72.32 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #14', CAST(N'2025-08-29T19:33:45.1300000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1300000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (115, N'VNT-0015', CAST(N'2025-08-14' AS Date), CAST(N'2025-09-13' AS Date), 101, CAST(65.00 AS Decimal(10, 2)), CAST(8.45 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(73.45 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #15', CAST(N'2025-08-29T19:33:45.1300000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1300000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (116, N'VNT-0016', CAST(N'2025-08-13' AS Date), CAST(N'2025-09-12' AS Date), 3, CAST(66.00 AS Decimal(10, 2)), CAST(8.58 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(74.58 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #16', CAST(N'2025-08-29T19:33:45.1330000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1330000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (117, N'VNT-0017', CAST(N'2025-08-12' AS Date), CAST(N'2025-09-11' AS Date), 89, CAST(67.00 AS Decimal(10, 2)), CAST(8.71 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(75.71 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #17', CAST(N'2025-08-29T19:33:45.1330000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1330000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (118, N'VNT-0018', CAST(N'2025-08-11' AS Date), CAST(N'2025-09-10' AS Date), 94, CAST(68.00 AS Decimal(10, 2)), CAST(8.84 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(76.84 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #18', CAST(N'2025-08-29T19:33:45.1330000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1330000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (119, N'VNT-0019', CAST(N'2025-08-10' AS Date), CAST(N'2025-09-09' AS Date), 99, CAST(69.00 AS Decimal(10, 2)), CAST(8.97 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(77.97 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #19', CAST(N'2025-08-29T19:33:45.1370000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1370000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (120, N'VNT-0020', CAST(N'2025-08-09' AS Date), CAST(N'2025-09-08' AS Date), 45, CAST(70.00 AS Decimal(10, 2)), CAST(9.10 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(79.10 AS Decimal(10, 2)), N'Pendiente', N'Venta de ejemplo #20', CAST(N'2025-08-29T19:33:45.1370000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1370000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (121, N'VNT-0021', CAST(N'2025-08-08' AS Date), CAST(N'2025-09-07' AS Date), 161, CAST(71.00 AS Decimal(10, 2)), CAST(9.23 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(80.23 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #21', CAST(N'2025-08-29T19:33:45.1370000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1370000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (122, N'VNT-0022', CAST(N'2025-08-07' AS Date), CAST(N'2025-09-06' AS Date), 184, CAST(72.00 AS Decimal(10, 2)), CAST(9.36 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(81.36 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #22', CAST(N'2025-08-29T19:33:45.1370000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1370000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (123, N'VNT-0023', CAST(N'2025-08-06' AS Date), CAST(N'2025-09-05' AS Date), 155, CAST(73.00 AS Decimal(10, 2)), CAST(9.49 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(82.49 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #23', CAST(N'2025-08-29T19:33:45.1400000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1400000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (124, N'VNT-0024', CAST(N'2025-08-05' AS Date), CAST(N'2025-09-04' AS Date), 146, CAST(74.00 AS Decimal(10, 2)), CAST(9.62 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(83.62 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #24', CAST(N'2025-08-29T19:33:45.1400000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1400000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (125, N'VNT-0025', CAST(N'2025-08-04' AS Date), CAST(N'2025-09-03' AS Date), 6, CAST(75.00 AS Decimal(10, 2)), CAST(9.75 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(84.75 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #25', CAST(N'2025-08-29T19:33:45.1400000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1400000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (126, N'VNT-0026', CAST(N'2025-08-03' AS Date), CAST(N'2025-09-02' AS Date), 193, CAST(76.00 AS Decimal(10, 2)), CAST(9.88 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(85.88 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #26', CAST(N'2025-08-29T19:33:45.1400000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1400000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (127, N'VNT-0027', CAST(N'2025-08-02' AS Date), CAST(N'2025-09-01' AS Date), 90, CAST(77.00 AS Decimal(10, 2)), CAST(10.01 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(87.01 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #27', CAST(N'2025-08-29T19:33:45.1400000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1400000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (128, N'VNT-0028', CAST(N'2025-08-01' AS Date), CAST(N'2025-08-31' AS Date), 139, CAST(78.00 AS Decimal(10, 2)), CAST(10.14 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(88.14 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #28', CAST(N'2025-08-29T19:33:45.1430000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1430000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (129, N'VNT-0029', CAST(N'2025-07-31' AS Date), CAST(N'2025-08-30' AS Date), 175, CAST(79.00 AS Decimal(10, 2)), CAST(10.27 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(89.27 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #29', CAST(N'2025-08-29T19:33:45.1430000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1430000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (130, N'VNT-0030', CAST(N'2025-07-30' AS Date), CAST(N'2025-08-29' AS Date), 85, CAST(80.00 AS Decimal(10, 2)), CAST(10.40 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(90.40 AS Decimal(10, 2)), N'Pendiente', N'Venta de ejemplo #30', CAST(N'2025-08-29T19:33:45.1430000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1430000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (131, N'VNT-0031', CAST(N'2025-07-29' AS Date), CAST(N'2025-08-28' AS Date), 125, CAST(81.00 AS Decimal(10, 2)), CAST(10.53 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(91.53 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #31', CAST(N'2025-08-29T19:33:45.1470000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1470000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (132, N'VNT-0032', CAST(N'2025-07-28' AS Date), CAST(N'2025-08-27' AS Date), 161, CAST(82.00 AS Decimal(10, 2)), CAST(10.66 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(92.66 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #32', CAST(N'2025-08-29T19:33:45.1470000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1470000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (133, N'VNT-0033', CAST(N'2025-07-27' AS Date), CAST(N'2025-08-26' AS Date), 105, CAST(83.00 AS Decimal(10, 2)), CAST(10.79 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(93.79 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #33', CAST(N'2025-08-29T19:33:45.1470000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1470000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (134, N'VNT-0034', CAST(N'2025-07-26' AS Date), CAST(N'2025-08-25' AS Date), 65, CAST(84.00 AS Decimal(10, 2)), CAST(10.92 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(94.92 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #34', CAST(N'2025-08-29T19:33:45.1500000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1500000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (135, N'VNT-0035', CAST(N'2025-07-25' AS Date), CAST(N'2025-08-24' AS Date), 13, CAST(85.00 AS Decimal(10, 2)), CAST(11.05 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(96.05 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #35', CAST(N'2025-08-29T19:33:45.1500000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1500000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (136, N'VNT-0036', CAST(N'2025-07-24' AS Date), CAST(N'2025-08-23' AS Date), 87, CAST(86.00 AS Decimal(10, 2)), CAST(11.18 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(97.18 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #36', CAST(N'2025-08-29T19:33:45.1500000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1500000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (137, N'VNT-0037', CAST(N'2025-07-23' AS Date), CAST(N'2025-08-22' AS Date), 124, CAST(87.00 AS Decimal(10, 2)), CAST(11.31 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(98.31 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #37', CAST(N'2025-08-29T19:33:45.1500000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1500000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (138, N'VNT-0038', CAST(N'2025-07-22' AS Date), CAST(N'2025-08-21' AS Date), 175, CAST(88.00 AS Decimal(10, 2)), CAST(11.44 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(99.44 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #38', CAST(N'2025-08-29T19:33:45.1500000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1500000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (139, N'VNT-0039', CAST(N'2025-07-21' AS Date), CAST(N'2025-08-20' AS Date), 127, CAST(89.00 AS Decimal(10, 2)), CAST(11.57 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(100.57 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #39', CAST(N'2025-08-29T19:33:45.1530000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1530000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (140, N'VNT-0040', CAST(N'2025-07-20' AS Date), CAST(N'2025-08-19' AS Date), 92, CAST(90.00 AS Decimal(10, 2)), CAST(11.70 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(101.70 AS Decimal(10, 2)), N'Pendiente', N'Venta de ejemplo #40', CAST(N'2025-08-29T19:33:45.1530000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1530000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (141, N'VNT-0041', CAST(N'2025-07-19' AS Date), CAST(N'2025-08-18' AS Date), 34, CAST(91.00 AS Decimal(10, 2)), CAST(11.83 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(102.83 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #41', CAST(N'2025-08-29T19:33:45.1530000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1530000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (142, N'VNT-0042', CAST(N'2025-07-18' AS Date), CAST(N'2025-08-17' AS Date), 78, CAST(92.00 AS Decimal(10, 2)), CAST(11.96 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(103.96 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #42', CAST(N'2025-08-29T19:33:45.1570000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1570000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (143, N'VNT-0043', CAST(N'2025-07-17' AS Date), CAST(N'2025-08-16' AS Date), 172, CAST(93.00 AS Decimal(10, 2)), CAST(12.09 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(105.09 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #43', CAST(N'2025-08-29T19:33:45.1570000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1570000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (144, N'VNT-0044', CAST(N'2025-07-16' AS Date), CAST(N'2025-08-15' AS Date), 105, CAST(94.00 AS Decimal(10, 2)), CAST(12.22 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(106.22 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #44', CAST(N'2025-08-29T19:33:45.1570000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1570000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (145, N'VNT-0045', CAST(N'2025-07-15' AS Date), CAST(N'2025-08-14' AS Date), 68, CAST(95.00 AS Decimal(10, 2)), CAST(12.35 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(107.35 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #45', CAST(N'2025-08-29T19:33:45.1600000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1600000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (146, N'VNT-0046', CAST(N'2025-07-14' AS Date), CAST(N'2025-08-13' AS Date), 198, CAST(96.00 AS Decimal(10, 2)), CAST(12.48 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(108.48 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #46', CAST(N'2025-08-29T19:33:45.1600000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1600000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (147, N'VNT-0047', CAST(N'2025-07-13' AS Date), CAST(N'2025-08-12' AS Date), 61, CAST(97.00 AS Decimal(10, 2)), CAST(12.61 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(109.61 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #47', CAST(N'2025-08-29T19:33:45.1600000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1600000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (148, N'VNT-0048', CAST(N'2025-07-12' AS Date), CAST(N'2025-08-11' AS Date), 144, CAST(98.00 AS Decimal(10, 2)), CAST(12.74 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(110.74 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #48', CAST(N'2025-08-29T19:33:45.1600000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1600000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (149, N'VNT-0049', CAST(N'2025-07-11' AS Date), CAST(N'2025-08-10' AS Date), 144, CAST(99.00 AS Decimal(10, 2)), CAST(12.87 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(111.87 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #49', CAST(N'2025-08-29T19:33:45.1600000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1600000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (150, N'VNT-0050', CAST(N'2025-07-10' AS Date), CAST(N'2025-08-09' AS Date), 42, CAST(100.00 AS Decimal(10, 2)), CAST(13.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(113.00 AS Decimal(10, 2)), N'Pendiente', N'Venta de ejemplo #50', CAST(N'2025-08-29T19:33:45.1630000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1630000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (151, N'VNT-0051', CAST(N'2025-07-09' AS Date), CAST(N'2025-08-08' AS Date), 144, CAST(101.00 AS Decimal(10, 2)), CAST(13.13 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(114.13 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #51', CAST(N'2025-08-29T19:33:45.1630000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1630000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (152, N'VNT-0052', CAST(N'2025-07-08' AS Date), CAST(N'2025-08-07' AS Date), 88, CAST(102.00 AS Decimal(10, 2)), CAST(13.26 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(115.26 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #52', CAST(N'2025-08-29T19:33:45.1630000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1630000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (153, N'VNT-0053', CAST(N'2025-07-07' AS Date), CAST(N'2025-08-06' AS Date), 108, CAST(103.00 AS Decimal(10, 2)), CAST(13.39 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(116.39 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #53', CAST(N'2025-08-29T19:33:45.1670000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1670000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (154, N'VNT-0054', CAST(N'2025-07-06' AS Date), CAST(N'2025-08-05' AS Date), 90, CAST(104.00 AS Decimal(10, 2)), CAST(13.52 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(117.52 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #54', CAST(N'2025-08-29T19:33:45.1670000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1670000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (155, N'VNT-0055', CAST(N'2025-07-05' AS Date), CAST(N'2025-08-04' AS Date), 124, CAST(105.00 AS Decimal(10, 2)), CAST(13.65 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(118.65 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #55', CAST(N'2025-08-29T19:33:45.1670000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1670000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (156, N'VNT-0056', CAST(N'2025-07-04' AS Date), CAST(N'2025-08-03' AS Date), 118, CAST(106.00 AS Decimal(10, 2)), CAST(13.78 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(119.78 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #56', CAST(N'2025-08-29T19:33:45.1670000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1670000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (157, N'VNT-0057', CAST(N'2025-07-03' AS Date), CAST(N'2025-08-02' AS Date), 99, CAST(107.00 AS Decimal(10, 2)), CAST(13.91 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(120.91 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #57', CAST(N'2025-08-29T19:33:45.1700000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1700000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (158, N'VNT-0058', CAST(N'2025-07-02' AS Date), CAST(N'2025-08-01' AS Date), 11, CAST(108.00 AS Decimal(10, 2)), CAST(14.04 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(122.04 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #58', CAST(N'2025-08-29T19:33:45.1700000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1700000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (159, N'VNT-0059', CAST(N'2025-07-01' AS Date), CAST(N'2025-07-31' AS Date), 15, CAST(109.00 AS Decimal(10, 2)), CAST(14.17 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(123.17 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #59', CAST(N'2025-08-29T19:33:45.1700000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1700000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (160, N'VNT-0060', CAST(N'2025-06-30' AS Date), CAST(N'2025-07-30' AS Date), 50, CAST(110.00 AS Decimal(10, 2)), CAST(14.30 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(124.30 AS Decimal(10, 2)), N'Pendiente', N'Venta de ejemplo #60', CAST(N'2025-08-29T19:33:45.1700000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1700000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (161, N'VNT-0061', CAST(N'2025-06-29' AS Date), CAST(N'2025-07-29' AS Date), 63, CAST(111.00 AS Decimal(10, 2)), CAST(14.43 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(125.43 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #61', CAST(N'2025-08-29T19:33:45.1700000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1700000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (162, N'VNT-0062', CAST(N'2025-06-28' AS Date), CAST(N'2025-07-28' AS Date), 124, CAST(112.00 AS Decimal(10, 2)), CAST(14.56 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(126.56 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #62', CAST(N'2025-08-29T19:33:45.1730000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1730000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (163, N'VNT-0063', CAST(N'2025-06-27' AS Date), CAST(N'2025-07-27' AS Date), 150, CAST(113.00 AS Decimal(10, 2)), CAST(14.69 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(127.69 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #63', CAST(N'2025-08-29T19:33:45.1730000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1730000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (164, N'VNT-0064', CAST(N'2025-06-26' AS Date), CAST(N'2025-07-26' AS Date), 162, CAST(114.00 AS Decimal(10, 2)), CAST(14.82 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(128.82 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #64', CAST(N'2025-08-29T19:33:45.1730000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1730000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (165, N'VNT-0065', CAST(N'2025-06-25' AS Date), CAST(N'2025-07-25' AS Date), 45, CAST(115.00 AS Decimal(10, 2)), CAST(14.95 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(129.95 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #65', CAST(N'2025-08-29T19:33:45.1730000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1730000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (166, N'VNT-0066', CAST(N'2025-06-24' AS Date), CAST(N'2025-07-24' AS Date), 131, CAST(116.00 AS Decimal(10, 2)), CAST(15.08 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(131.08 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #66', CAST(N'2025-08-29T19:33:45.1770000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1770000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (167, N'VNT-0067', CAST(N'2025-06-23' AS Date), CAST(N'2025-07-23' AS Date), 184, CAST(117.00 AS Decimal(10, 2)), CAST(15.21 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(132.21 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #67', CAST(N'2025-08-29T19:33:45.1770000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1770000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (168, N'VNT-0068', CAST(N'2025-06-22' AS Date), CAST(N'2025-07-22' AS Date), 131, CAST(118.00 AS Decimal(10, 2)), CAST(15.34 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(133.34 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #68', CAST(N'2025-08-29T19:33:45.1770000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1770000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (169, N'VNT-0069', CAST(N'2025-06-21' AS Date), CAST(N'2025-07-21' AS Date), 72, CAST(119.00 AS Decimal(10, 2)), CAST(15.47 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(134.47 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #69', CAST(N'2025-08-29T19:33:45.1770000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1770000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (170, N'VNT-0070', CAST(N'2025-06-20' AS Date), CAST(N'2025-07-20' AS Date), 24, CAST(120.00 AS Decimal(10, 2)), CAST(15.60 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(135.60 AS Decimal(10, 2)), N'Pendiente', N'Venta de ejemplo #70', CAST(N'2025-08-29T19:33:45.1800000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1800000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (171, N'VNT-0071', CAST(N'2025-06-19' AS Date), CAST(N'2025-07-19' AS Date), 145, CAST(121.00 AS Decimal(10, 2)), CAST(15.73 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(136.73 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #71', CAST(N'2025-08-29T19:33:45.1800000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1800000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (172, N'VNT-0072', CAST(N'2025-06-18' AS Date), CAST(N'2025-07-18' AS Date), 10, CAST(122.00 AS Decimal(10, 2)), CAST(15.86 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(137.86 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #72', CAST(N'2025-08-29T19:33:45.1800000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1800000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (173, N'VNT-0073', CAST(N'2025-06-17' AS Date), CAST(N'2025-07-17' AS Date), 135, CAST(123.00 AS Decimal(10, 2)), CAST(15.99 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(138.99 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #73', CAST(N'2025-08-29T19:33:45.1800000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1800000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (174, N'VNT-0074', CAST(N'2025-06-16' AS Date), CAST(N'2025-07-16' AS Date), 95, CAST(124.00 AS Decimal(10, 2)), CAST(16.12 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(140.12 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #74', CAST(N'2025-08-29T19:33:45.1800000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1800000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (175, N'VNT-0075', CAST(N'2025-06-15' AS Date), CAST(N'2025-07-15' AS Date), 113, CAST(125.00 AS Decimal(10, 2)), CAST(16.25 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(141.25 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #75', CAST(N'2025-08-29T19:33:45.1830000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1830000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (176, N'VNT-0076', CAST(N'2025-06-14' AS Date), CAST(N'2025-07-14' AS Date), 9, CAST(126.00 AS Decimal(10, 2)), CAST(16.38 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(142.38 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #76', CAST(N'2025-08-29T19:33:45.1830000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1830000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (177, N'VNT-0077', CAST(N'2025-06-13' AS Date), CAST(N'2025-07-13' AS Date), 49, CAST(127.00 AS Decimal(10, 2)), CAST(16.51 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(143.51 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #77', CAST(N'2025-08-29T19:33:45.1830000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1830000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (178, N'VNT-0078', CAST(N'2025-06-12' AS Date), CAST(N'2025-07-12' AS Date), 11, CAST(128.00 AS Decimal(10, 2)), CAST(16.64 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(144.64 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #78', CAST(N'2025-08-29T19:33:45.1830000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1830000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (179, N'VNT-0079', CAST(N'2025-06-11' AS Date), CAST(N'2025-07-11' AS Date), 131, CAST(129.00 AS Decimal(10, 2)), CAST(16.77 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(145.77 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #79', CAST(N'2025-08-29T19:33:45.1870000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1870000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (180, N'VNT-0080', CAST(N'2025-06-10' AS Date), CAST(N'2025-07-10' AS Date), 28, CAST(130.00 AS Decimal(10, 2)), CAST(16.90 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(146.90 AS Decimal(10, 2)), N'Pendiente', N'Venta de ejemplo #80', CAST(N'2025-08-29T19:33:45.1870000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1870000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (181, N'VNT-0081', CAST(N'2025-06-09' AS Date), CAST(N'2025-07-09' AS Date), 29, CAST(131.00 AS Decimal(10, 2)), CAST(17.03 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(148.03 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #81', CAST(N'2025-08-29T19:33:45.1870000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1870000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (182, N'VNT-0082', CAST(N'2025-06-08' AS Date), CAST(N'2025-07-08' AS Date), 196, CAST(132.00 AS Decimal(10, 2)), CAST(17.16 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(149.16 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #82', CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (183, N'VNT-0083', CAST(N'2025-06-07' AS Date), CAST(N'2025-07-07' AS Date), 184, CAST(133.00 AS Decimal(10, 2)), CAST(17.29 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(150.29 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #83', CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (184, N'VNT-0084', CAST(N'2025-06-06' AS Date), CAST(N'2025-07-06' AS Date), 18, CAST(134.00 AS Decimal(10, 2)), CAST(17.42 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(151.42 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #84', CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (185, N'VNT-0085', CAST(N'2025-06-05' AS Date), CAST(N'2025-07-05' AS Date), 137, CAST(135.00 AS Decimal(10, 2)), CAST(17.55 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(152.55 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #85', CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (186, N'VNT-0086', CAST(N'2025-06-04' AS Date), CAST(N'2025-07-04' AS Date), 118, CAST(136.00 AS Decimal(10, 2)), CAST(17.68 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(153.68 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #86', CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (187, N'VNT-0087', CAST(N'2025-06-03' AS Date), CAST(N'2025-07-03' AS Date), 146, CAST(137.00 AS Decimal(10, 2)), CAST(17.81 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(154.81 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #87', CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1900000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (188, N'VNT-0088', CAST(N'2025-06-02' AS Date), CAST(N'2025-07-02' AS Date), 80, CAST(138.00 AS Decimal(10, 2)), CAST(17.94 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(155.94 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #88', CAST(N'2025-08-29T19:33:45.1930000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1930000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (189, N'VNT-0089', CAST(N'2025-06-01' AS Date), CAST(N'2025-07-01' AS Date), 123, CAST(139.00 AS Decimal(10, 2)), CAST(18.07 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(157.07 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #89', CAST(N'2025-08-29T19:33:45.1930000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1930000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (190, N'VNT-0090', CAST(N'2025-05-31' AS Date), CAST(N'2025-06-30' AS Date), 41, CAST(140.00 AS Decimal(10, 2)), CAST(18.20 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(158.20 AS Decimal(10, 2)), N'Pendiente', N'Venta de ejemplo #90', CAST(N'2025-08-29T19:33:45.1930000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1930000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (191, N'VNT-0091', CAST(N'2025-05-30' AS Date), CAST(N'2025-06-29' AS Date), 168, CAST(141.00 AS Decimal(10, 2)), CAST(18.33 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(159.33 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #91', CAST(N'2025-08-29T19:33:45.1970000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1970000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (192, N'VNT-0092', CAST(N'2025-05-29' AS Date), CAST(N'2025-06-28' AS Date), 49, CAST(142.00 AS Decimal(10, 2)), CAST(18.46 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(160.46 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #92', CAST(N'2025-08-29T19:33:45.1970000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1970000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (193, N'VNT-0093', CAST(N'2025-05-28' AS Date), CAST(N'2025-06-27' AS Date), 10, CAST(143.00 AS Decimal(10, 2)), CAST(18.59 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(161.59 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #93', CAST(N'2025-08-29T19:33:45.1970000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1970000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (194, N'VNT-0094', CAST(N'2025-05-27' AS Date), CAST(N'2025-06-26' AS Date), 57, CAST(144.00 AS Decimal(10, 2)), CAST(18.72 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(162.72 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #94', CAST(N'2025-08-29T19:33:45.1970000' AS DateTime2), CAST(N'2025-08-29T19:33:45.1970000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (195, N'VNT-0095', CAST(N'2025-05-26' AS Date), CAST(N'2025-06-25' AS Date), 127, CAST(145.00 AS Decimal(10, 2)), CAST(18.85 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(163.85 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #95', CAST(N'2025-08-29T19:33:45.2000000' AS DateTime2), CAST(N'2025-08-29T19:33:45.2000000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (196, N'VNT-0096', CAST(N'2025-05-25' AS Date), CAST(N'2025-06-24' AS Date), 157, CAST(146.00 AS Decimal(10, 2)), CAST(18.98 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(164.98 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #96', CAST(N'2025-08-29T19:33:45.2000000' AS DateTime2), CAST(N'2025-08-29T19:33:45.2000000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (197, N'VNT-0097', CAST(N'2025-05-24' AS Date), CAST(N'2025-06-23' AS Date), 41, CAST(147.00 AS Decimal(10, 2)), CAST(19.11 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(166.11 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #97', CAST(N'2025-08-29T19:33:45.2000000' AS DateTime2), CAST(N'2025-08-29T19:33:45.2000000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (198, N'VNT-0098', CAST(N'2025-05-23' AS Date), CAST(N'2025-06-22' AS Date), 161, CAST(148.00 AS Decimal(10, 2)), CAST(19.24 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(167.24 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #98', CAST(N'2025-08-29T19:33:45.2000000' AS DateTime2), CAST(N'2025-08-29T19:33:45.2000000' AS DateTime2))
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (199, N'VNT-0099', CAST(N'2025-05-22' AS Date), CAST(N'2025-06-21' AS Date), 13, CAST(149.00 AS Decimal(10, 2)), CAST(19.37 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(168.37 AS Decimal(10, 2)), N'Pagada', N'Venta de ejemplo #99', CAST(N'2025-08-29T19:33:45.2030000' AS DateTime2), CAST(N'2025-08-29T19:33:45.2030000' AS DateTime2))
GO
INSERT [dbo].[factura] ([id], [numero_factura], [fecha_emision], [fecha_vencimiento], [persona_id], [subtotal], [impuestos], [descuentos], [total], [estado], [notas], [created_at], [updated_at]) VALUES (200, N'VNT-0100', CAST(N'2025-05-21' AS Date), CAST(N'2025-06-20' AS Date), 157, CAST(150.00 AS Decimal(10, 2)), CAST(19.50 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(169.50 AS Decimal(10, 2)), N'Pendiente', N'Venta de ejemplo #100', CAST(N'2025-08-29T19:33:45.2030000' AS DateTime2), CAST(N'2025-08-29T19:33:45.2030000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[factura] OFF
GO
SET IDENTITY_INSERT [dbo].[persona] ON 

INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (1, N'Física', N'maria.quispe1@gmail.com', N'Av. Buenos Aires #1234, Zona Sur', N'78123456', 1, CAST(N'2025-08-29T19:33:43.5500000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5500000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (2, N'Física', N'carlos.mamani2@hotmail.com', N'Calle Comercio #567, El Alto', N'69876543', 1, CAST(N'2025-08-29T19:33:43.5600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5600000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (3, N'Física', N'ana.vargas3@yahoo.com', N'Av. 6 de Agosto #890, San Pedro', N'72345678', 1, CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (4, N'Física', N'roberto.choque4@gmail.com', N'Calle Murillo #123, Centro', N'65432109', 1, CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (5, N'Física', N'patricia.torrez5@outlook.com', N'Av. América #456, Miraflores', N'76543210', 1, CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (6, N'Física', N'luis.gutierrez6@gmail.com', N'Calle Sagarnaga #789, Rosario', N'71234567', 1, CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (7, N'Física', N'silvia.mendoza7@hotmail.com', N'Av. Ballivián #321, Calacoto', N'68901234', 1, CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (8, N'Física', N'juan.huanca8@yahoo.com', N'Calle Ayacucho #654, Sopocachi', N'77890123', 1, CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (9, N'Física', N'carmen.chipana9@gmail.com', N'Av. Arce #987, San Jorge', N'73456789', 1, CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (10, N'Física', N'miguel.colque10@outlook.com', N'Calle Linares #147, Centro', N'74567890', 1, CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (11, N'Física', N'juana.mamani11@gmail.com', N'Av. Del Ejército #234, Villa Fátima', N'75123890', 1, CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (12, N'Física', N'pedro.condori12@hotmail.com', N'Calle Murillo #567, Centro', N'68234567', 1, CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (13, N'Física', N'rosa.flores13@yahoo.com', N'Av. Montes #890, San Pedro', N'71345678', 1, CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (14, N'Física', N'eduardo.apaza14@gmail.com', N'Calle Comercio #123, El Alto', N'69456789', 1, CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (15, N'Física', N'sandra.limachi15@outlook.com', N'Av. América #456, Miraflores', N'76567890', 1, CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (16, N'Física', N'fernando.poma16@gmail.com', N'Calle Sagarnaga #789, Rosario', N'72678901', 1, CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (17, N'Física', N'gloria.cruz17@hotmail.com', N'Av. Ballivián #321, Calacoto', N'67789012', 1, CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (18, N'Física', N'raul.ticona18@yahoo.com', N'Calle Ayacucho #654, Sopocachi', N'78890123', 1, CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (19, N'Física', N'marta.yujra19@gmail.com', N'Av. Arce #987, San Jorge', N'73901234', 1, CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (20, N'Física', N'daniel.choque20@outlook.com', N'Calle Linares #147, Centro', N'74012345', 1, CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (21, N'Física', N'elena.vargas21@gmail.com', N'Av. 16 de Julio #234, El Prado', N'75123456', 1, CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (22, N'Física', N'antonio.torrez22@hotmail.com', N'Calle Santa Cruz #567, Centro', N'68234789', 1, CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (23, N'Física', N'lucia.gutierrez23@yahoo.com', N'Av. Camacho #890, Centro', N'71345012', 1, CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (24, N'Física', N'francisco.mendoza24@gmail.com', N'Calle Potosí #123, San Pedro', N'69456345', 1, CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (25, N'Física', N'isabel.huanca25@outlook.com', N'Av. Illimani #456, San Antonio', N'76567678', 1, CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (26, N'Física', N'ricardo.chipana26@gmail.com', N'Calle Sucre #789, Centro', N'72678901', 1, CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (27, N'Física', N'angela.colque27@hotmail.com', N'Av. Mcal. Santa Cruz #321, San Jorge', N'67789234', 1, CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (28, N'Física', N'gonzalo.quispe28@yahoo.com', N'Calle Jaén #654, Rosario', N'78890567', 1, CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (29, N'Física', N'teresa.mamani29@gmail.com', N'Av. Tejada Sorzano #987, Miraflores', N'73901890', 1, CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (30, N'Física', N'hernan.condori30@outlook.com', N'Calle Cochabamba #147, Centro', N'74012123', 1, CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (31, N'Física', N'roxana.flores31@gmail.com', N'Av. Busch #234, Sopocachi', N'75123456', 1, CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (32, N'Física', N'alberto.apaza32@hotmail.com', N'Calle Indaburo #567, Centro', N'68234789', 1, CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (33, N'Física', N'margarita.limachi33@yahoo.com', N'Av. Saavedra #890, Miraflores', N'71345012', 1, CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (34, N'Física', N'victor.poma34@gmail.com', N'Calle Yanacocha #123, Zona Sur', N'69456345', 1, CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (35, N'Física', N'blanca.cruz35@outlook.com', N'Av. Los Sauces #456, Calacoto', N'76567678', 1, CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (36, N'Física', N'alfredo.ticona36@gmail.com', N'Calle Bolívar #789, Centro', N'72678901', 1, CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (37, N'Física', N'veronica.yujra37@hotmail.com', N'Av. Kantutani #321, Villa Fátima', N'67789234', 1, CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (38, N'Física', N'julio.choque38@yahoo.com', N'Calle Genaro Sanjinés #654, Centro', N'78890567', 1, CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (39, N'Física', N'monica.vargas39@gmail.com', N'Av. Arce #987, San Jorge', N'73901890', 1, CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (40, N'Física', N'sergio.torrez40@outlook.com', N'Calle México #147, Centro', N'74012123', 1, CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (41, N'Física', N'graciela.gutierrez41@gmail.com', N'Av. Panorámica #234, Villa San Antonio', N'75123789', 1, CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (42, N'Física', N'jaime.mendoza42@hotmail.com', N'Calle Final Landaeta #567, Sopocachi', N'68234012', 1, CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (43, N'Física', N'adriana.huanca43@yahoo.com', N'Av. Montenegro #890, San Antonio', N'71345345', 1, CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (44, N'Física', N'marcelo.chipana44@gmail.com', N'Calle Calama #123, San Pedro', N'69456678', 1, CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (45, N'Física', N'claudia.colque45@outlook.com', N'Av. Ballivián #456, Calacoto', N'76567901', 1, CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (46, N'Física', N'oscar.quispe46@gmail.com', N'Calle Rosendo Gutierrez #789, Sopocachi', N'72678234', 1, CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (47, N'Física', N'paola.mamani47@hotmail.com', N'Av. Arce #321, San Jorge', N'67789567', 1, CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (48, N'Física', N'ramiro.condori48@yahoo.com', N'Calle Loayza #654, Centro', N'78890890', 1, CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (49, N'Física', N'ximena.flores49@gmail.com', N'Av. 20 de Octubre #987, Sopocachi', N'73901123', 1, CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (50, N'Física', N'diego.apaza50@outlook.com', N'Calle Almirante Grau #147, Centro', N'74012456', 1, CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (51, N'Física', N'carla.limachi51@gmail.com', N'Av. Hernando Siles #234, Calacoto', N'75123012', 1, CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (52, N'Física', N'rolando.poma52@hotmail.com', N'Calle Tarija #567, Centro', N'68234345', 1, CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (53, N'Física', N'beatriz.cruz53@yahoo.com', N'Av. Costanera #890, Zona Sur', N'71345678', 1, CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (54, N'Física', N'gustavo.ticona54@gmail.com', N'Calle Evaristo Valle #123, Sopocachi', N'69456901', 1, CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (55, N'Física', N'lorena.yujra55@outlook.com', N'Av. Ecuador #456, San Jorge', N'76567234', 1, CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (56, N'Física', N'ernesto.choque56@gmail.com', N'Calle Capitán Ravelo #789, Centro', N'72678567', 1, CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (57, N'Física', N'vanessa.vargas57@hotmail.com', N'Av. Villazón #321, Miraflores', N'67789890', 1, CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (58, N'Física', N'mario.torrez58@yahoo.com', N'Calle Oruro #654, Centro', N'78890123', 1, CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (59, N'Física', N'natalia.gutierrez59@gmail.com', N'Av. Sanchez Lima #987, Sopocachi', N'73901456', 1, CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (60, N'Física', N'hector.mendoza60@outlook.com', N'Calle Beni #147, Centro', N'74012789', 1, CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (61, N'Física', N'andrea.huanca61@gmail.com', N'Av. Libertador Bolívar #234, Villa Fátima', N'75123345', 1, CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (62, N'Física', N'gabriel.chipana62@hotmail.com', N'Calle Chuquisaca #567, Centro', N'68234678', 1, CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (63, N'Física', N'daniela.colque63@yahoo.com', N'Av. Los Alamos #890, Calacoto', N'71345901', 1, CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (64, N'Física', N'felipe.quispe64@gmail.com', N'Calle Estudiantes #123, San Pedro', N'69456234', 1, CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (65, N'Física', N'valeria.mamani65@outlook.com', N'Av. Prado #456, Centro', N'76567567', 1, CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (66, N'Física', N'rodrigo.condori66@gmail.com', N'Calle Illampu #789, Centro', N'72678890', 1, CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (67, N'Física', N'alejandra.flores67@hotmail.com', N'Av. Kantutani #321, Villa Fátima', N'67789123', 1, CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (68, N'Física', N'andres.apaza68@yahoo.com', N'Calle Santa Bárbara #654, San Jorge', N'78890456', 1, CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (69, N'Física', N'karina.limachi69@gmail.com', N'Av. Montes #987, San Pedro', N'73901789', 1, CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (70, N'Física', N'cristian.poma70@outlook.com', N'Calle Max Paredes #147, Centro', N'74012012', 1, CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (71, N'Física', N'soledad.cruz71@gmail.com', N'Av. 6 de Agosto #234, San Pedro', N'75123678', 1, CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (72, N'Física', N'mauricio.ticona72@hotmail.com', N'Calle Sagarnaga #567, Rosario', N'68234901', 1, CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (73, N'Física', N'fabiola.yujra73@yahoo.com', N'Av. Arce #890, San Jorge', N'71345234', 1, CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (74, N'Física', N'ivan.choque74@gmail.com', N'Calle Sucre #123, Centro', N'69456567', 1, CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (75, N'Física', N'pamela.vargas75@outlook.com', N'Av. Del Poeta #456, Calacoto', N'76567890', 1, CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (76, N'Física', N'aldo.torrez76@gmail.com', N'Calle Colón #789, Centro', N'72678123', 1, CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (77, N'Física', N'miriam.gutierrez77@hotmail.com', N'Av. Ballivián #321, Calacoto', N'67789456', 1, CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (78, N'Física', N'armando.mendoza78@yahoo.com', N'Calle Junín #654, Centro', N'78890789', 1, CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (79, N'Física', N'jimena.huanca79@gmail.com', N'Av. 20 de Octubre #987, Sopocachi', N'73901012', 1, CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (80, N'Física', N'esteban.chipana80@outlook.com', N'Calle Federico Zuazo #147, Centro', N'74012345', 1, CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (81, N'Física', N'rebeca.colque81@gmail.com', N'Av. Costanera #234, Zona Sur', N'75123901', 1, CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (82, N'Física', N'ignacio.quispe82@hotmail.com', N'Calle Yanacocha #567, Zona Sur', N'68234234', 1, CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (83, N'Física', N'sonia.mamani83@yahoo.com', N'Av. Hernando Siles #890, Calacoto', N'71345567', 1, CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (84, N'Física', N'nestor.condori84@gmail.com', N'Calle Campero #123, Centro', N'69456890', 1, CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (85, N'Física', N'lilian.flores85@outlook.com', N'Av. Los Alamos #456, Calacoto', N'76567123', 1, CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (86, N'Física', N'walter.apaza86@gmail.com', N'Calle Plaza Villarroel #789, Centro', N'72678456', 1, CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (87, N'Física', N'gladys.limachi87@hotmail.com', N'Av. Montenegro #321, San Antonio', N'67789789', 1, CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (88, N'Física', N'gerardo.poma88@yahoo.com', N'Calle Baptista #654, Villa Fátima', N'78890012', 1, CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (89, N'Física', N'carolina.cruz89@gmail.com', N'Av. Panorámica #987, Villa San Antonio', N'73901345', 1, CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (90, N'Física', N'rolber.ticona90@outlook.com', N'Calle Pichincha #147, Centro', N'74012678', 1, CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (91, N'Física', N'evelyn.yujra91@gmail.com', N'Av. Villazon #234, Miraflores', N'75123234', 1, CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (92, N'Física', N'ruben.choque92@hotmail.com', N'Calle Ingavi #567, Centro', N'68234567', 1, CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (93, N'Física', N'susana.vargas93@yahoo.com', N'Av. Sanchez Lima #890, Sopocachi', N'71345890', 1, CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (94, N'Física', N'freddy.torrez94@gmail.com', N'Calle Catacora #123, Villa Fátima', N'69456123', 1, CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (95, N'Física', N'elizabeth.gutierrez95@outlook.com', N'Av. Busch #456, Sopocachi', N'76567456', 1, CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (96, N'Física', N'wilson.mendoza96@gmail.com', N'Calle Calama #789, San Pedro', N'72678789', 1, CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (97, N'Física', N'jenny.huanca97@hotmail.com', N'Av. Libertador Bolívar #321, Villa Fátima', N'67789012', 1, CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (98, N'Física', N'jhonny.chipana98@yahoo.com', N'Calle Loayza #654, Centro', N'78890345', 1, CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (99, N'Física', N'rosario.colque99@gmail.com', N'Av. Arce #987, San Jorge', N'73901678', 1, CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2))
GO
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (100, N'Física', N'edgar.quispe100@outlook.com', N'Calle Almirante Grau #147, Centro', N'74012901', 1, CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (101, N'Jurídica', N'info@vetsanfrancisco1.bo', N'Av. 6 de Agosto #1250, La Paz', N'22451234', 1, CAST(N'2025-08-29T19:33:43.6470000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6470000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (102, N'Jurídica', N'contacto@veterinariaesperanza2.com', N'Calle Comercio #890, El Alto', N'28901234', 1, CAST(N'2025-08-29T19:33:43.6500000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6500000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (103, N'Jurídica', N'ventas@petshopamigos3.bo', N'Av. Heroínas #567, Cochabamba', N'44123456', 1, CAST(N'2025-08-29T19:33:43.6500000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6500000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (104, N'Jurídica', N'distribucion@agrovet4.com.bo', N'Zona Industrial, Villa El Carmen, Santa Cruz', N'33789012', 1, CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (105, N'Jurídica', N'consultas@pawsandclaws5.bo', N'Av. América #234, Miraflores, La Paz', N'22567890', 1, CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (106, N'Jurídica', N'laboratorio@vetaltiplano6.com', N'Calle Potosí #123, La Paz', N'22345678', 1, CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (107, N'Jurídica', N'produccion@granjasanmartin7.bo', N'Km 15 Carretera a Oruro, La Paz', N'22901234', 1, CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (108, N'Jurídica', N'info@vettropical8.com', N'Av. Banzer #789, Santa Cruz', N'33456789', 1, CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (109, N'Jurídica', N'importaciones@medvet9.bo', N'Zona Franca, El Alto, La Paz', N'28123456', 1, CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (110, N'Jurídica', N'atencion@vetvalle10.com', N'Av. Libertador #456, Tarija', N'46678901', 1, CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (111, N'Jurídica', N'cooperativa@ganaderaltiplano11.bo', N'Plaza Principal, Patacamaya, La Paz', N'22234567', 1, CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (112, N'Jurídica', N'cuidados@petcaresucre12.com', N'Calle España #234, Sucre', N'46445566', 1, CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (113, N'Jurídica', N'ventas@alimentosoriente13.bo', N'Parque Industrial, Santa Cruz', N'33789123', 1, CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (114, N'Jurídica', N'consultas@vetandina14.com', N'Av. Universitaria #567, Potosí', N'26223344', 1, CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (115, N'Jurídica', N'hacienda@esperanza15.com.bo', N'Provincia Warnes, Santa Cruz', N'33556677', 1, CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (116, N'Jurídica', N'clinica@vetbeni16.bo', N'Av. Mamoré #123, Trinidad, Beni', N'36778899', 1, CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (117, N'Jurídica', N'distribuidora@pecuarios17.bo', N'Av. Circunvalación #789, Cochabamba', N'44112233', 1, CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (118, N'Jurídica', N'investigacion@umsa18.edu.bo', N'Campus Universitario, Cota Cota, La Paz', N'22345567', 1, CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (119, N'Jurídica', N'farmacia@vetcentral19.com', N'Calle Ayacucho #345, La Paz', N'22667788', 1, CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (120, N'Jurídica', N'servicios@vetmovil20.bo', N'Av. del Ejército #678, La Paz', N'22889900', 1, CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (121, N'Jurídica', N'info@clinicaandes21.bo', N'Av. Arce #456, La Paz', N'22112233', 1, CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (122, N'Jurídica', N'ventas@animalkingdom22.com', N'Calle Comercio #789, Santa Cruz', N'33445566', 1, CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (123, N'Jurídica', N'diagnostico@labvet23.bo', N'Av. 6 de Agosto #234, Cochabamba', N'44778899', 1, CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (124, N'Jurídica', N'granja@sanjuan24.com.bo', N'Km 20 Carretera a Oruro', N'22334455', 1, CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (125, N'Jurídica', N'consultas@vetexpress25.bo', N'Av. América #567, El Alto', N'28556677', 1, CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (126, N'Jurídica', N'reproduccion@centroanimal26.com', N'Calle Bolívar #890, Tarija', N'46889900', 1, CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (127, N'Jurídica', N'distribuidora@farmavet27.bo', N'Zona Industrial, Santa Cruz', N'33112233', 1, CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (128, N'Jurídica', N'info@vetnorte28.com', N'Av. Max Paredes #123, La Paz', N'22445566', 1, CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (129, N'Jurídica', N'empresa@ganadera29.bo', N'Provincia Ichilo, Santa Cruz', N'33778899', 1, CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (130, N'Jurídica', N'hospital@vetcentral30.com', N'Av. Villazón #456, Cochabamba', N'44334455', 1, CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (131, N'Jurídica', N'ventas@premium31.bo', N'Parque Industrial, El Alto', N'28667788', 1, CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (132, N'Jurídica', N'consultas@vetsur32.com', N'Av. Costanera #789, Zona Sur, La Paz', N'22990011', 1, CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (133, N'Jurídica', N'cooperativa@valleyalto33.bo', N'Quillacollo, Cochabamba', N'44556677', 1, CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (134, N'Jurídica', N'equipos@importvet34.com', N'Zona Franca, Santa Cruz', N'33223344', 1, CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (135, N'Jurídica', N'emergencias@vet24h35.bo', N'Av. Busch #234, Sopocachi, La Paz', N'22778899', 1, CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (136, N'Jurídica', N'capacitacion@centrovet36.edu.bo', N'Av. Universitaria #567, Sucre', N'46445566', 1, CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (137, N'Jurídica', N'avicola@este37.com.bo', N'Provincia Warnes, Santa Cruz', N'33667788', 1, CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (138, N'Jurídica', N'especializada@vetesp38.com', N'Av. Arce #890, San Jorge, La Paz', N'22112244', 1, CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (139, N'Jurídica', N'vacunas@distnacional39.bo', N'Av. América #123, El Alto', N'28445566', 1, CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (140, N'Jurídica', N'salud@centroanimal40.com', N'Calle Sagarnaga #456, Potosí', N'26778899', 1, CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (141, N'Jurídica', N'analisis@labclinico41.bo', N'Av. 16 de Julio #789, La Paz', N'22334466', 1, CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (142, N'Jurídica', N'spa@petspa42.com', N'Calle Rosendo Gutierrez #234, Cochabamba', N'44556688', 1, CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (143, N'Jurídica', N'transporte@ganado43.bo', N'Km 5 Carretera a Viacha', N'22667799', 1, CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (144, N'Jurídica', N'pequenos@vetpeq44.com', N'Av. Ballivián #567, Calacoto, La Paz', N'22889911', 1, CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (145, N'Jurídica', N'suplementos@nutri45.bo', N'Zona Industrial, Santa Cruz', N'33445577', 1, CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (146, N'Jurídica', N'rehab@centrorehab46.com', N'Av. Costanera #890, Tarija', N'46223344', 1, CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (147, N'Jurídica', N'inseminacion@artificial47.bo', N'Provincia Cordillera, Santa Cruz', N'33778800', 1, CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (148, N'Jurídica', N'rural@altiplano48.com', N'Plaza Principal, Patacamaya', N'22556699', 1, CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (149, N'Jurídica', N'imagenes@diagnostico49.bo', N'Av. Arce #123, Sopocachi, La Paz', N'22445577', 1, CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (150, N'Jurídica', N'experimental@univet50.edu.bo', N'Campus Universitario, Cochabamba', N'44667788', 1, CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (151, N'Jurídica', N'emergencias@vetemerge51.com', N'Av. 6 de Agosto #456, Santa Cruz', N'33112244', 1, CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (152, N'Jurídica', N'organicos@products52.bo', N'Valle de Sacaba, Cochabamba', N'44335577', 1, CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (153, N'Jurídica', N'adopcion@centro53.org', N'Av. América #789, Miraflores, La Paz', N'22668899', 1, CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (154, N'Jurídica', N'genetica@labgen54.bo', N'Parque Tecnológico, Santa Cruz', N'33557788', 1, CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (155, N'Jurídica', N'equinos@vetequino55.com', N'Club Hípico, La Paz', N'22779900', 1, CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (156, N'Jurídica', N'preventiva@medprev56.bo', N'Av. Heroínas #234, Cochabamba', N'44446677', 1, CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (157, N'Jurídica', N'biotech@vetbio57.com', N'Zona Franca, El Alto', N'28778899', 1, CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (158, N'Jurídica', N'movil@vetmovil58.bo', N'Av. del Ejército #567, La Paz', N'22334455', 1, CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (159, N'Jurídica', N'entrenamiento@canino59.com', N'Zona Sur, La Paz', N'22556677', 1, CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (160, N'Jurídica', N'plagas@control60.bo', N'Av. Circunvalación #890, Santa Cruz', N'33668899', 1, CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (161, N'Jurídica', N'hospital@vetesp61.com', N'Av. Montes #123, Potosí', N'26445566', 1, CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (162, N'Jurídica', N'concentrados@alimentos62.bo', N'Parque Industrial, Cochabamba', N'44778800', 1, CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (163, N'Jurídica', N'cirugia@avanzada63.com', N'Av. Arce #456, San Jorge, La Paz', N'22889911', 1, CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (164, N'Jurídica', N'micro@labmicro64.bo', N'Av. Universidad #789, Tarija', N'46223355', 1, CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (165, N'Jurídica', N'exoticos@vetexotic65.com', N'Calle Comercio #234, Santa Cruz', N'33445566', 1, CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (166, N'Jurídica', N'reproduccion@asistida66.bo', N'Zona Experimental, Cochabamba', N'44667788', 1, CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (167, N'Jurídica', N'integrales@servicios67.com', N'Av. América #567, El Alto', N'28556677', 1, CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (168, N'Jurídica', N'terapias@alternativas68.bo', N'Av. Ballivián #890, Calacoto, La Paz', N'22778899', 1, CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (169, N'Jurídica', N'quirurgico@material69.com', N'Zona Industrial, Santa Cruz', N'33112233', 1, CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (170, N'Jurídica', N'comunitaria@vetcom70.org', N'Villa El Carmen, El Alto', N'28445577', 1, CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (171, N'Jurídica', N'investigacion@enfermedades71.bo', N'Universidad Mayor, La Paz', N'22667788', 1, CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (172, N'Jurídica', N'cremacion@mascotas72.com', N'Periférico, Cochabamba', N'44889900', 1, CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (173, N'Jurídica', N'oncologia@vetoncol73.com', N'Av. Arce #123, Sopocachi, La Paz', N'22334466', 1, CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (174, N'Jurídica', N'patologia@labpatol74.bo', N'Hospital Veterinario, Santa Cruz', N'33556677', 1, CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (175, N'Jurídica', N'geriatrica@vetgeriat75.com', N'Av. 6 de Agosto #456, Tarija', N'46778899', 1, CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (176, N'Jurídica', N'fisio@terapia76.bo', N'Calle Sucre #789, Potosí', N'26112233', 1, CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (177, N'Jurídica', N'seguros@mascotas77.com', N'Av. 16 de Julio #234, La Paz', N'22445566', 1, CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (178, N'Jurídica', N'nutricion@especializada78.bo', N'Valle de Tiquipaya, Cochabamba', N'44667788', 1, CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (179, N'Jurídica', N'comportamiento@etologia79.com', N'Av. Costanera #567, Santa Cruz', N'33889900', 1, CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (180, N'Jurídica', N'acuicultura@vetaqua80.bo', N'Lago Titicaca, Copacabana', N'22778800', 1, CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (181, N'Jurídica', N'universitario@vetuni81.edu.bo', N'Campus Central, La Paz', N'22556677', 1, CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (182, N'Jurídica', N'biorepro@biotech82.com', N'Parque Tecnológico, Cochabamba', N'44445566', 1, CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (183, N'Jurídica', N'deportiva@canideport83.bo', N'Club Canino, Santa Cruz', N'33223344', 1, CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (184, N'Jurídica', N'alimentos@labanalisis84.com', N'Zona Industrial, El Alto', N'28667788', 1, CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (185, N'Jurídica', N'pediatrica@vetped85.com', N'Av. América #890, Miraflores, La Paz', N'22889911', 1, CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (186, N'Jurídica', N'sangre@donacion86.bo', N'Hospital Central, Cochabamba', N'44112233', 1, CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (187, N'Jurídica', N'farma@productos87.com', N'Zona Franca, Santa Cruz', N'33445566', 1, CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (188, N'Jurídica', N'fauna@silvestre88.org', N'Parque Nacional, Madidi', N'22667788', 1, CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (189, N'Jurídica', N'interna@medicina89.com', N'Av. Ballivián #123, Tarija', N'46889900', 1, CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (190, N'Jurídica', N'tele@medicina90.bo', N'Centro Tecnológico, La Paz', N'22112244', 1, CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (191, N'Jurídica', N'logistica@vetlog91.com', N'Centro de Distribución, El Alto', N'28334455', 1, CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (192, N'Jurídica', N'zoonosis@investigacion92.bo', N'Instituto Nacional, Cochabamba', N'44556677', 1, CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (193, N'Jurídica', N'nocturnas@urgencias93.com', N'Av. 6 de Agosto #456, Santa Cruz', N'33778899', 1, CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (194, N'Jurídica', N'bienestar@capacitacion94.org', N'Universidad Católica, La Paz', N'22445577', 1, CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (195, N'Jurídica', N'consultoria@vetcons95.com', N'Centro Empresarial, Santa Cruz', N'33112244', 1, CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (196, N'Jurídica', N'forense@medicina96.bo', N'Instituto Forense, Potosí', N'26223355', 1, CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (197, N'Jurídica', N'residuos@gestion97.com', N'Planta de Tratamiento, Cochabamba', N'44667799', 1, CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (198, N'Jurídica', N'educacion@continua98.edu.bo', N'Colegio Veterinario, La Paz', N'22889922', 1, CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2))
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (199, N'Jurídica', N'tradicional@vetmed99.bo', N'Centro Ancestral, Uyuni', N'26445566', 1, CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2))
GO
INSERT [dbo].[persona] ([id], [tipo], [email], [direccion], [telefono], [activo], [created_at], [updated_at]) VALUES (200, N'Jurídica', N'internacional@salud100.org', N'Zona Diplomática, La Paz', N'22778811', 1, CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[persona] OFF
GO
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (1, N'10000001', N'Maria Elena', N'Quispe Mamani', CAST(N'1985-03-15' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5530000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5530000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (2, N'10000002', N'Carlos Alberto', N'Mamani Condori', CAST(N'1978-11-22' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5600000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (3, N'10000003', N'Ana Lucia', N'Vargas Flores', CAST(N'1992-07-08' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (4, N'10000004', N'Roberto', N'Choque Apaza', CAST(N'1980-12-03' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (5, N'10000005', N'Patricia', N'Torrez Limachi', CAST(N'1987-05-18' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5630000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (6, N'10000006', N'Luis Fernando', N'Gutierrez Poma', CAST(N'1975-09-25' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (7, N'10000007', N'Silvia', N'Mendoza Cruz', CAST(N'1990-02-14' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (8, N'10000008', N'Juan Carlos', N'Huanca Ticona', CAST(N'1983-08-07' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (9, N'10000009', N'Carmen Rosa', N'Chipana Yujra', CAST(N'1988-04-12' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5670000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (10, N'10000010', N'Miguel Angel', N'Colque Mamani', CAST(N'1979-01-30' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (11, N'10000011', N'Juana', N'Mamani Quispe', CAST(N'1986-06-12' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (12, N'10000012', N'Pedro', N'Condori Flores', CAST(N'1982-09-03' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (13, N'10000013', N'Rosa', N'Flores Apaza', CAST(N'1991-02-28' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (14, N'10000014', N'Eduardo', N'Apaza Limachi', CAST(N'1977-12-15' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5700000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (15, N'10000015', N'Sandra', N'Limachi Poma', CAST(N'1989-05-07' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (16, N'10000016', N'Fernando', N'Poma Cruz', CAST(N'1984-08-20' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (17, N'10000017', N'Gloria', N'Cruz Ticona', CAST(N'1993-11-11' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5730000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (18, N'10000018', N'Raul', N'Ticona Yujra', CAST(N'1981-04-03' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (19, N'10000019', N'Marta', N'Yujra Choque', CAST(N'1988-07-25' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (20, N'10000020', N'Daniel', N'Choque Vargas', CAST(N'1976-10-18' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (21, N'10000021', N'Elena', N'Vargas Torrez', CAST(N'1987-01-14' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (22, N'10000022', N'Antonio', N'Torrez Gutierrez', CAST(N'1983-04-08' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5770000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (23, N'10000023', N'Lucia', N'Gutierrez Mendoza', CAST(N'1990-06-22' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (24, N'10000024', N'Francisco', N'Mendoza Huanca', CAST(N'1979-09-05' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (25, N'10000025', N'Isabel', N'Huanca Chipana', CAST(N'1985-12-17' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (26, N'10000026', N'Ricardo', N'Chipana Colque', CAST(N'1982-03-30' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (27, N'10000027', N'Angela', N'Colque Quispe', CAST(N'1994-05-13' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (28, N'10000028', N'Gonzalo', N'Quispe Mamani', CAST(N'1981-08-26' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5800000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (29, N'10000029', N'Teresa', N'Mamani Condori', CAST(N'1986-11-09' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (30, N'10000030', N'Hernan', N'Condori Flores', CAST(N'1978-02-21' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (31, N'10000031', N'Roxana', N'Flores Apaza', CAST(N'1989-07-04' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (32, N'10000032', N'Alberto', N'Apaza Limachi', CAST(N'1984-10-17' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (33, N'10000033', N'Margarita', N'Limachi Poma', CAST(N'1991-01-30' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5830000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (34, N'10000034', N'Victor', N'Poma Cruz', CAST(N'1977-05-12' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (35, N'10000035', N'Blanca', N'Cruz Ticona', CAST(N'1993-08-25' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (36, N'10000036', N'Alfredo', N'Ticona Yujra', CAST(N'1980-11-07' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (37, N'10000037', N'Veronica', N'Yujra Choque', CAST(N'1988-02-19' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (38, N'10000038', N'Julio', N'Choque Vargas', CAST(N'1985-06-01' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (39, N'10000039', N'Monica', N'Vargas Torrez', CAST(N'1992-09-14' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5870000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (40, N'10000040', N'Sergio', N'Torrez Gutierrez', CAST(N'1976-12-27' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (41, N'10000041', N'Graciela', N'Gutierrez Mendoza', CAST(N'1987-03-11' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (42, N'10000042', N'Jaime', N'Mendoza Huanca', CAST(N'1983-06-24' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (43, N'10000043', N'Adriana', N'Huanca Chipana', CAST(N'1990-09-06' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (44, N'10000044', N'Marcelo', N'Chipana Colque', CAST(N'1979-12-19' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5900000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (45, N'10000045', N'Claudia', N'Colque Quispe', CAST(N'1985-01-01' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (46, N'10000046', N'Oscar', N'Quispe Mamani', CAST(N'1982-04-14' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (47, N'10000047', N'Paola', N'Mamani Condori', CAST(N'1994-07-27' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (48, N'10000048', N'Ramiro', N'Condori Flores', CAST(N'1981-10-09' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (49, N'10000049', N'Ximena', N'Flores Apaza', CAST(N'1988-01-22' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5930000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (50, N'10000050', N'Diego', N'Apaza Limachi', CAST(N'1977-05-04' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (51, N'10000051', N'Carla', N'Limachi Poma', CAST(N'1989-08-17' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (52, N'10000052', N'Rolando', N'Poma Cruz', CAST(N'1984-11-30' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (53, N'10000053', N'Beatriz', N'Cruz Ticona', CAST(N'1991-03-12' AS Date), N'F', CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (54, N'10000054', N'Gustavo', N'Ticona Yujra', CAST(N'1978-06-25' AS Date), N'M', CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.5970000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (55, N'10000055', N'Lorena', N'Yujra Choque', CAST(N'1993-09-07' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (56, N'10000056', N'Ernesto', N'Choque Vargas', CAST(N'1980-12-20' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (57, N'10000057', N'Vanessa', N'Vargas Torrez', CAST(N'1987-02-02' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (58, N'10000058', N'Mario', N'Torrez Gutierrez', CAST(N'1985-05-15' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (59, N'10000059', N'Natalia', N'Gutierrez Mendoza', CAST(N'1992-08-28' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (60, N'10000060', N'Hector', N'Mendoza Huanca', CAST(N'1976-11-10' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (61, N'10000061', N'Andrea', N'Huanca Chipana', CAST(N'1989-01-23' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6000000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (62, N'10000062', N'Gabriel', N'Chipana Colque', CAST(N'1983-04-05' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (63, N'10000063', N'Daniela', N'Colque Quispe', CAST(N'1990-07-18' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (64, N'10000064', N'Felipe', N'Quispe Mamani', CAST(N'1979-10-31' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (65, N'10000065', N'Valeria', N'Mamani Condori', CAST(N'1985-12-13' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (66, N'10000066', N'Rodrigo', N'Condori Flores', CAST(N'1982-03-26' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (67, N'10000067', N'Alejandra', N'Flores Apaza', CAST(N'1994-06-08' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6030000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (68, N'10000068', N'Andres', N'Apaza Limachi', CAST(N'1981-09-21' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (69, N'10000069', N'Karina', N'Limachi Poma', CAST(N'1988-12-03' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (70, N'10000070', N'Cristian', N'Poma Cruz', CAST(N'1977-02-16' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (71, N'10000071', N'Soledad', N'Cruz Ticona', CAST(N'1989-05-29' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (72, N'10000072', N'Mauricio', N'Ticona Yujra', CAST(N'1984-08-11' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6070000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (73, N'10000073', N'Fabiola', N'Yujra Choque', CAST(N'1991-11-24' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (74, N'10000074', N'Ivan', N'Choque Vargas', CAST(N'1978-01-06' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (75, N'10000075', N'Pamela', N'Vargas Torrez', CAST(N'1993-04-19' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (76, N'10000076', N'Aldo', N'Torrez Gutierrez', CAST(N'1980-07-02' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (77, N'10000077', N'Miriam', N'Gutierrez Mendoza', CAST(N'1987-10-14' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (78, N'10000078', N'Armando', N'Mendoza Huanca', CAST(N'1985-01-27' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (79, N'10000079', N'Jimena', N'Huanca Chipana', CAST(N'1992-05-09' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6100000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (80, N'10000080', N'Esteban', N'Chipana Colque', CAST(N'1976-08-22' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (81, N'10000081', N'Rebeca', N'Colque Quispe', CAST(N'1989-11-04' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (82, N'10000082', N'Ignacio', N'Quispe Mamani', CAST(N'1983-12-17' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (83, N'10000083', N'Sonia', N'Mamani Condori', CAST(N'1990-02-28' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (84, N'10000084', N'Nestor', N'Condori Flores', CAST(N'1979-06-12' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (85, N'10000085', N'Lilian', N'Flores Apaza', CAST(N'1985-09-25' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6130000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (86, N'10000086', N'Walter', N'Apaza Limachi', CAST(N'1982-01-07' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (87, N'10000087', N'Gladys', N'Limachi Poma', CAST(N'1994-04-20' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (88, N'10000088', N'Gerardo', N'Poma Cruz', CAST(N'1981-07-03' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (89, N'10000089', N'Carolina', N'Cruz Ticona', CAST(N'1988-10-16' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (90, N'10000090', N'Rolber', N'Ticona Yujra', CAST(N'1977-12-28' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6170000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (91, N'10000091', N'Evelyn', N'Yujra Choque', CAST(N'1989-03-11' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (92, N'10000092', N'Ruben', N'Choque Vargas', CAST(N'1984-06-24' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (93, N'10000093', N'Susana', N'Vargas Torrez', CAST(N'1991-09-06' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (94, N'10000094', N'Freddy', N'Torrez Gutierrez', CAST(N'1978-12-19' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (95, N'10000095', N'Elizabeth', N'Gutierrez Mendoza', CAST(N'1993-01-01' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (96, N'10000096', N'Wilson', N'Mendoza Huanca', CAST(N'1980-04-14' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (97, N'10000097', N'Jenny', N'Huanca Chipana', CAST(N'1987-07-27' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6200000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (98, N'10000098', N'Jhonny', N'Chipana Colque', CAST(N'1985-10-09' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (99, N'10000099', N'Rosario', N'Colque Quispe', CAST(N'1992-01-22' AS Date), N'F', CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2))
INSERT [dbo].[persona_fisica] ([id], [ci], [nombre], [apellido], [fecha_nacimiento], [genero], [created_at], [updated_at]) VALUES (100, N'10000100', N'Edgar', N'Quispe Mamani', CAST(N'1976-05-04' AS Date), N'M', CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6230000' AS DateTime2))
GO
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (101, N'Veterinaria San Francisco SRL', N'20000001', N'Dr. Eduardo Mamani', N'Director Veterinario', CAST(N'2025-08-29T19:33:43.6500000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6500000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (102, N'Clínica Veterinaria Esperanza', N'20000002', N'Dra. Carmen Quispe', N'Gerente General', CAST(N'2025-08-29T19:33:43.6500000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6500000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (103, N'Pet Shop Los Amigos EIRL', N'20000003', N'Carlos Vargas', N'Propietario', CAST(N'2025-08-29T19:33:43.6500000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6500000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (104, N'Distribuidora Agroveterinaria Bolivia', N'20000004', N'Ana Torrez', N'Gerente de Ventas', CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (105, N'Centro Veterinario Paws & Claws', N'20000005', N'Dr. Roberto Choque', N'Veterinario Jefe', CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (106, N'Laboratorio Veterinario del Altiplano', N'20000006', N'Dra. Patricia Mendoza', N'Directora Técnica', CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (107, N'Granja Avícola San Martín', N'20000007', N'Luis Gutierrez', N'Gerente de Producción', CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6530000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (108, N'Veterinaria Tropical Santa Cruz', N'20000008', N'Dra. Silvia Huanca', N'Propietaria', CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (109, N'Importadora de Medicamentos Veterinarios SRL', N'20000009', N'Juan Carlos Chipana', N'Director Comercial', CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (110, N'Clínica Veterinaria del Valle', N'20000010', N'Carmen Colque', N'Administradora', CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (111, N'Cooperativa Ganadera Altiplano', N'20000011', N'Miguel Angel Mamani', N'Presidente', CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6570000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (112, N'Pet Care Center Sucre', N'20000012', N'Ana Maria Vargas', N'Gerente', CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (113, N'Alimentos Balanceados del Oriente', N'20000013', N'Roberto Torrez', N'Jefe de Producción', CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (114, N'Veterinaria Andina Potosí', N'20000014', N'Patricia Cruz', N'Veterinaria Principal', CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (115, N'Hacienda Ganadera La Esperanza', N'20000015', N'Luis Fernando Mendoza', N'Administrador', CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (116, N'Clínica Veterinaria Beni', N'20000016', N'Silvia Gutierrez', N'Directora', CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (117, N'Distribuidora de Insumos Pecuarios', N'20000017', N'Juan Huanca', N'Gerente de Distribución', CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (118, N'Centro de Investigación Veterinaria UMSA', N'20000018', N'Dra. Carmen Chipana', N'Directora de Investigación', CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6600000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (119, N'Farmacia Veterinaria Central', N'20000019', N'Miguel Colque', N'Farmacéutico Responsable', CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (120, N'Servicios Veterinarios Móviles Bolivia', N'20000020', N'Ana Rosa Mamani', N'Coordinadora de Servicios', CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (121, N'Clínica Veterinaria Los Andes', N'20000021', N'Dr. Javier Quispe', N'Director Médico', CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (122, N'Pet Shop Animal Kingdom', N'20000022', N'Sofia Mamani', N'Gerente', CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (123, N'Laboratorio Diagnóstico Veterinario', N'20000023', N'Dr. Carlos Condori', N'Jefe de Laboratorio', CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6630000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (124, N'Granja Porcina San Juan', N'20000024', N'Maria Flores', N'Administradora', CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (125, N'Veterinaria Express', N'20000025', N'Dr. Pedro Apaza', N'Propietario', CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (126, N'Centro de Reproducción Animal', N'20000026', N'Dra. Rosa Limachi', N'Especialista', CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (127, N'Distribuidora Farmacéutica Vet', N'20000027', N'Ing. Fernando Poma', N'Gerente General', CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (128, N'Clínica Veterinaria Norte', N'20000028', N'Dra. Gloria Cruz', N'Directora', CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6670000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (129, N'Empresa Ganadera Boliviana', N'20000029', N'Lic. Raul Ticona', N'Gerente', CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (130, N'Hospital Veterinario Central', N'20000030', N'Dr. Marta Yujra', N'Jefa de Cirugía', CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (131, N'Alimentos Premium para Mascotas', N'20000031', N'Daniel Choque', N'Director Comercial', CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (132, N'Clínica Veterinaria Sur', N'20000032', N'Dra. Elena Vargas', N'Propietaria', CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (133, N'Cooperativa Lechera Valle Alto', N'20000033', N'Antonio Torrez', N'Presidente', CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (134, N'Importadora de Equipos Veterinarios', N'20000034', N'Lucia Gutierrez', N'Gerente de Importaciones', CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6700000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (135, N'Veterinaria 24 Horas', N'20000035', N'Dr. Francisco Mendoza', N'Director', CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (136, N'Centro de Capacitación Veterinaria', N'20000036', N'Dra. Isabel Huanca', N'Coordinadora Académica', CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (137, N'Granja Avícola del Este', N'20000037', N'Ricardo Chipana', N'Gerente de Producción', CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (138, N'Clínica Veterinaria Especializada', N'20000038', N'Dra. Angela Colque', N'Especialista en Exóticos', CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (139, N'Distribuidora Nacional de Vacunas', N'20000039', N'Gonzalo Quispe', N'Gerente de Ventas', CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6730000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (140, N'Centro de Salud Animal', N'20000040', N'Teresa Mamani', N'Administradora', CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (141, N'Laboratorio de Análisis Clínicos Veterinarios', N'20000041', N'Dr. Hernan Condori', N'Director Técnico', CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (142, N'Pet Spa y Estética Canina', N'20000042', N'Roxana Flores', N'Propietaria', CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (143, N'Empresa de Transporte de Ganado', N'20000043', N'Alberto Apaza', N'Gerente Operativo', CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (144, N'Clínica Veterinaria de Pequeños Animales', N'20000044', N'Dra. Margarita Limachi', N'Especialista', CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6770000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (145, N'Distribuidora de Suplementos Nutricionales', N'20000045', N'Victor Poma', N'Director Comercial', CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (146, N'Centro de Rehabilitación Animal', N'20000046', N'Blanca Cruz', N'Fisioterapeuta Veterinaria', CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (147, N'Empresa de Inseminación Artificial', N'20000047', N'Alfredo Ticona', N'Técnico Especializado', CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (148, N'Veterinaria Rural del Altiplano', N'20000048', N'Dra. Veronica Yujra', N'Coordinadora Rural', CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (149, N'Centro de Diagnóstico por Imágenes', N'20000049', N'Dr. Julio Choque', N'Radiólogo Veterinario', CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (150, N'Granja Experimental de la Universidad', N'20000050', N'Monica Vargas', N'Coordinadora de Investigación', CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (151, N'Clínica Veterinaria de Emergencias', N'20000051', N'Dr. Sergio Torrez', N'Jefe de Emergencias', CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6800000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (152, N'Empresa de Productos Orgánicos para Mascotas', N'20000052', N'Graciela Gutierrez', N'Gerente de Producción', CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (153, N'Centro de Adopción de Animales', N'20000053', N'Jaime Mendoza', N'Coordinador', CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (154, N'Laboratorio de Genética Animal', N'20000054', N'Dra. Adriana Huanca', N'Genetista', CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (155, N'Veterinaria Especializada en Equinos', N'20000055', N'Dr. Marcelo Chipana', N'Especialista Equino', CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6830000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (156, N'Centro de Medicina Preventiva Animal', N'20000056', N'Claudia Colque', N'Epidemióloga Veterinaria', CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (157, N'Empresa de Biotecnología Veterinaria', N'20000057', N'Oscar Quispe', N'Director de I+D', CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (158, N'Clínica Veterinaria Móvil', N'20000058', N'Paola Mamani', N'Coordinadora', CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (159, N'Centro de Entrenamiento Canino', N'20000059', N'Ramiro Condori', N'Entrenador Profesional', CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (160, N'Empresa de Control de Plagas Veterinario', N'20000060', N'Ximena Flores', N'Técnica en Control', CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6870000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (161, N'Hospital Veterinario de Especialidades', N'20000061', N'Dr. Diego Apaza', N'Director Médico', CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (162, N'Empresa de Alimentos Concentrados', N'20000062', N'Carla Limachi', N'Nutricionista Animal', CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (163, N'Centro de Cirugía Veterinaria Avanzada', N'20000063', N'Dr. Rolando Poma', N'Cirujano Especialista', CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (164, N'Laboratorio de Microbiología Veterinaria', N'20000064', N'Beatriz Cruz', N'Microbióloga', CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (165, N'Clínica Veterinaria de Animales Exóticos', N'20000065', N'Dr. Gustavo Ticona', N'Especialista en Exóticos', CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (166, N'Centro de Reproducción Asistida Animal', N'20000066', N'Lorena Yujra', N'Embrióloga', CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (167, N'Empresa de Servicios Veterinarios Integrales', N'20000067', N'Ernesto Choque', N'Gerente General', CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (168, N'Centro de Terapias Alternativas para Animales', N'20000068', N'Vanessa Vargas', N'Terapeuta Holística', CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6900000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (169, N'Distribuidora de Material Quirúrgico Veterinario', N'20000069', N'Mario Torrez', N'Especialista en Equipos', CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (170, N'Clínica Veterinaria Comunitaria', N'20000070', N'Natalia Gutierrez', N'Coordinadora Social', CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (171, N'Centro de Investigación en Enfermedades Animales', N'20000071', N'Dr. Hector Mendoza', N'Investigador Principal', CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (172, N'Empresa de Cremación de Mascotas', N'20000072', N'Andrea Huanca', N'Directora de Servicios', CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (173, N'Centro de Oncología Veterinaria', N'20000073', N'Dr. Gabriel Chipana', N'Oncólogo Veterinario', CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6930000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (174, N'Laboratorio de Patología Veterinaria', N'20000074', N'Daniela Colque', N'Patóloga', CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (175, N'Clínica Veterinaria Geriátrica', N'20000075', N'Dr. Felipe Quispe', N'Geriatra Veterinario', CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (176, N'Centro de Fisioterapia Animal', N'20000076', N'Valeria Mamani', N'Fisioterapeuta', CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (177, N'Empresa de Seguros para Mascotas', N'20000077', N'Rodrigo Condori', N'Gerente de Seguros', CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (178, N'Centro de Nutrición Animal Especializada', N'20000078', N'Alejandra Flores', N'Nutricionista', CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2), CAST(N'2025-08-29T19:33:43.6970000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (179, N'Clínica Veterinaria de Comportamiento Animal', N'20000079', N'Dr. Andres Apaza', N'Etólogo', CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (180, N'Centro de Acuicultura Veterinaria', N'20000080', N'Karina Limachi', N'Especialista en Peces', CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (181, N'Hospital Veterinario Universitario', N'20000081', N'Dr. Cristian Poma', N'Director Académico', CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (182, N'Empresa de Biotecnología Reproductiva', N'20000082', N'Soledad Cruz', N'Biotecnóloga', CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (183, N'Centro de Medicina Deportiva Canina', N'20000083', N'Mauricio Ticona', N'Médico Deportivo', CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (184, N'Laboratorio de Análisis de Alimentos', N'20000084', N'Fabiola Yujra', N'Analista de Calidad', CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (185, N'Clínica Veterinaria Pediátrica', N'20000085', N'Dr. Ivan Choque', N'Pediatra Veterinario', CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7000000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (186, N'Centro de Donación de Sangre Animal', N'20000086', N'Pamela Vargas', N'Hematóloga', CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (187, N'Empresa de Productos Farmacéuticos Veterinarios', N'20000087', N'Aldo Torrez', N'Director de Producción', CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (188, N'Centro de Rehabilitación de Fauna Silvestre', N'20000088', N'Miriam Gutierrez', N'Bióloga', CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (189, N'Clínica Veterinaria de Medicina Interna', N'20000089', N'Dr. Armando Mendoza', N'Internista', CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (190, N'Centro de Telemedicina Veterinaria', N'20000090', N'Jimena Huanca', N'Coordinadora Tecnológica', CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7030000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (191, N'Empresa de Logística Veterinaria', N'20000091', N'Esteban Chipana', N'Gerente Logístico', CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (192, N'Centro de Investigación en Zoonosis', N'20000092', N'Rebeca Colque', N'Epidemióloga', CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (193, N'Clínica Veterinaria de Urgencias Nocturnas', N'20000093', N'Dr. Ignacio Quispe', N'Jefe de Urgencias', CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (194, N'Centro de Capacitación en Bienestar Animal', N'20000094', N'Sonia Mamani', N'Especialista en Bienestar', CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (195, N'Empresa de Consultoría Veterinaria', N'20000095', N'Nestor Condori', N'Consultor Senior', CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7070000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (196, N'Centro de Medicina Forense Veterinaria', N'20000096', N'Lilian Flores', N'Médico Forense', CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (197, N'Empresa de Gestión de Residuos Veterinarios', N'20000097', N'Walter Apaza', N'Especialista Ambiental', CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (198, N'Centro de Educación Veterinaria Continua', N'20000098', N'Gladys Limachi', N'Coordinadora Educativa', CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (199, N'Clínica Veterinaria de Medicina Tradicional', N'20000099', N'Dr. Gerardo Poma', N'Especialista en Medicina Tradicional', CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2))
INSERT [dbo].[persona_juridica] ([id], [razon_social], [nit], [encargado_nombre], [encargado_cargo], [created_at], [updated_at]) VALUES (200, N'Centro Internacional de Salud Animal', N'20000100', N'Carolina Cruz', N'Directora Internacional', CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2), CAST(N'2025-08-29T19:33:43.7100000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[personal] ON 

INSERT [dbo].[personal] ([id], [nombre], [apellido], [email], [usuario], [contrasena], [telefono], [direccion], [fecha_contratacion], [salario], [rol], [activo], [fecha_ultimo_acceso], [creado_por], [modificado_por], [fecha_modificacion], [created_at], [updated_at]) VALUES (1, N'Administrador', N'del Sistema', N'admin@veterinaria.com', N'admin', N'admin123', N'0000000000', NULL, CAST(N'2025-08-29' AS Date), NULL, N'Administrador', 1, NULL, N'Sistema', NULL, NULL, CAST(N'2025-08-29T19:33:43.4470000' AS DateTime2), CAST(N'2025-08-29T19:33:43.4470000' AS DateTime2))
INSERT [dbo].[personal] ([id], [nombre], [apellido], [email], [usuario], [contrasena], [telefono], [direccion], [fecha_contratacion], [salario], [rol], [activo], [fecha_ultimo_acceso], [creado_por], [modificado_por], [fecha_modificacion], [created_at], [updated_at]) VALUES (2, N'Dr. Carlos', N'Mendoza Silva', N'cmendoza@vet.com', N'cmendoza', N'vet123', N'78123456', N'Av. América #123', CAST(N'2025-08-29' AS Date), CAST(8000.00 AS Decimal(10, 2)), N'Usuario', 1, NULL, N'Sistema', NULL, NULL, CAST(N'2025-08-29T19:33:43.9200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.9200000' AS DateTime2))
INSERT [dbo].[personal] ([id], [nombre], [apellido], [email], [usuario], [contrasena], [telefono], [direccion], [fecha_contratacion], [salario], [rol], [activo], [fecha_ultimo_acceso], [creado_por], [modificado_por], [fecha_modificacion], [created_at], [updated_at]) VALUES (3, N'Dra. Ana', N'Rodriguez Lopez', N'arodriguez@vet.com', N'arodriguez', N'vet456', N'69234567', N'Calle Sucre #456', CAST(N'2025-08-29' AS Date), CAST(9000.00 AS Decimal(10, 2)), N'Usuario', 1, NULL, N'Sistema', NULL, NULL, CAST(N'2025-08-29T19:33:43.9230000' AS DateTime2), CAST(N'2025-08-29T19:33:43.9230000' AS DateTime2))
INSERT [dbo].[personal] ([id], [nombre], [apellido], [email], [usuario], [contrasena], [telefono], [direccion], [fecha_contratacion], [salario], [rol], [activo], [fecha_ultimo_acceso], [creado_por], [modificado_por], [fecha_modificacion], [created_at], [updated_at]) VALUES (4, N'Dr. Miguel', N'Vargas Quispe', N'mvargas@vet.com', N'mvargas', N'vet789', N'71345678', N'Av. 6 de Agosto #789', CAST(N'2025-08-29' AS Date), CAST(7500.00 AS Decimal(10, 2)), N'Usuario', 1, NULL, N'Sistema', NULL, NULL, CAST(N'2025-08-29T19:33:43.9230000' AS DateTime2), CAST(N'2025-08-29T19:33:43.9230000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[personal] OFF
GO
INSERT [dbo].[personal_veterinario] ([id], [num_licencia], [especialidad], [universidad], [anios_experiencia], [created_at], [updated_at]) VALUES (2, N'VET001', N'Medicina General', N'UMSA', 0, CAST(N'2025-08-29T19:33:43.9200000' AS DateTime2), CAST(N'2025-08-29T19:33:43.9200000' AS DateTime2))
INSERT [dbo].[personal_veterinario] ([id], [num_licencia], [especialidad], [universidad], [anios_experiencia], [created_at], [updated_at]) VALUES (3, N'VET002', N'Cirugía', N'UCB', 0, CAST(N'2025-08-29T19:33:43.9230000' AS DateTime2), CAST(N'2025-08-29T19:33:43.9230000' AS DateTime2))
INSERT [dbo].[personal_veterinario] ([id], [num_licencia], [especialidad], [universidad], [anios_experiencia], [created_at], [updated_at]) VALUES (4, N'VET003', N'Pequeños Animales', N'UPSA', 0, CAST(N'2025-08-29T19:33:43.9230000' AS DateTime2), CAST(N'2025-08-29T19:33:43.9230000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[producto] ON 

INSERT [dbo].[producto] ([id], [codigo], [nombre], [descripcion], [precio], [stock_minimo], [stock_actual], [requiere_receta], [categoria_id], [activo], [created_at], [updated_at]) VALUES (1, N'MED001', N'Antibiótico Amoxicilina 500mg', NULL, CAST(25.50 AS Decimal(10, 2)), 10, 1000, 1, 1, 1, CAST(N'2025-08-29T19:33:43.8770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8770000' AS DateTime2))
INSERT [dbo].[producto] ([id], [codigo], [nombre], [descripcion], [precio], [stock_minimo], [stock_actual], [requiere_receta], [categoria_id], [activo], [created_at], [updated_at]) VALUES (2, N'MED002', N'Antiparasitario Interno', NULL, CAST(18.75 AS Decimal(10, 2)), 15, 800, 1, 1, 1, CAST(N'2025-08-29T19:33:43.8770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8770000' AS DateTime2))
INSERT [dbo].[producto] ([id], [codigo], [nombre], [descripcion], [precio], [stock_minimo], [stock_actual], [requiere_receta], [categoria_id], [activo], [created_at], [updated_at]) VALUES (3, N'MED003', N'Vacuna Antirrábica', NULL, CAST(35.00 AS Decimal(10, 2)), 20, 500, 1, 1, 1, CAST(N'2025-08-29T19:33:43.8770000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8770000' AS DateTime2))
INSERT [dbo].[producto] ([id], [codigo], [nombre], [descripcion], [precio], [stock_minimo], [stock_actual], [requiere_receta], [categoria_id], [activo], [created_at], [updated_at]) VALUES (4, N'MED004', N'Vitaminas B Complex', NULL, CAST(12.25 AS Decimal(10, 2)), 25, 600, 1, 1, 1, CAST(N'2025-08-29T19:33:43.8800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8800000' AS DateTime2))
INSERT [dbo].[producto] ([id], [codigo], [nombre], [descripcion], [precio], [stock_minimo], [stock_actual], [requiere_receta], [categoria_id], [activo], [created_at], [updated_at]) VALUES (5, N'MED005', N'Antiinflamatorio Meloxicam', NULL, CAST(28.90 AS Decimal(10, 2)), 12, 400, 1, 1, 1, CAST(N'2025-08-29T19:33:43.8800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8800000' AS DateTime2))
INSERT [dbo].[producto] ([id], [codigo], [nombre], [descripcion], [precio], [stock_minimo], [stock_actual], [requiere_receta], [categoria_id], [activo], [created_at], [updated_at]) VALUES (6, N'MED006', N'Desparasitante Externo', NULL, CAST(15.60 AS Decimal(10, 2)), 18, 700, 1, 1, 1, CAST(N'2025-08-29T19:33:43.8800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8800000' AS DateTime2))
INSERT [dbo].[producto] ([id], [codigo], [nombre], [descripcion], [precio], [stock_minimo], [stock_actual], [requiere_receta], [categoria_id], [activo], [created_at], [updated_at]) VALUES (7, N'MED007', N'Suplemento Nutricional', NULL, CAST(22.40 AS Decimal(10, 2)), 8, 350, 1, 1, 1, CAST(N'2025-08-29T19:33:43.8800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8800000' AS DateTime2))
INSERT [dbo].[producto] ([id], [codigo], [nombre], [descripcion], [precio], [stock_minimo], [stock_actual], [requiere_receta], [categoria_id], [activo], [created_at], [updated_at]) VALUES (8, N'MED008', N'Analgésico Tramadol', NULL, CAST(45.80 AS Decimal(10, 2)), 5, 300, 1, 1, 1, CAST(N'2025-08-29T19:33:43.8830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8830000' AS DateTime2))
INSERT [dbo].[producto] ([id], [codigo], [nombre], [descripcion], [precio], [stock_minimo], [stock_actual], [requiere_receta], [categoria_id], [activo], [created_at], [updated_at]) VALUES (9, N'MED009', N'Antibiótico Cefalexina', NULL, CAST(38.25 AS Decimal(10, 2)), 15, 450, 1, 1, 1, CAST(N'2025-08-29T19:33:43.8830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8830000' AS DateTime2))
INSERT [dbo].[producto] ([id], [codigo], [nombre], [descripcion], [precio], [stock_minimo], [stock_actual], [requiere_receta], [categoria_id], [activo], [created_at], [updated_at]) VALUES (10, N'MED010', N'Probiótico Veterinario', NULL, CAST(32.50 AS Decimal(10, 2)), 10, 250, 1, 1, 1, CAST(N'2025-08-29T19:33:43.8830000' AS DateTime2), CAST(N'2025-08-29T19:33:43.8830000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[producto] OFF
GO
SET IDENTITY_INSERT [dbo].[ubicacion_almacen] ON 

INSERT [dbo].[ubicacion_almacen] ([id], [codigo], [nombre], [descripcion], [activo], [created_at], [updated_at]) VALUES (1, N'PRINCIPAL', N'Almacén Principal', N'Ubicación principal de almacenamiento', 1, CAST(N'2025-08-29T19:33:43.2800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.2800000' AS DateTime2))
INSERT [dbo].[ubicacion_almacen] ([id], [codigo], [nombre], [descripcion], [activo], [created_at], [updated_at]) VALUES (2, N'FARMACIA', N'Farmacia', N'Medicamentos y productos farmacéuticos', 1, CAST(N'2025-08-29T19:33:43.2800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.2800000' AS DateTime2))
INSERT [dbo].[ubicacion_almacen] ([id], [codigo], [nombre], [descripcion], [activo], [created_at], [updated_at]) VALUES (3, N'CONSULTA', N'Sala de Consulta', N'Productos para consultas veterinarias', 1, CAST(N'2025-08-29T19:33:43.2800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.2800000' AS DateTime2))
INSERT [dbo].[ubicacion_almacen] ([id], [codigo], [nombre], [descripcion], [activo], [created_at], [updated_at]) VALUES (4, N'CIRUGIA', N'Quirófano', N'Instrumental y medicamentos quirúrgicos', 1, CAST(N'2025-08-29T19:33:43.2800000' AS DateTime2), CAST(N'2025-08-29T19:33:43.2800000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ubicacion_almacen] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_animal_microchip]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[animal] ADD  CONSTRAINT [UK_animal_microchip] UNIQUE NONCLUSTERED 
(
	[microchip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_animal_nombre]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_animal_nombre] ON [dbo].[animal]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_animal_persona_id]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_animal_persona_id] ON [dbo].[animal]
(
	[persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_categoria_nombre]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[categoria] ADD  CONSTRAINT [UK_categoria_nombre] UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_detalle_historico_historico_id]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_detalle_historico_historico_id] ON [dbo].[detalle_historico]
(
	[historico_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_detalle_historico_tipo_evento]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_detalle_historico_tipo_evento] ON [dbo].[detalle_historico]
(
	[tipo_evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_detalle_productos_factura_id]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_detalle_productos_factura_id] ON [dbo].[detalle_productos]
(
	[factura_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_detalle_servicios_factura_id]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_detalle_servicios_factura_id] ON [dbo].[detalle_servicios]
(
	[factura_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_diagnostico_codigo]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[diagnostico] ADD  CONSTRAINT [UK_diagnostico_codigo] UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_factura_numero]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[factura] ADD  CONSTRAINT [UK_factura_numero] UNIQUE NONCLUSTERED 
(
	[numero_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_factura_fecha_emision]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_factura_fecha_emision] ON [dbo].[factura]
(
	[fecha_emision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_factura_persona_id]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_factura_persona_id] ON [dbo].[factura]
(
	[persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_historico_animal]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[historico] ADD  CONSTRAINT [UK_historico_animal] UNIQUE NONCLUSTERED 
(
	[animal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_historico_animal_id]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_historico_animal_id] ON [dbo].[historico]
(
	[animal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_persona_tipo]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_persona_tipo] ON [dbo].[persona]
(
	[tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_persona_fisica_ci]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[persona_fisica] ADD  CONSTRAINT [UK_persona_fisica_ci] UNIQUE NONCLUSTERED 
(
	[ci] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_persona_fisica_ci]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_persona_fisica_ci] ON [dbo].[persona_fisica]
(
	[ci] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_persona_fisica_nombre_apellido]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_persona_fisica_nombre_apellido] ON [dbo].[persona_fisica]
(
	[nombre] ASC,
	[apellido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_persona_juridica_nit]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[persona_juridica] ADD  CONSTRAINT [UK_persona_juridica_nit] UNIQUE NONCLUSTERED 
(
	[nit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_persona_juridica_nit]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_persona_juridica_nit] ON [dbo].[persona_juridica]
(
	[nit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_personal_email]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[personal] ADD  CONSTRAINT [UK_personal_email] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_personal_usuario]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[personal] ADD  CONSTRAINT [UK_personal_usuario] UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_personal_usuario]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_personal_usuario] ON [dbo].[personal]
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_personal_veterinario_licencia]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[personal_veterinario] ADD  CONSTRAINT [UK_personal_veterinario_licencia] UNIQUE NONCLUSTERED 
(
	[num_licencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_producto_codigo]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[producto] ADD  CONSTRAINT [UK_producto_codigo] UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_producto_categoria_id]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_producto_categoria_id] ON [dbo].[producto]
(
	[categoria_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_producto_nombre]    Script Date: 01/09/2025 14:32:31 ******/
CREATE NONCLUSTERED INDEX [IX_producto_nombre] ON [dbo].[producto]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_stock_ubicacion_producto_ubicacion]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[stock_ubicacion] ADD  CONSTRAINT [UK_stock_ubicacion_producto_ubicacion] UNIQUE NONCLUSTERED 
(
	[producto_id] ASC,
	[ubicacion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_ubicacion_almacen_codigo]    Script Date: 01/09/2025 14:32:31 ******/
ALTER TABLE [dbo].[ubicacion_almacen] ADD  CONSTRAINT [UK_ubicacion_almacen_codigo] UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[animal] ADD  DEFAULT ((0)) FOR [esterilizado]
GO
ALTER TABLE [dbo].[animal] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[animal] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[animal] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[categoria] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[categoria] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[categoria] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[detalle_historico] ADD  DEFAULT (getdate()) FOR [fecha_evento]
GO
ALTER TABLE [dbo].[detalle_historico] ADD  DEFAULT ((0)) FOR [cobrado]
GO
ALTER TABLE [dbo].[detalle_historico] ADD  DEFAULT ((0)) FOR [costo]
GO
ALTER TABLE [dbo].[detalle_historico] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[detalle_historico] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[detalle_productos] ADD  DEFAULT ((0)) FOR [descuento_unitario]
GO
ALTER TABLE [dbo].[detalle_productos] ADD  DEFAULT ((0)) FOR [subtotal]
GO
ALTER TABLE [dbo].[detalle_productos] ADD  DEFAULT ((0)) FOR [receta_verificada]
GO
ALTER TABLE [dbo].[detalle_productos] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[detalle_productos] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[detalle_servicios] ADD  DEFAULT ((1)) FOR [cantidad]
GO
ALTER TABLE [dbo].[detalle_servicios] ADD  DEFAULT ((0)) FOR [descuento_unitario]
GO
ALTER TABLE [dbo].[detalle_servicios] ADD  DEFAULT ((0)) FOR [subtotal]
GO
ALTER TABLE [dbo].[detalle_servicios] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[detalle_servicios] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[diagnostico] ADD  DEFAULT ((0)) FOR [precio_base]
GO
ALTER TABLE [dbo].[diagnostico] ADD  DEFAULT ((0)) FOR [requiere_equipamiento]
GO
ALTER TABLE [dbo].[diagnostico] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[diagnostico] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[diagnostico] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[factura] ADD  DEFAULT (getdate()) FOR [fecha_emision]
GO
ALTER TABLE [dbo].[factura] ADD  DEFAULT ((0)) FOR [subtotal]
GO
ALTER TABLE [dbo].[factura] ADD  DEFAULT ((0)) FOR [impuestos]
GO
ALTER TABLE [dbo].[factura] ADD  DEFAULT ((0)) FOR [descuentos]
GO
ALTER TABLE [dbo].[factura] ADD  DEFAULT ((0)) FOR [total]
GO
ALTER TABLE [dbo].[factura] ADD  DEFAULT ('Pendiente') FOR [estado]
GO
ALTER TABLE [dbo].[factura] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[factura] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[historico] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[historico] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[movimiento_inventario] ADD  DEFAULT ('Sistema') FOR [usuario]
GO
ALTER TABLE [dbo].[movimiento_inventario] ADD  DEFAULT (getdate()) FOR [fecha_movimiento]
GO
ALTER TABLE [dbo].[movimiento_inventario] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[persona] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[persona] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[persona] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[persona_fisica] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[persona_fisica] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[persona_juridica] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[persona_juridica] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[personal] ADD  DEFAULT (getdate()) FOR [fecha_contratacion]
GO
ALTER TABLE [dbo].[personal] ADD  DEFAULT ('Usuario') FOR [rol]
GO
ALTER TABLE [dbo].[personal] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[personal] ADD  DEFAULT ('Sistema') FOR [creado_por]
GO
ALTER TABLE [dbo].[personal] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[personal] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[personal_auxiliar] ADD  DEFAULT ('Básico') FOR [nivel]
GO
ALTER TABLE [dbo].[personal_auxiliar] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[personal_auxiliar] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[personal_veterinario] ADD  DEFAULT ((0)) FOR [anios_experiencia]
GO
ALTER TABLE [dbo].[personal_veterinario] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[personal_veterinario] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT ((5)) FOR [stock_minimo]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT ((0)) FOR [stock_actual]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT ((1)) FOR [requiere_receta]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[stock_ubicacion] ADD  DEFAULT ((0)) FOR [stock_actual]
GO
ALTER TABLE [dbo].[stock_ubicacion] ADD  DEFAULT ((0)) FOR [stock_reservado]
GO
ALTER TABLE [dbo].[stock_ubicacion] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[stock_ubicacion] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[ubicacion_almacen] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[ubicacion_almacen] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[ubicacion_almacen] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[animal]  WITH CHECK ADD  CONSTRAINT [FK_animal_persona] FOREIGN KEY([persona_id])
REFERENCES [dbo].[persona] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[animal] CHECK CONSTRAINT [FK_animal_persona]
GO
ALTER TABLE [dbo].[detalle_historico]  WITH CHECK ADD  CONSTRAINT [FK_detalle_historico_historico] FOREIGN KEY([historico_id])
REFERENCES [dbo].[historico] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalle_historico] CHECK CONSTRAINT [FK_detalle_historico_historico]
GO
ALTER TABLE [dbo].[detalle_historico]  WITH CHECK ADD  CONSTRAINT [FK_detalle_historico_veterinario] FOREIGN KEY([veterinario_id])
REFERENCES [dbo].[personal_veterinario] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[detalle_historico] CHECK CONSTRAINT [FK_detalle_historico_veterinario]
GO
ALTER TABLE [dbo].[detalle_productos]  WITH CHECK ADD  CONSTRAINT [FK_detalle_productos_factura] FOREIGN KEY([factura_id])
REFERENCES [dbo].[factura] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalle_productos] CHECK CONSTRAINT [FK_detalle_productos_factura]
GO
ALTER TABLE [dbo].[detalle_productos]  WITH CHECK ADD  CONSTRAINT [FK_detalle_productos_producto] FOREIGN KEY([producto_id])
REFERENCES [dbo].[producto] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[detalle_productos] CHECK CONSTRAINT [FK_detalle_productos_producto]
GO
ALTER TABLE [dbo].[detalle_servicios]  WITH CHECK ADD  CONSTRAINT [FK_detalle_servicios_diagnostico] FOREIGN KEY([diagnostico_id])
REFERENCES [dbo].[diagnostico] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[detalle_servicios] CHECK CONSTRAINT [FK_detalle_servicios_diagnostico]
GO
ALTER TABLE [dbo].[detalle_servicios]  WITH CHECK ADD  CONSTRAINT [FK_detalle_servicios_factura] FOREIGN KEY([factura_id])
REFERENCES [dbo].[factura] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalle_servicios] CHECK CONSTRAINT [FK_detalle_servicios_factura]
GO
ALTER TABLE [dbo].[detalle_servicios]  WITH CHECK ADD  CONSTRAINT [FK_detalle_servicios_historico] FOREIGN KEY([detalle_historico_id])
REFERENCES [dbo].[detalle_historico] ([id])
GO
ALTER TABLE [dbo].[detalle_servicios] CHECK CONSTRAINT [FK_detalle_servicios_historico]
GO
ALTER TABLE [dbo].[detalle_servicios]  WITH CHECK ADD  CONSTRAINT [FK_detalle_servicios_veterinario] FOREIGN KEY([veterinario_id])
REFERENCES [dbo].[personal_veterinario] ([id])
GO
ALTER TABLE [dbo].[detalle_servicios] CHECK CONSTRAINT [FK_detalle_servicios_veterinario]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_persona] FOREIGN KEY([persona_id])
REFERENCES [dbo].[persona] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_persona]
GO
ALTER TABLE [dbo].[historico]  WITH CHECK ADD  CONSTRAINT [FK_historico_animal] FOREIGN KEY([animal_id])
REFERENCES [dbo].[animal] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[historico] CHECK CONSTRAINT [FK_historico_animal]
GO
ALTER TABLE [dbo].[movimiento_inventario]  WITH CHECK ADD  CONSTRAINT [FK_movimiento_producto] FOREIGN KEY([producto_id])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[movimiento_inventario] CHECK CONSTRAINT [FK_movimiento_producto]
GO
ALTER TABLE [dbo].[movimiento_inventario]  WITH CHECK ADD  CONSTRAINT [FK_movimiento_ubicacion_destino] FOREIGN KEY([ubicacion_destino_id])
REFERENCES [dbo].[ubicacion_almacen] ([id])
GO
ALTER TABLE [dbo].[movimiento_inventario] CHECK CONSTRAINT [FK_movimiento_ubicacion_destino]
GO
ALTER TABLE [dbo].[movimiento_inventario]  WITH CHECK ADD  CONSTRAINT [FK_movimiento_ubicacion_origen] FOREIGN KEY([ubicacion_origen_id])
REFERENCES [dbo].[ubicacion_almacen] ([id])
GO
ALTER TABLE [dbo].[movimiento_inventario] CHECK CONSTRAINT [FK_movimiento_ubicacion_origen]
GO
ALTER TABLE [dbo].[persona_fisica]  WITH CHECK ADD  CONSTRAINT [FK_persona_fisica_persona] FOREIGN KEY([id])
REFERENCES [dbo].[persona] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[persona_fisica] CHECK CONSTRAINT [FK_persona_fisica_persona]
GO
ALTER TABLE [dbo].[persona_juridica]  WITH CHECK ADD  CONSTRAINT [FK_persona_juridica_persona] FOREIGN KEY([id])
REFERENCES [dbo].[persona] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[persona_juridica] CHECK CONSTRAINT [FK_persona_juridica_persona]
GO
ALTER TABLE [dbo].[personal_auxiliar]  WITH CHECK ADD  CONSTRAINT [FK_personal_auxiliar_personal] FOREIGN KEY([id])
REFERENCES [dbo].[personal] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[personal_auxiliar] CHECK CONSTRAINT [FK_personal_auxiliar_personal]
GO
ALTER TABLE [dbo].[personal_veterinario]  WITH CHECK ADD  CONSTRAINT [FK_personal_veterinario_personal] FOREIGN KEY([id])
REFERENCES [dbo].[personal] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[personal_veterinario] CHECK CONSTRAINT [FK_personal_veterinario_personal]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_categoria] FOREIGN KEY([categoria_id])
REFERENCES [dbo].[categoria] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_categoria]
GO
ALTER TABLE [dbo].[stock_ubicacion]  WITH CHECK ADD  CONSTRAINT [FK_stock_ubicacion_producto] FOREIGN KEY([producto_id])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[stock_ubicacion] CHECK CONSTRAINT [FK_stock_ubicacion_producto]
GO
ALTER TABLE [dbo].[stock_ubicacion]  WITH CHECK ADD  CONSTRAINT [FK_stock_ubicacion_ubicacion] FOREIGN KEY([ubicacion_id])
REFERENCES [dbo].[ubicacion_almacen] ([id])
GO
ALTER TABLE [dbo].[stock_ubicacion] CHECK CONSTRAINT [FK_stock_ubicacion_ubicacion]
GO
ALTER TABLE [dbo].[animal]  WITH CHECK ADD  CONSTRAINT [CK_animal_genero] CHECK  (([genero]='F' OR [genero]='M' OR [genero] IS NULL))
GO
ALTER TABLE [dbo].[animal] CHECK CONSTRAINT [CK_animal_genero]
GO
ALTER TABLE [dbo].[animal]  WITH CHECK ADD  CONSTRAINT [CK_animal_peso] CHECK  (([peso]>(0) OR [peso] IS NULL))
GO
ALTER TABLE [dbo].[animal] CHECK CONSTRAINT [CK_animal_peso]
GO
ALTER TABLE [dbo].[detalle_historico]  WITH CHECK ADD  CONSTRAINT [CK_detalle_costo] CHECK  (([costo]>=(0) OR [costo] IS NULL))
GO
ALTER TABLE [dbo].[detalle_historico] CHECK CONSTRAINT [CK_detalle_costo]
GO
ALTER TABLE [dbo].[detalle_historico]  WITH CHECK ADD  CONSTRAINT [CK_detalle_historico_tipo] CHECK  (([tipo_evento]='Consulta' OR [tipo_evento]='Cirugia' OR [tipo_evento]='Vacunacion' OR [tipo_evento]='Control' OR [tipo_evento]='Tratamiento' OR [tipo_evento]='Diagnostico'))
GO
ALTER TABLE [dbo].[detalle_historico] CHECK CONSTRAINT [CK_detalle_historico_tipo]
GO
ALTER TABLE [dbo].[detalle_historico]  WITH CHECK ADD  CONSTRAINT [CK_detalle_peso] CHECK  (([peso_animal]>(0) OR [peso_animal] IS NULL))
GO
ALTER TABLE [dbo].[detalle_historico] CHECK CONSTRAINT [CK_detalle_peso]
GO
ALTER TABLE [dbo].[detalle_historico]  WITH CHECK ADD  CONSTRAINT [CK_detalle_temperatura] CHECK  (([temperatura]>=(35.0) AND [temperatura]<=(45.0) OR [temperatura] IS NULL))
GO
ALTER TABLE [dbo].[detalle_historico] CHECK CONSTRAINT [CK_detalle_temperatura]
GO
ALTER TABLE [dbo].[detalle_productos]  WITH CHECK ADD  CONSTRAINT [CK_detalle_productos_cantidad] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[detalle_productos] CHECK CONSTRAINT [CK_detalle_productos_cantidad]
GO
ALTER TABLE [dbo].[detalle_productos]  WITH CHECK ADD  CONSTRAINT [CK_detalle_productos_precios] CHECK  (([precio_unitario]>=(0) AND [descuento_unitario]>=(0) AND [subtotal]>=(0)))
GO
ALTER TABLE [dbo].[detalle_productos] CHECK CONSTRAINT [CK_detalle_productos_precios]
GO
ALTER TABLE [dbo].[detalle_servicios]  WITH CHECK ADD  CONSTRAINT [CK_detalle_servicios_cantidad] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[detalle_servicios] CHECK CONSTRAINT [CK_detalle_servicios_cantidad]
GO
ALTER TABLE [dbo].[detalle_servicios]  WITH CHECK ADD  CONSTRAINT [CK_detalle_servicios_precios] CHECK  (([precio_unitario]>=(0) AND [descuento_unitario]>=(0) AND [subtotal]>=(0)))
GO
ALTER TABLE [dbo].[detalle_servicios] CHECK CONSTRAINT [CK_detalle_servicios_precios]
GO
ALTER TABLE [dbo].[diagnostico]  WITH CHECK ADD  CONSTRAINT [CK_diagnostico_precio] CHECK  (([precio_base]>=(0)))
GO
ALTER TABLE [dbo].[diagnostico] CHECK CONSTRAINT [CK_diagnostico_precio]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [CK_factura_estado] CHECK  (([estado]='Anulada' OR [estado]='Cancelada' OR [estado]='Pagada' OR [estado]='Pendiente'))
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [CK_factura_estado]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [CK_factura_montos] CHECK  (([subtotal]>=(0) AND [impuestos]>=(0) AND [descuentos]>=(0) AND [total]>=(0)))
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [CK_factura_montos]
GO
ALTER TABLE [dbo].[movimiento_inventario]  WITH CHECK ADD  CONSTRAINT [CK_movimiento_cantidad] CHECK  (([cantidad]<>(0)))
GO
ALTER TABLE [dbo].[movimiento_inventario] CHECK CONSTRAINT [CK_movimiento_cantidad]
GO
ALTER TABLE [dbo].[movimiento_inventario]  WITH CHECK ADD  CONSTRAINT [CK_movimiento_tipo] CHECK  (([tipo_movimiento]='TRANSFERENCIA' OR [tipo_movimiento]='AJUSTE' OR [tipo_movimiento]='SALIDA' OR [tipo_movimiento]='ENTRADA'))
GO
ALTER TABLE [dbo].[movimiento_inventario] CHECK CONSTRAINT [CK_movimiento_tipo]
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [CK_persona_email] CHECK  (([email] like '%@%' OR [email] IS NULL))
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [CK_persona_email]
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [CK_persona_tipo] CHECK  (([tipo]='Jurídica' OR [tipo]='Física'))
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [CK_persona_tipo]
GO
ALTER TABLE [dbo].[persona_fisica]  WITH CHECK ADD  CONSTRAINT [CK_persona_fisica_genero] CHECK  (([genero]='F' OR [genero]='M' OR [genero] IS NULL))
GO
ALTER TABLE [dbo].[persona_fisica] CHECK CONSTRAINT [CK_persona_fisica_genero]
GO
ALTER TABLE [dbo].[personal]  WITH CHECK ADD  CONSTRAINT [CK_personal_email] CHECK  (([email] like '%@%'))
GO
ALTER TABLE [dbo].[personal] CHECK CONSTRAINT [CK_personal_email]
GO
ALTER TABLE [dbo].[personal]  WITH CHECK ADD  CONSTRAINT [CK_personal_salario] CHECK  (([salario]>=(0) OR [salario] IS NULL))
GO
ALTER TABLE [dbo].[personal] CHECK CONSTRAINT [CK_personal_salario]
GO
ALTER TABLE [dbo].[personal_auxiliar]  WITH CHECK ADD  CONSTRAINT [CK_auxiliar_nivel] CHECK  (([nivel]='Avanzado' OR [nivel]='Intermedio' OR [nivel]='Básico'))
GO
ALTER TABLE [dbo].[personal_auxiliar] CHECK CONSTRAINT [CK_auxiliar_nivel]
GO
ALTER TABLE [dbo].[personal_auxiliar]  WITH CHECK ADD  CONSTRAINT [CK_personal_auxiliar_turno] CHECK  (([turno]='Noche' OR [turno]='Tarde' OR [turno]='Mañana'))
GO
ALTER TABLE [dbo].[personal_auxiliar] CHECK CONSTRAINT [CK_personal_auxiliar_turno]
GO
ALTER TABLE [dbo].[personal_veterinario]  WITH CHECK ADD  CONSTRAINT [CK_veterinario_experiencia] CHECK  (([anios_experiencia]>=(0)))
GO
ALTER TABLE [dbo].[personal_veterinario] CHECK CONSTRAINT [CK_veterinario_experiencia]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [CK_producto_precio] CHECK  (([precio]>=(0)))
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [CK_producto_precio]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [CK_producto_stock] CHECK  (([stock_actual]>=(0) AND [stock_minimo]>=(0)))
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [CK_producto_stock]
GO
ALTER TABLE [dbo].[stock_ubicacion]  WITH CHECK ADD  CONSTRAINT [CK_stock_ubicacion_stock] CHECK  (([stock_actual]>=(0) AND [stock_reservado]>=(0)))
GO
ALTER TABLE [dbo].[stock_ubicacion] CHECK CONSTRAINT [CK_stock_ubicacion_stock]
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarStock]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizarStock]
    @producto_id INT,
    @nuevo_stock INT,
    @motivo VARCHAR(255) = NULL,
    @referencia VARCHAR(100) = NULL,
    @usuario VARCHAR(50) = 'Sistema'
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @stock_anterior INT;
    DECLARE @diferencia INT;
    DECLARE @tipo_movimiento VARCHAR(20);

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Obtener stock actual
        SELECT @stock_anterior = stock_actual 
        FROM producto 
        WHERE id = @producto_id;

        IF @stock_anterior IS NULL
        BEGIN
            SELECT 0 as resultado, 'Producto no encontrado' as mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Calcular diferencia y tipo de movimiento
        SET @diferencia = @nuevo_stock - @stock_anterior;
        
        IF @diferencia > 0
            SET @tipo_movimiento = 'ENTRADA';
        ELSE IF @diferencia < 0
            SET @tipo_movimiento = 'SALIDA';
        ELSE
            SET @tipo_movimiento = 'AJUSTE';

        -- Actualizar stock del producto
        UPDATE producto 
        SET stock_actual = @nuevo_stock, 
            updated_at = GETDATE()
        WHERE id = @producto_id;

        -- Registrar movimiento de inventario
        INSERT INTO movimiento_inventario (
            producto_id, tipo_movimiento, cantidad, 
            stock_anterior, stock_nuevo, motivo, referencia, usuario
        ) VALUES (
            @producto_id, @tipo_movimiento, ABS(@diferencia),
            @stock_anterior, @nuevo_stock, @motivo, @referencia, @usuario
        );

        COMMIT TRANSACTION;
        SELECT 1 as resultado, 'Stock actualizado correctamente' as mensaje;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT 0 as resultado, ERROR_MESSAGE() as mensaje;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarInventarioPorTexto]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarInventarioPorTexto]
    @textoBuscar NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id,
        p.codigo,
        p.nombre,
        p.descripcion,
        c.nombre as categoria,
        p.precio,
        p.stock_actual,
        p.stock_minimo,
        CASE 
            WHEN p.stock_actual <= p.stock_minimo THEN 'CRITICO'
            WHEN p.stock_actual <= (p.stock_minimo * 1.5) THEN 'BAJO'
            ELSE 'NORMAL'
        END as estado_stock,
        p.requiere_receta,
        p.activo,
        (p.stock_actual * p.precio) as valor_stock
    FROM producto p
    INNER JOIN categoria c ON p.categoria_id = c.id
    WHERE p.activo = 1
    AND (
        p.nombre LIKE '%' + @textoBuscar + '%' OR
        p.codigo LIKE '%' + @textoBuscar + '%' OR
        p.descripcion LIKE '%' + @textoBuscar + '%' OR
        c.nombre LIKE '%' + @textoBuscar + '%'
    )
    ORDER BY p.nombre;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarPersonalPorTexto]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarPersonalPorTexto]
    @textoBuscar NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id,
        p.nombre,
        p.apellido,
        p.email,
        p.usuario,
        p.telefono,
        p.direccion,
        p.fecha_contratacion,
        p.salario,
        p.rol,
        p.activo,
        p.fecha_ultimo_acceso,
        p.created_at,
        p.updated_at,
        -- Campos de veterinario
        pv.num_licencia,
        pv.especialidad,
        pv.universidad,
        pv.anios_experiencia,
        -- Campos de auxiliar
        pa.area,
        pa.turno,
        pa.nivel,
        -- Tipo determinado dinámicamente
        CASE 
            WHEN pv.id IS NOT NULL THEN 'Veterinario'
            WHEN pa.id IS NOT NULL THEN 'Auxiliar'
            ELSE 'General'
        END AS tipo_personal
    FROM personal p
    LEFT JOIN personal_veterinario pv ON p.id = pv.id
    LEFT JOIN personal_auxiliar pa ON p.id = pa.id
    WHERE p.activo = 1
    AND (
        p.nombre LIKE '%' + @textoBuscar + '%' OR
        p.apellido LIKE '%' + @textoBuscar + '%' OR
        p.email LIKE '%' + @textoBuscar + '%' OR
        p.usuario LIKE '%' + @textoBuscar + '%' OR
        p.telefono LIKE '%' + @textoBuscar + '%' OR
        pv.num_licencia LIKE '%' + @textoBuscar + '%' OR
        pv.especialidad LIKE '%' + @textoBuscar + '%' OR
        pa.area LIKE '%' + @textoBuscar + '%'
    )
    ORDER BY p.apellido, p.nombre;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarPersonalPorTipo]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarPersonalPorTipo]
    @tipoPersonal VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id,
        p.nombre,
        p.apellido,
        p.email,
        p.usuario,
        p.telefono,
        p.direccion,
        p.fecha_contratacion,
        p.salario,
        p.rol,
        p.activo,
        p.fecha_ultimo_acceso,
        p.created_at,
        p.updated_at,
        -- Campos de veterinario
        pv.num_licencia,
        pv.especialidad,
        pv.universidad,
        pv.anios_experiencia,
        -- Campos de auxiliar
        pa.area,
        pa.turno,
        pa.nivel,
        -- Tipo determinado dinámicamente
        CASE 
            WHEN pv.id IS NOT NULL THEN 'Veterinario'
            WHEN pa.id IS NOT NULL THEN 'Auxiliar'
            ELSE 'General'
        END AS tipo_personal
    FROM personal p
    LEFT JOIN personal_veterinario pv ON p.id = pv.id
    LEFT JOIN personal_auxiliar pa ON p.id = pa.id
    WHERE p.activo = 1
    AND (
        (@tipoPersonal = 'Veterinario' AND pv.id IS NOT NULL) OR
        (@tipoPersonal = 'Auxiliar' AND pa.id IS NOT NULL)
    )
    ORDER BY p.apellido, p.nombre;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarPersonaPorTexto]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarPersonaPorTexto]
    @textoBuscar VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        p.id, p.tipo, p.email, p.direccion, p.telefono, p.activo,
        pf.ci, pf.nombre, pf.apellido, pf.fecha_nacimiento, pf.genero,
        pj.razon_social, pj.nit, pj.encargado_nombre, pj.encargado_cargo,
        p.created_at, p.updated_at
    FROM persona p
    LEFT JOIN persona_fisica pf ON p.id = pf.id
    LEFT JOIN persona_juridica pj ON p.id = pj.id
    WHERE p.activo = 1 
    AND (
        pf.nombre LIKE '%' + @textoBuscar + '%' OR 
        pf.apellido LIKE '%' + @textoBuscar + '%' OR 
        pf.ci LIKE '%' + @textoBuscar + '%' OR
        pj.razon_social LIKE '%' + @textoBuscar + '%' OR 
        pj.nit LIKE '%' + @textoBuscar + '%' OR
        p.email LIKE '%' + @textoBuscar + '%' OR
        p.telefono LIKE '%' + @textoBuscar + '%'
    )
    ORDER BY 
        CASE WHEN p.tipo = 'Física' THEN CONCAT(pf.nombre, ' ', pf.apellido)
             ELSE pj.razon_social END;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarPersonaPorTipo]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarPersonaPorTipo]
    @tipoPersona VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        p.id, p.tipo, p.email, p.direccion, p.telefono, p.activo,
        pf.ci, pf.nombre, pf.apellido, pf.fecha_nacimiento, pf.genero,
        pj.razon_social, pj.nit, pj.encargado_nombre, pj.encargado_cargo,
        p.created_at, p.updated_at
    FROM persona p
    LEFT JOIN persona_fisica pf ON p.id = pf.id
    LEFT JOIN persona_juridica pj ON p.id = pj.id
    WHERE p.activo = 1 
    AND p.tipo = @tipoPersona
    ORDER BY 
        CASE WHEN p.tipo = 'Física' THEN CONCAT(pf.nombre, ' ', pf.apellido)
             ELSE pj.razon_social END;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_CalcularValorInventarioTotal]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_CalcularValorInventarioTotal]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT ISNULL(SUM(stock_actual * precio), 0) as valor_inventario_total
    FROM producto 
    WHERE activo = 1;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ContarMascotasActivas]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_ContarMascotasActivas]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT COUNT(*) as total_mascotas
    FROM animal 
    WHERE activo = 1;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ContarProductosActivos]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_ContarProductosActivos]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT COUNT(*) as total_productos
    FROM producto 
    WHERE activo = 1;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ContarProductosBajoStock]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_ContarProductosBajoStock]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT COUNT(*) as productos_bajo_stock
    FROM producto 
    WHERE activo = 1 AND stock_actual <= stock_minimo;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_EditarPersonalAuxiliar]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EditarPersonalAuxiliar]
    @id INT,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @email VARCHAR(100),
    @usuario VARCHAR(50),
    @telefono VARCHAR(20) = NULL,
    @direccion VARCHAR(255) = NULL,
    @salario DECIMAL(10,2) = NULL,
    @rol VARCHAR(20) = 'Usuario',
    @area VARCHAR(100) = NULL,
    @turno VARCHAR(10) = 'Mañana',
    @nivel VARCHAR(20) = 'Básico'
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Validar que el personal existe
        IF NOT EXISTS(SELECT 1 FROM personal WHERE id = @id)
        BEGIN
            SELECT 'El personal no existe' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Validar unicidad de usuario
        IF EXISTS(SELECT 1 FROM personal WHERE usuario = @usuario AND id != @id)
        BEGIN
            SELECT 'Ya existe un usuario con este nombre de usuario' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Validar unicidad de email
        IF EXISTS(SELECT 1 FROM personal WHERE email = @email AND id != @id)
        BEGIN
            SELECT 'Ya existe una persona con este email' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Actualizar tabla personal
        UPDATE personal SET
            nombre = @nombre,
            apellido = @apellido,
            email = @email,
            usuario = @usuario,
            telefono = @telefono,
            direccion = @direccion,
            salario = @salario,
            rol = @rol,
            modificado_por = 'Sistema',
            fecha_modificacion = GETDATE(),
            updated_at = GETDATE()
        WHERE id = @id;

        -- Actualizar tabla personal_auxiliar (o crear si no existe)
        IF EXISTS(SELECT 1 FROM personal_auxiliar WHERE id = @id)
        BEGIN
            UPDATE personal_auxiliar SET
                area = @area,
                turno = @turno,
                nivel = @nivel,
                updated_at = GETDATE()
            WHERE id = @id;
        END
        ELSE
        BEGIN
            INSERT INTO personal_auxiliar (id, area, turno, nivel, created_at, updated_at)
            VALUES (@id, @area, @turno, @nivel, GETDATE(), GETDATE());
        END

        COMMIT TRANSACTION;
        SELECT 'Personal auxiliar actualizado correctamente' AS mensaje;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT ERROR_MESSAGE() AS mensaje;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EditarPersonalVeterinario]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EditarPersonalVeterinario]
    @id INT,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @email VARCHAR(100),
    @usuario VARCHAR(50),
    @telefono VARCHAR(20) = NULL,
    @direccion VARCHAR(255) = NULL,
    @salario DECIMAL(10,2) = NULL,
    @rol VARCHAR(20) = 'Usuario',
    @num_licencia VARCHAR(50) = NULL,
    @especialidad VARCHAR(100) = NULL,
    @universidad VARCHAR(200) = NULL,
    @anios_experiencia INT = 0
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Validar que el personal existe
        IF NOT EXISTS(SELECT 1 FROM personal WHERE id = @id)
        BEGIN
            SELECT 'El personal no existe' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Validar unicidad de usuario
        IF EXISTS(SELECT 1 FROM personal WHERE usuario = @usuario AND id != @id)
        BEGIN
            SELECT 'Ya existe un usuario con este nombre de usuario' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Validar unicidad de email
        IF EXISTS(SELECT 1 FROM personal WHERE email = @email AND id != @id)
        BEGIN
            SELECT 'Ya existe una persona con este email' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Validar unicidad de licencia
        IF @num_licencia IS NOT NULL AND EXISTS(SELECT 1 FROM personal_veterinario WHERE num_licencia = @num_licencia AND id != @id)
        BEGIN
            SELECT 'Ya existe un veterinario con este número de licencia' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Actualizar tabla personal
        UPDATE personal SET
            nombre = @nombre,
            apellido = @apellido,
            email = @email,
            usuario = @usuario,
            telefono = @telefono,
            direccion = @direccion,
            salario = @salario,
            rol = @rol,
            modificado_por = 'Sistema',
            fecha_modificacion = GETDATE(),
            updated_at = GETDATE()
        WHERE id = @id;

        -- Actualizar tabla personal_veterinario (o crear si no existe)
        IF EXISTS(SELECT 1 FROM personal_veterinario WHERE id = @id)
        BEGIN
            UPDATE personal_veterinario SET
                num_licencia = @num_licencia,
                especialidad = @especialidad,
                universidad = @universidad,
                anios_experiencia = @anios_experiencia,
                updated_at = GETDATE()
            WHERE id = @id;
        END
        ELSE
        BEGIN
            INSERT INTO personal_veterinario (id, num_licencia, especialidad, universidad, anios_experiencia, created_at, updated_at)
            VALUES (@id, @num_licencia, @especialidad, @universidad, @anios_experiencia, GETDATE(), GETDATE());
        END

        COMMIT TRANSACTION;
        SELECT 'Personal veterinario actualizado correctamente' AS mensaje;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT ERROR_MESSAGE() AS mensaje;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarPersona]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarPersona]
    @id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM persona WHERE id = @id)
        BEGIN
            UPDATE persona 
            SET activo = 0 
            WHERE id = @id;
            
            SELECT 1 as resultado, 'Persona eliminada correctamente' as mensaje;
        END
        ELSE
        BEGIN
            SELECT 0 as resultado, 'No existe persona con el ID especificado' as mensaje;
        END
    END TRY
    BEGIN CATCH
        SELECT 0 as resultado, ERROR_MESSAGE() as mensaje;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarPersonal]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarPersonal]
    @id INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Validar que el personal existe
        IF NOT EXISTS(SELECT 1 FROM personal WHERE id = @id)
        BEGIN
            SELECT 0 AS resultado, 'El personal no existe' AS mensaje;
            RETURN;
        END

        -- Marcar como inactivo en lugar de eliminar
        UPDATE personal 
        SET activo = 0, 
            modificado_por = 'Sistema',
            fecha_modificacion = GETDATE(),
            updated_at = GETDATE()
        WHERE id = @id;

        SELECT 1 AS resultado, 'Personal eliminado correctamente' AS mensaje;
    END TRY
    BEGIN CATCH
        SELECT 0 AS resultado, ERROR_MESSAGE() AS mensaje;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EstadisticasMascotasPorEspecie]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_EstadisticasMascotasPorEspecie]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        especie,
        COUNT(*) as cantidad,
        ROUND(COUNT(*) * 100.0 / (SELECT COUNT(*) FROM animal WHERE activo = 1), 2) as porcentaje
    FROM animal 
    WHERE activo = 1
    GROUP BY especie
    ORDER BY cantidad DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_EstadisticasProductosPorCategoria]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_EstadisticasProductosPorCategoria]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        c.nombre as categoria,
        COUNT(p.id) as cantidad_productos,
        SUM(p.stock_actual) as stock_total,
        SUM(p.stock_actual * p.precio) as valor_inventario,
        SUM(CASE WHEN p.stock_actual <= p.stock_minimo THEN 1 ELSE 0 END) as productos_bajo_stock
    FROM categoria c
    LEFT JOIN producto p ON c.id = p.categoria_id AND p.activo = 1
    WHERE c.activo = 1
    GROUP BY c.id, c.nombre
    ORDER BY valor_inventario DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarPersonalAuxiliar]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertarPersonalAuxiliar]
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @email VARCHAR(100),
    @usuario VARCHAR(50),
    @contrasena VARCHAR(255),
    @telefono VARCHAR(20) = NULL,
    @direccion VARCHAR(255) = NULL,
    @fecha_contratacion DATE,
    @salario DECIMAL(10,2) = NULL,
    @rol VARCHAR(20) = 'Usuario',
    @area VARCHAR(100) = NULL,
    @turno VARCHAR(10) = 'Mañana',
    @nivel VARCHAR(20) = 'Básico'
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @personal_id INT;
    DECLARE @mensaje NVARCHAR(MAX) = '';

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Validar unicidad de usuario
        IF EXISTS(SELECT 1 FROM personal WHERE usuario = @usuario)
        BEGIN
            SELECT 0 AS id, 'Ya existe un usuario con este nombre de usuario' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Validar unicidad de email
        IF EXISTS(SELECT 1 FROM personal WHERE email = @email)
        BEGIN
            SELECT 0 AS id, 'Ya existe una persona con este email' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Insertar en tabla personal
        INSERT INTO personal (
            nombre, apellido, email, usuario, contrasena, telefono, direccion,
            fecha_contratacion, salario, rol, activo, created_at, updated_at
        ) VALUES (
            @nombre, @apellido, @email, @usuario, @contrasena, @telefono, @direccion,
            @fecha_contratacion, @salario, @rol, 1, GETDATE(), GETDATE()
        );

        SET @personal_id = SCOPE_IDENTITY();

        -- Insertar en tabla personal_auxiliar
        INSERT INTO personal_auxiliar (
            id, area, turno, nivel, created_at, updated_at
        ) VALUES (
            @personal_id, @area, @turno, @nivel, GETDATE(), GETDATE()
        );

        COMMIT TRANSACTION;
        SELECT @personal_id AS id, 'Personal auxiliar registrado correctamente' AS mensaje;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT 0 AS id, ERROR_MESSAGE() AS mensaje;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarPersonalVeterinario]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertarPersonalVeterinario]
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @email VARCHAR(100),
    @usuario VARCHAR(50),
    @contrasena VARCHAR(255),
    @telefono VARCHAR(20) = NULL,
    @direccion VARCHAR(255) = NULL,
    @fecha_contratacion DATE,
    @salario DECIMAL(10,2) = NULL,
    @rol VARCHAR(20) = 'Usuario',
    @num_licencia VARCHAR(50) = NULL,
    @especialidad VARCHAR(100) = NULL,
    @universidad VARCHAR(200) = NULL,
    @anios_experiencia INT = 0
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @personal_id INT;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Validar unicidad de usuario
        IF EXISTS(SELECT 1 FROM personal WHERE usuario = @usuario)
        BEGIN
            SELECT 0 AS id, 'Ya existe un usuario con este nombre de usuario' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Validar unicidad de email
        IF EXISTS(SELECT 1 FROM personal WHERE email = @email)
        BEGIN
            SELECT 0 AS id, 'Ya existe una persona con este email' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Validar unicidad de licencia
        IF @num_licencia IS NOT NULL AND EXISTS(SELECT 1 FROM personal_veterinario WHERE num_licencia = @num_licencia)
        BEGIN
            SELECT 0 AS id, 'Ya existe un veterinario con este número de licencia' AS mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Insertar en tabla personal
        INSERT INTO personal (
            nombre, apellido, email, usuario, contrasena, telefono, direccion,
            fecha_contratacion, salario, rol, activo, created_at, updated_at
        ) VALUES (
            @nombre, @apellido, @email, @usuario, @contrasena, @telefono, @direccion,
            @fecha_contratacion, @salario, @rol, 1, GETDATE(), GETDATE()
        );

        SET @personal_id = SCOPE_IDENTITY();

        -- Insertar en tabla personal_veterinario
        INSERT INTO personal_veterinario (
            id, num_licencia, especialidad, universidad, anios_experiencia, created_at, updated_at
        ) VALUES (
            @personal_id, @num_licencia, @especialidad, @universidad, @anios_experiencia, GETDATE(), GETDATE()
        );

        COMMIT TRANSACTION;
        SELECT @personal_id AS id, 'Personal veterinario registrado correctamente' AS mensaje;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT 0 AS id, ERROR_MESSAGE() AS mensaje;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MostrarInventario]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MostrarInventario]
    @soloStockBajo BIT = 0
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id,
        p.codigo,
        p.nombre,
        p.descripcion,
        c.nombre as categoria,
        p.precio,
        p.stock_actual,
        p.stock_minimo,
        CASE 
            WHEN p.stock_actual <= p.stock_minimo THEN 'CRITICO'
            WHEN p.stock_actual <= (p.stock_minimo * 1.5) THEN 'BAJO'
            ELSE 'NORMAL'
        END as estado_stock,
        p.requiere_receta,
        p.activo,
        p.created_at,
        p.updated_at,
        -- Calcular valor total del stock
        (p.stock_actual * p.precio) as valor_stock
    FROM producto p
    INNER JOIN categoria c ON p.categoria_id = c.id
    WHERE p.activo = 1
    AND (@soloStockBajo = 0 OR p.stock_actual <= p.stock_minimo)
    ORDER BY 
        CASE 
            WHEN p.stock_actual <= p.stock_minimo THEN 1
            WHEN p.stock_actual <= (p.stock_minimo * 1.5) THEN 2
            ELSE 3
        END,
        p.nombre;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MostrarPersonal]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MostrarPersonal]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id,
        p.nombre,
        p.apellido,
        p.email,
        p.usuario,
        p.telefono,
        p.direccion,
        p.fecha_contratacion,
        p.salario,
        p.rol,
        p.activo,
        p.fecha_ultimo_acceso,
        p.created_at,
        p.updated_at,
        -- Campos de veterinario
        pv.num_licencia,
        pv.especialidad,
        pv.universidad,
        pv.anios_experiencia,
        -- Campos de auxiliar
        pa.area,
        pa.turno,
        pa.nivel,
        -- Tipo determinado dinámicamente
        CASE 
            WHEN pv.id IS NOT NULL THEN 'Veterinario'
            WHEN pa.id IS NOT NULL THEN 'Auxiliar'
            ELSE 'General'
        END AS tipo_personal
    FROM personal p
    LEFT JOIN personal_veterinario pv ON p.id = pv.id
    LEFT JOIN personal_auxiliar pa ON p.id = pa.id
    WHERE p.activo = 1
    ORDER BY p.apellido, p.nombre;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MostrarPersonas]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MostrarPersonas]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        p.id, p.tipo, p.email, p.direccion, p.telefono, p.activo,
        pf.ci, pf.nombre, pf.apellido, pf.fecha_nacimiento, pf.genero,
        pj.razon_social, pj.nit, pj.encargado_nombre, pj.encargado_cargo,
        p.created_at, p.updated_at
    FROM persona p
    LEFT JOIN persona_fisica pf ON p.id = pf.id
    LEFT JOIN persona_juridica pj ON p.id = pj.id
    WHERE p.activo = 1
    ORDER BY 
        CASE WHEN p.tipo = 'Física' THEN CONCAT(pf.nombre, ' ', pf.apellido)
             ELSE pj.razon_social END;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerAlertasStock]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerAlertasStock]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id,
        p.codigo,
        p.nombre,
        c.nombre as categoria,
        p.stock_actual,
        p.stock_minimo,
        CASE 
            WHEN p.stock_actual = 0 THEN 'SIN_STOCK'
            WHEN p.stock_actual <= p.stock_minimo THEN 'CRITICO'
            WHEN p.stock_actual <= (p.stock_minimo * 1.5) THEN 'BAJO'
        END as nivel_alerta,
        (p.stock_minimo - p.stock_actual + 10) as cantidad_sugerida_compra
    FROM producto p
    INNER JOIN categoria c ON p.categoria_id = c.id
    WHERE p.activo = 1
    AND p.stock_actual <= (p.stock_minimo * 1.5)
    ORDER BY 
        CASE 
            WHEN p.stock_actual = 0 THEN 1
            WHEN p.stock_actual <= p.stock_minimo THEN 2
            ELSE 3
        END,
        p.stock_actual ASC;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerInventarioPorId]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerInventarioPorId]
    @id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id,
        p.codigo,
        p.nombre,
        p.descripcion,
        p.categoria_id,
        c.nombre as categoria,
        p.precio,
        p.stock_actual,
        p.stock_minimo,
        p.requiere_receta,
        p.activo,
        CASE 
            WHEN p.stock_actual <= p.stock_minimo THEN 'CRITICO'
            WHEN p.stock_actual <= (p.stock_minimo * 1.5) THEN 'BAJO'
            ELSE 'NORMAL'
        END as estado_stock,
        (p.stock_actual * p.precio) as valor_stock
    FROM producto p
    INNER JOIN categoria c ON p.categoria_id = c.id
    WHERE p.id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerMovimientosInventario]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerMovimientosInventario]
    @producto_id INT = NULL,
    @dias INT = 30
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        m.id,
        m.producto_id,
        p.codigo as codigo_producto,
        p.nombre as nombre_producto,
        m.tipo_movimiento,
        m.cantidad,
        m.stock_anterior,
        m.stock_nuevo,
        m.motivo,
        m.referencia,
        uo.nombre as ubicacion_origen,
        ud.nombre as ubicacion_destino,
        m.usuario,
        m.fecha_movimiento,
        m.created_at
    FROM movimiento_inventario m
    INNER JOIN producto p ON m.producto_id = p.id
    LEFT JOIN ubicacion_almacen uo ON m.ubicacion_origen_id = uo.id
    LEFT JOIN ubicacion_almacen ud ON m.ubicacion_destino_id = ud.id
    WHERE (@producto_id IS NULL OR m.producto_id = @producto_id)
    AND m.fecha_movimiento >= DATEADD(DAY, -@dias, GETDATE())
    ORDER BY m.fecha_movimiento DESC, m.id DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerPersonalPorId]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerPersonalPorId]
    @id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id,
        p.nombre,
        p.apellido,
        p.email,
        p.usuario,
        p.telefono,
        p.direccion,
        p.fecha_contratacion,
        p.salario,
        p.rol,
        p.activo,
        p.fecha_ultimo_acceso,
        p.created_at,
        p.updated_at,
        -- Campos de veterinario
        pv.num_licencia,
        pv.especialidad,
        pv.universidad,
        pv.anios_experiencia,
        -- Campos de auxiliar
        pa.area,
        pa.turno,
        pa.nivel,
        -- Tipo determinado dinámicamente
        CASE 
            WHEN pv.id IS NOT NULL THEN 'Veterinario'
            WHEN pa.id IS NOT NULL THEN 'Auxiliar'
            ELSE 'General'
        END AS tipo_personal
    FROM personal p
    LEFT JOIN personal_veterinario pv ON p.id = pv.id
    LEFT JOIN personal_auxiliar pa ON p.id = pa.id
    WHERE p.id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerPersonaPorId]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerPersonaPorId]
    @id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        p.id, p.tipo, p.email, p.direccion, p.telefono, p.activo,
        pf.ci, pf.nombre, pf.apellido, pf.fecha_nacimiento, pf.genero,
        pj.razon_social, pj.nit, pj.encargado_nombre, pj.encargado_cargo,
        p.created_at, p.updated_at
    FROM persona p
    LEFT JOIN persona_fisica pf ON p.id = pf.id
    LEFT JOIN persona_juridica pj ON p.id = pj.id
    WHERE p.id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerStockPorUbicacion]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerStockPorUbicacion]
    @ubicacion_id INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        su.id,
        p.codigo,
        p.nombre as producto,
        u.nombre as ubicacion,
        su.stock_actual,
        su.stock_reservado,
        (su.stock_actual - su.stock_reservado) as stock_disponible,
        su.fecha_ultimo_movimiento
    FROM stock_ubicacion su
    INNER JOIN producto p ON su.producto_id = p.id
    INNER JOIN ubicacion_almacen u ON su.ubicacion_id = u.id
    WHERE (@ubicacion_id IS NULL OR su.ubicacion_id = @ubicacion_id)
    AND p.activo = 1
    ORDER BY u.nombre, p.nombre;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerUbicaciones]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerUbicaciones]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        id,
        codigo,
        nombre,
        descripcion,
        activo
    FROM ubicacion_almacen
    WHERE activo = 1
    ORDER BY nombre;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarMovimientoInventario]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistrarMovimientoInventario]
    @producto_id INT,
    @tipo_movimiento VARCHAR(20),
    @cantidad INT,
    @motivo VARCHAR(255) = NULL,
    @referencia VARCHAR(100) = NULL,
    @ubicacion_origen_id INT = NULL,
    @ubicacion_destino_id INT = NULL,
    @usuario VARCHAR(50) = 'Sistema'
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @stock_anterior INT;
    DECLARE @stock_nuevo INT;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Obtener stock actual
        SELECT @stock_anterior = stock_actual 
        FROM producto 
        WHERE id = @producto_id;

        IF @stock_anterior IS NULL
        BEGIN
            SELECT 0 as resultado, 'Producto no encontrado' as mensaje;
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Calcular nuevo stock según tipo de movimiento
        IF @tipo_movimiento = 'ENTRADA'
            SET @stock_nuevo = @stock_anterior + @cantidad;
        ELSE IF @tipo_movimiento = 'SALIDA'
        BEGIN
            SET @stock_nuevo = @stock_anterior - @cantidad;
            IF @stock_nuevo < 0
            BEGIN
                SELECT 0 as resultado, 'Stock insuficiente para realizar la salida' as mensaje;
                ROLLBACK TRANSACTION;
                RETURN;
            END
        END
        ELSE IF @tipo_movimiento = 'AJUSTE'
            SET @stock_nuevo = @cantidad; -- La cantidad es el nuevo stock total
        ELSE
            SET @stock_nuevo = @stock_anterior; -- Para transferencias no cambia el stock total

        -- Actualizar stock del producto
        IF @tipo_movimiento != 'TRANSFERENCIA'
        BEGIN
            UPDATE producto 
            SET stock_actual = @stock_nuevo, 
                updated_at = GETDATE()
            WHERE id = @producto_id;
        END

        -- Registrar movimiento
        INSERT INTO movimiento_inventario (
            producto_id, tipo_movimiento, cantidad, 
            stock_anterior, stock_nuevo, motivo, referencia, 
            ubicacion_origen_id, ubicacion_destino_id, usuario
        ) VALUES (
            @producto_id, @tipo_movimiento, @cantidad,
            @stock_anterior, @stock_nuevo, @motivo, @referencia,
            @ubicacion_origen_id, @ubicacion_destino_id, @usuario
        );

        COMMIT TRANSACTION;
        SELECT 1 as resultado, 'Movimiento registrado correctamente' as mensaje;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT 0 as resultado, ERROR_MESSAGE() as mensaje;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteValorInventario]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ReporteValorInventario]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        c.nombre as categoria,
        COUNT(p.id) as total_productos,
        SUM(p.stock_actual) as total_unidades,
        SUM(p.stock_actual * p.precio) as valor_total,
        AVG(p.precio) as precio_promedio,
        SUM(CASE WHEN p.stock_actual <= p.stock_minimo THEN 1 ELSE 0 END) as productos_stock_bajo
    FROM producto p
    INNER JOIN categoria c ON p.categoria_id = c.id
    WHERE p.activo = 1
    GROUP BY c.id, c.nombre
    ORDER BY valor_total DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ReporteVentasAgrupadas]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReporteVentasAgrupadas]
    @FechaInicio DATE,
    @FechaFin DATE,
    @Agrupamiento VARCHAR(10) -- 'dia', 'semana', 'mes', 'año'
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @agg VARCHAR(10) = LOWER(LTRIM(RTRIM(@Agrupamiento)));

    IF @agg = 'dia'
    BEGIN
        SELECT 
            CONVERT(DATE, f.fecha_emision) AS periodo,
            CONVERT(DATE, f.fecha_emision) AS fecha_inicio,
            CONVERT(DATE, f.fecha_emision) AS fecha_fin,
            COUNT(*) AS cantidad_facturas,
            SUM(f.total) AS total_ventas,
            AVG(f.total) AS promedio_ventas
        FROM factura f
        WHERE f.fecha_emision BETWEEN @FechaInicio AND @FechaFin
        GROUP BY CONVERT(DATE, f.fecha_emision)
        ORDER BY MIN(CONVERT(DATE, f.fecha_emision));
    END
    ELSE IF @agg = 'semana'
    BEGIN
        SELECT 
            CONCAT('Sem ', DATEPART(WEEK, f.fecha_emision), ' - ', DATEPART(YEAR, f.fecha_emision)) AS periodo,
            MIN(CONVERT(DATE, f.fecha_emision)) AS fecha_inicio,
            MAX(CONVERT(DATE, f.fecha_emision)) AS fecha_fin,
            COUNT(*) AS cantidad_facturas,
            SUM(f.total) AS total_ventas,
            AVG(f.total) AS promedio_ventas
        FROM factura f
        WHERE f.fecha_emision BETWEEN @FechaInicio AND @FechaFin
        GROUP BY DATEPART(YEAR, f.fecha_emision), DATEPART(WEEK, f.fecha_emision)
        ORDER BY MIN(CONVERT(DATE, f.fecha_emision));
    END
    ELSE IF @agg = 'mes'
    BEGIN
        SELECT 
            FORMAT(f.fecha_emision, 'MMMM yyyy') AS periodo,
            MIN(CONVERT(DATE, f.fecha_emision)) AS fecha_inicio,
            MAX(CONVERT(DATE, f.fecha_emision)) AS fecha_fin,
            COUNT(*) AS cantidad_facturas,
            SUM(f.total) AS total_ventas,
            AVG(f.total) AS promedio_ventas
        FROM factura f
        WHERE f.fecha_emision BETWEEN @FechaInicio AND @FechaFin
        GROUP BY YEAR(f.fecha_emision), MONTH(f.fecha_emision), FORMAT(f.fecha_emision, 'MMMM yyyy')
        ORDER BY MIN(CONVERT(DATE, f.fecha_emision));
    END
    ELSE IF @agg = 'año' OR @agg = 'ano'
    BEGIN
        SELECT 
            CAST(YEAR(f.fecha_emision) AS VARCHAR(4)) AS periodo,
            MIN(CONVERT(DATE, f.fecha_emision)) AS fecha_inicio,
            MAX(CONVERT(DATE, f.fecha_emision)) AS fecha_fin,
            COUNT(*) AS cantidad_facturas,
            SUM(f.total) AS total_ventas,
            AVG(f.total) AS promedio_ventas
        FROM factura f
        WHERE f.fecha_emision BETWEEN @FechaInicio AND @FechaFin
        GROUP BY YEAR(f.fecha_emision)
        ORDER BY MIN(CONVERT(DATE, f.fecha_emision));
    END
    ELSE
    BEGIN
        RAISERROR('Valor de agrupamiento no válido. Use: dia, semana, mes o año.', 16, 1);
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVentasDetalle]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_ReporteVentasDetalle]
    @fecha_inicio DATE,
    @fecha_fin DATE,
    @factura_id INT = NULL /* NULL = todas las facturas del rango */
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        'PRODUCTO' AS tipo_item,
        f.id AS factura_id,
        f.numero_factura,
        f.fecha_emision,
        p.nombre_mostrar AS cliente,
        prod.codigo AS codigo_item,
        prod.nombre AS nombre_item,
        cat.nombre AS categoria,
        dp.cantidad,
        dp.precio_unitario,
        dp.descuento_unitario,
        dp.subtotal,
        dp.lote,
        dp.fecha_vencimiento_producto,
        f.estado AS estado_factura
    FROM factura f
    INNER JOIN VW_PersonasCompletas p ON f.persona_id = p.id
    INNER JOIN detalle_productos dp ON f.id = dp.factura_id
    INNER JOIN producto prod ON dp.producto_id = prod.id
    INNER JOIN categoria cat ON prod.categoria_id = cat.id
    WHERE f.fecha_emision BETWEEN @fecha_inicio AND @fecha_fin
        AND (@factura_id IS NULL OR f.id = @factura_id)
    
    UNION ALL
    
    SELECT 
        'SERVICIO' AS tipo_item,
        f.id AS factura_id,
        f.numero_factura,
        f.fecha_emision,
        p.nombre_mostrar AS cliente,
        diag.codigo AS codigo_item,
        diag.nombre AS nombre_item,
        diag.categoria_diagnostico AS categoria,
        ds.cantidad,
        ds.precio_unitario,
        ds.descuento_unitario,
        ds.subtotal,
        NULL AS lote,
        NULL AS fecha_vencimiento_producto,
        f.estado AS estado_factura
    FROM factura f
    INNER JOIN VW_PersonasCompletas p ON f.persona_id = p.id
    INNER JOIN detalle_servicios ds ON f.id = ds.factura_id
    INNER JOIN diagnostico diag ON ds.diagnostico_id = diag.id
    WHERE f.fecha_emision BETWEEN @fecha_inicio AND @fecha_fin
        AND (@factura_id IS NULL OR f.id = @factura_id)
    
    ORDER BY fecha_emision DESC, factura_id, tipo_item;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVentasEstadisticasGenerales]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_ReporteVentasEstadisticasGenerales]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        'ESTADISTICAS_GENERALES' AS tipo_estadistica,
        COUNT(*) AS total_facturas,
        COUNT(CASE WHEN estado = 'Pagada' THEN 1 END) AS facturas_pagadas,
        COUNT(CASE WHEN estado = 'Pendiente' THEN 1 END) AS facturas_pendientes,
        COUNT(CASE WHEN estado = 'Cancelada' THEN 1 END) AS facturas_canceladas,
        SUM(total) AS ingresos_totales,
        AVG(total) AS promedio_venta,
        MIN(fecha_emision) AS primera_venta,
        MAX(fecha_emision) AS ultima_venta
    FROM factura
    
    UNION ALL
    
    SELECT 
        'MES_ACTUAL' AS tipo_estadistica,
        COUNT(*) AS total_facturas,
        COUNT(CASE WHEN estado = 'Pagada' THEN 1 END) AS facturas_pagadas,
        COUNT(CASE WHEN estado = 'Pendiente' THEN 1 END) AS facturas_pendientes,
        COUNT(CASE WHEN estado = 'Cancelada' THEN 1 END) AS facturas_canceladas,
        SUM(total) AS ingresos_totales,
        AVG(total) AS promedio_venta,
        MIN(fecha_emision) AS primera_venta,
        MAX(fecha_emision) AS ultima_venta
    FROM factura
    WHERE YEAR(fecha_emision) = YEAR(GETDATE()) 
        AND MONTH(fecha_emision) = MONTH(GETDATE())
    
    UNION ALL
    
    SELECT 
        'AÑO_ACTUAL' AS tipo_estadistica,
        COUNT(*) AS total_facturas,
        COUNT(CASE WHEN estado = 'Pagada' THEN 1 END) AS facturas_pagadas,
        COUNT(CASE WHEN estado = 'Pendiente' THEN 1 END) AS facturas_pendientes,
        COUNT(CASE WHEN estado = 'Cancelada' THEN 1 END) AS facturas_canceladas,
        SUM(total) AS ingresos_totales,
        AVG(total) AS promedio_venta,
        MIN(fecha_emision) AS primera_venta,
        MAX(fecha_emision) AS ultima_venta
    FROM factura
    WHERE YEAR(fecha_emision) = YEAR(GETDATE());
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVentasPeriodosPredefinidos]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_ReporteVentasPeriodosPredefinidos]
    @periodo VARCHAR(20) /* 'HOY', 'AYER', 'ULTIMOS_7_DIAS', 'MES_ACTUAL', 'ULTIMOS_30_DIAS', 'AÑO_ACTUAL' */
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @fecha_inicio DATE;
    DECLARE @fecha_fin DATE;
    
    IF @periodo = 'HOY'
    BEGIN
        SET @fecha_inicio = CAST(GETDATE() AS DATE);
        SET @fecha_fin = CAST(GETDATE() AS DATE);
    END
    ELSE IF @periodo = 'AYER'
    BEGIN
        SET @fecha_inicio = CAST(DATEADD(DAY, -1, GETDATE()) AS DATE);
        SET @fecha_fin = CAST(DATEADD(DAY, -1, GETDATE()) AS DATE);
    END
    ELSE IF @periodo = 'ULTIMOS_7_DIAS'
    BEGIN
        SET @fecha_inicio = CAST(DATEADD(DAY, -6, GETDATE()) AS DATE);
        SET @fecha_fin = CAST(GETDATE() AS DATE);
    END
    ELSE IF @periodo = 'MES_ACTUAL'
    BEGIN
        SET @fecha_inicio = DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1);
        SET @fecha_fin = CAST(GETDATE() AS DATE);
    END
    ELSE IF @periodo = 'ULTIMOS_30_DIAS'
    BEGIN
        SET @fecha_inicio = CAST(DATEADD(DAY, -29, GETDATE()) AS DATE);
        SET @fecha_fin = CAST(GETDATE() AS DATE);
    END
    ELSE IF @periodo = 'AÑO_ACTUAL'
    BEGIN
        SET @fecha_inicio = DATEFROMPARTS(YEAR(GETDATE()), 1, 1);
        SET @fecha_fin = CAST(GETDATE() AS DATE);
    END
    ELSE
    BEGIN
        RAISERROR('Período no válido. Use: HOY, AYER, ULTIMOS_7_DIAS, MES_ACTUAL, ULTIMOS_30_DIAS, AÑO_ACTUAL', 16, 1);
        RETURN;
    END
    
    EXEC SP_ReporteVentasPorRango @fecha_inicio, @fecha_fin;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVentasPorRango]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_ReporteVentasPorRango]
    @fecha_inicio DATE,
    @fecha_fin DATE,
    @estado VARCHAR(20) = NULL /* NULL = todos, 'Pagada', 'Pendiente', etc. */
AS
BEGIN
    SET NOCOUNT ON;
    
    IF @fecha_inicio > @fecha_fin
    BEGIN
        RAISERROR('La fecha de inicio no puede ser mayor a la fecha fin', 16, 1);
        RETURN;
    END
    
    SELECT 
        f.id,
        f.numero_factura,
        f.fecha_emision,
        f.fecha_vencimiento,
        p.nombre_mostrar AS cliente,
        p.tipo AS tipo_cliente,
        f.subtotal,
        f.impuestos,
        f.descuentos,
        f.total,
        f.estado,
        f.notas,
        DATEDIFF(DAY, f.fecha_emision, GETDATE()) AS dias_transcurridos,
        (SELECT COUNT(*) FROM detalle_productos dp WHERE dp.factura_id = f.id) AS total_productos,
        (SELECT COUNT(*) FROM detalle_servicios ds WHERE ds.factura_id = f.id) AS total_servicios
    FROM factura f
    INNER JOIN VW_PersonasCompletas p ON f.persona_id = p.id
    WHERE f.fecha_emision BETWEEN @fecha_inicio AND @fecha_fin
        AND (@estado IS NULL OR f.estado = @estado)
    ORDER BY f.fecha_emision DESC, f.id DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVentasProductosTop]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_ReporteVentasProductosTop]
    @fecha_inicio DATE,
    @fecha_fin DATE,
    @top_count INT = 10
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT TOP (@top_count)
        prod.id AS producto_id,
        prod.codigo,
        prod.nombre AS producto,
        cat.nombre AS categoria,
        SUM(dp.cantidad) AS total_vendido,
        COUNT(DISTINCT f.id) AS facturas_involucradas,
        SUM(dp.subtotal) AS ingresos_generados,
        AVG(dp.precio_unitario) AS precio_promedio,
        prod.stock_actual,
        prod.stock_minimo,
        CASE 
            WHEN prod.stock_actual <= prod.stock_minimo THEN 'STOCK BAJO'
            WHEN prod.stock_actual <= (prod.stock_minimo * 2) THEN 'STOCK MEDIO'
            ELSE 'STOCK OK'
        END AS estado_stock
    FROM detalle_productos dp
    INNER JOIN factura f ON dp.factura_id = f.id
    INNER JOIN producto prod ON dp.producto_id = prod.id
    INNER JOIN categoria cat ON prod.categoria_id = cat.id
    WHERE f.fecha_emision BETWEEN @fecha_inicio AND @fecha_fin
        AND f.estado IN ('Pagada', 'Pendiente')
    GROUP BY prod.id, prod.codigo, prod.nombre, cat.nombre, 
             prod.stock_actual, prod.stock_minimo
    ORDER BY total_vendido DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVentasResumen]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_ReporteVentasResumen]
    @fecha_inicio DATE,
    @fecha_fin DATE,
    @agrupacion VARCHAR(10) = 'DIA' /* 'DIA', 'SEMANA', 'MES', 'AÑO' */
AS
BEGIN
    SET NOCOUNT ON;
    
    IF @fecha_inicio > @fecha_fin
    BEGIN
        RAISERROR('La fecha de inicio no puede ser mayor a la fecha fin', 16, 1);
        RETURN;
    END
    
    IF @agrupacion NOT IN ('DIA', 'SEMANA', 'MES', 'AÑO')
    BEGIN
        RAISERROR('Agrupación debe ser: DIA, SEMANA, MES o AÑO', 16, 1);
        RETURN;
    END
    
    IF @agrupacion = 'DIA'
    BEGIN
        SELECT 
            f.fecha_emision AS periodo,
            DATENAME(WEEKDAY, f.fecha_emision) AS dia_semana,
            COUNT(*) AS total_facturas,
            COUNT(CASE WHEN f.estado = 'Pagada' THEN 1 END) AS facturas_pagadas,
            COUNT(CASE WHEN f.estado = 'Pendiente' THEN 1 END) AS facturas_pendientes,
            SUM(f.subtotal) AS subtotal_total,
            SUM(f.impuestos) AS impuestos_total,
            SUM(f.descuentos) AS descuentos_total,
            SUM(f.total) AS ventas_netas,
            AVG(f.total) AS promedio_venta,
            MIN(f.total) AS venta_minima,
            MAX(f.total) AS venta_maxima
        FROM factura f
        WHERE f.fecha_emision BETWEEN @fecha_inicio AND @fecha_fin
        GROUP BY f.fecha_emision
        ORDER BY f.fecha_emision DESC;
    END
    ELSE IF @agrupacion = 'SEMANA'
    BEGIN
        SELECT 
            YEAR(f.fecha_emision) AS año,
            DATEPART(WEEK, f.fecha_emision) AS semana,
            MIN(f.fecha_emision) AS fecha_inicio_semana,
            MAX(f.fecha_emision) AS fecha_fin_semana,
            COUNT(*) AS total_facturas,
            COUNT(CASE WHEN f.estado = 'Pagada' THEN 1 END) AS facturas_pagadas,
            COUNT(CASE WHEN f.estado = 'Pendiente' THEN 1 END) AS facturas_pendientes,
            SUM(f.subtotal) AS subtotal_total,
            SUM(f.impuestos) AS impuestos_total,
            SUM(f.descuentos) AS descuentos_total,
            SUM(f.total) AS ventas_netas,
            AVG(f.total) AS promedio_venta
        FROM factura f
        WHERE f.fecha_emision BETWEEN @fecha_inicio AND @fecha_fin
        GROUP BY YEAR(f.fecha_emision), DATEPART(WEEK, f.fecha_emision)
        ORDER BY año DESC, semana DESC;
    END
    ELSE IF @agrupacion = 'MES'
    BEGIN
        SELECT 
            YEAR(f.fecha_emision) AS año,
            MONTH(f.fecha_emision) AS mes,
            DATENAME(MONTH, f.fecha_emision) AS nombre_mes,
            COUNT(*) AS total_facturas,
            COUNT(CASE WHEN f.estado = 'Pagada' THEN 1 END) AS facturas_pagadas,
            COUNT(CASE WHEN f.estado = 'Pendiente' THEN 1 END) AS facturas_pendientes,
            SUM(f.subtotal) AS subtotal_total,
            SUM(f.impuestos) AS impuestos_total,
            SUM(f.descuentos) AS descuentos_total,
            SUM(f.total) AS ventas_netas,
            AVG(f.total) AS promedio_venta
        FROM factura f
        WHERE f.fecha_emision BETWEEN @fecha_inicio AND @fecha_fin
        GROUP BY YEAR(f.fecha_emision), MONTH(f.fecha_emision), DATENAME(MONTH, f.fecha_emision)
        ORDER BY año DESC, mes DESC;
    END
    ELSE IF @agrupacion = 'AÑO'
    BEGIN
        SELECT 
            YEAR(f.fecha_emision) AS año,
            COUNT(*) AS total_facturas,
            COUNT(CASE WHEN f.estado = 'Pagada' THEN 1 END) AS facturas_pagadas,
            COUNT(CASE WHEN f.estado = 'Pendiente' THEN 1 END) AS facturas_pendientes,
            SUM(f.subtotal) AS subtotal_total,
            SUM(f.impuestos) AS impuestos_total,
            SUM(f.descuentos) AS descuentos_total,
            SUM(f.total) AS ventas_netas,
            AVG(f.total) AS promedio_venta
        FROM factura f
        WHERE f.fecha_emision BETWEEN @fecha_inicio AND @fecha_fin
        GROUP BY YEAR(f.fecha_emision)
        ORDER BY año DESC;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVentasServiciosTop]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_ReporteVentasServiciosTop]
    @fecha_inicio DATE,
    @fecha_fin DATE,
    @top_count INT = 10
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT TOP (@top_count)
        diag.id AS servicio_id,
        diag.codigo,
        diag.nombre AS servicio,
        diag.categoria_diagnostico AS categoria,
        SUM(ds.cantidad) AS total_prestado,
        COUNT(DISTINCT f.id) AS facturas_involucradas,
        SUM(ds.subtotal) AS ingresos_generados,
        AVG(ds.precio_unitario) AS precio_promedio,
        diag.precio_base,
        COUNT(DISTINCT ds.veterinario_id) AS veterinarios_involucrados
    FROM detalle_servicios ds
    INNER JOIN factura f ON ds.factura_id = f.id
    INNER JOIN diagnostico diag ON ds.diagnostico_id = diag.id
    WHERE f.fecha_emision BETWEEN @fecha_inicio AND @fecha_fin
        AND f.estado IN ('Pagada', 'Pendiente')
    GROUP BY diag.id, diag.codigo, diag.nombre, diag.categoria_diagnostico, diag.precio_base
    ORDER BY total_prestado DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVentasTopClientes]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_ReporteVentasTopClientes]
    @fecha_inicio DATE,
    @fecha_fin DATE,
    @top_count INT = 10
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT TOP (@top_count)
        p.id AS cliente_id,
        p.nombre_mostrar AS cliente,
        p.tipo AS tipo_cliente,
        p.email,
        p.telefono,
        COUNT(f.id) AS total_facturas,
        SUM(f.total) AS total_compras,
        AVG(f.total) AS promedio_compra,
        MAX(f.fecha_emision) AS ultima_compra,
        MIN(f.fecha_emision) AS primera_compra_periodo
    FROM factura f
    INNER JOIN VW_PersonasCompletas p ON f.persona_id = p.id
    WHERE f.fecha_emision BETWEEN @fecha_inicio AND @fecha_fin
        AND f.estado IN ('Pagada', 'Pendiente')
    GROUP BY p.id, p.nombre_mostrar, p.tipo, p.email, p.telefono
    ORDER BY total_compras DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_SaveFactura]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE
      PROCEDURE [dbo].[SP_SaveFactura] @factura_id INT = NULL,
    @persona_id INT = NULL,
    @numero_factura VARCHAR(50) = NULL,
    @fecha_vencimiento DATE = NULL,
    @notas NVARCHAR(MAX) = NULL,
    @productos NVARCHAR(MAX) = NULL,
    /* JSON: [{"id":1,"cantidad":2,"precio":50.00,"descuento":0,"lote":"L001","fecha_vencimiento":"2025-12-01"}] */
    @servicios NVARCHAR(MAX) = NULL,
    /* JSON: [{"id":1,"cantidad":1,"precio":100.00,"descuento":0,"veterinario_id":1,"detalle_historico_id":null}] */
    @impuestos DECIMAL(10, 2) = 0,
    @descuentos DECIMAL(10, 2) = 0,
    @estado VARCHAR(20) = 'Pendiente',
    @finalizar BIT = 0 
    AS BEGIN
SET NOCOUNT ON;
BEGIN TRANSACTION;
DECLARE @new_factura_id INT;
DECLARE @subtotal DECIMAL(18, 2) = 0;
DECLARE @total DECIMAL(18, 2) = 0;
BEGIN TRY 
IF @persona_id IS NULL
OR NOT EXISTS (
    SELECT 1
    FROM persona
    WHERE id = @persona_id
) BEGIN RAISERROR('Persona especificada no existe.', 16, 1);
ROLLBACK TRANSACTION;
RETURN;
END
IF @factura_id IS NULL
OR @factura_id = 0 BEGIN
INSERT INTO factura (
        numero_factura,
        persona_id,
        fecha_vencimiento,
        notas,
        estado
    )
VALUES (
        @numero_factura,
        @persona_id,
        @fecha_vencimiento,
        @notas,
        @estado
    );
SET @new_factura_id = SCOPE_IDENTITY();
END
ELSE BEGIN 
IF NOT EXISTS (
    SELECT 1
    FROM factura
    WHERE id = @factura_id
) BEGIN RAISERROR('Factura a actualizar no existe.', 16, 1);
ROLLBACK TRANSACTION;
RETURN;
END
UPDATE factura
SET numero_factura = ISNULL(@numero_factura, numero_factura),
    persona_id = ISNULL(@persona_id, persona_id),
    fecha_vencimiento = ISNULL(@fecha_vencimiento, fecha_vencimiento),
    notas = ISNULL(@notas, notas)
WHERE id = @factura_id;
SET @new_factura_id = @factura_id;
END

IF @productos IS NOT NULL
AND LTRIM(RTRIM(@productos)) <> '' BEGIN
IF @factura_id IS NOT NULL
AND @factura_id <> 0 BEGIN
UPDATE p
SET p.stock_actual = p.stock_actual + dp.cantidad
FROM producto p
    JOIN detalle_productos dp ON p.id = dp.producto_id
WHERE dp.factura_id = @new_factura_id;
DELETE FROM detalle_productos
WHERE factura_id = @new_factura_id;
END 
DECLARE @prod_tab TABLE (
        producto_id INT,
        cantidad INT,
        precio_unitario DECIMAL(18, 2),
        descuento_unitario DECIMAL(18, 2),
        lote VARCHAR(50),
        fecha_vencimiento_producto DATE
    );
INSERT INTO @prod_tab (
        producto_id,
        cantidad,
        precio_unitario,
        descuento_unitario,
        lote,
        fecha_vencimiento_producto
    )
SELECT p.producto_id,
    p.cantidad,
    p.precio_unitario,
    ISNULL(p.descuento_unitario, 0),
    p.lote,
    TRY_CONVERT(date, p.fecha_vencimiento_producto)
FROM OPENJSON(@productos) WITH (
        producto_id INT '$.id',
        cantidad INT '$.cantidad',
        precio_unitario DECIMAL(18, 2) '$.precio',
        descuento_unitario DECIMAL(18, 2) '$.descuento',
        lote VARCHAR(50) '$.lote',
        fecha_vencimiento_producto VARCHAR(30) '$.fecha_vencimiento'
    ) p;
;
WITH req AS (
    SELECT producto_id,
        SUM(ISNULL(cantidad, 0)) AS necesario
    FROM @prod_tab
    GROUP BY producto_id
)
SELECT 1
FROM req r
    LEFT JOIN producto p ON p.id = r.producto_id
WHERE p.id IS NULL
    OR p.stock_actual < r.necesario;
IF @@ROWCOUNT > 0 BEGIN RAISERROR(
    'Stock insuficiente para uno o varios productos o producto no existe.',
    16,
    1
);
ROLLBACK TRANSACTION;
RETURN;
END 
INSERT INTO detalle_productos (
        factura_id,
        producto_id,
        cantidad,
        precio_unitario,
        descuento_unitario,
        lote,
        fecha_vencimiento_producto
    )
SELECT @new_factura_id,
    pt.producto_id,
    pt.cantidad,
    ISNULL(pt.precio_unitario, pr.precio),
    pt.descuento_unitario,
    pt.lote,
    pt.fecha_vencimiento_producto
FROM @prod_tab pt
    LEFT JOIN producto pr ON pr.id = pt.producto_id;
UPDATE p
SET p.stock_actual = p.stock_actual - s.req
FROM producto p
    JOIN (
        SELECT producto_id,
            SUM(cantidad) AS req
        FROM @prod_tab
        GROUP BY producto_id
    ) s ON p.id = s.producto_id;
END 

IF @servicios IS NOT NULL
AND LTRIM(RTRIM(@servicios)) <> '' BEGIN 
IF @factura_id IS NOT NULL
AND @factura_id <> 0 BEGIN
DELETE FROM detalle_servicios
WHERE factura_id = @new_factura_id;
END
DECLARE @serv_tab TABLE (
        diagnostico_id INT,
        detalle_historico_id INT,
        cantidad INT,
        precio_unitario DECIMAL(18, 2),
        descuento_unitario DECIMAL(18, 2),
        veterinario_id INT
    );
INSERT INTO @serv_tab (
        diagnostico_id,
        detalle_historico_id,
        cantidad,
        precio_unitario,
        descuento_unitario,
        veterinario_id
    )
SELECT s.id,
    s.detalle_historico_id,
    ISNULL(s.cantidad, 1),
    s.precio,
    ISNULL(s.descuento, 0),
    s.veterinario_id
FROM OPENJSON(@servicios) WITH (
        id INT '$.id',
        detalle_historico_id INT '$.detalle_historico_id',
        cantidad INT '$.cantidad',
        precio DECIMAL(18, 2) '$.precio',
        descuento DECIMAL(18, 2) '$.descuento',
        veterinario_id INT '$.veterinario_id'
    ) s;
INSERT INTO detalle_servicios (
        factura_id,
        diagnostico_id,
        detalle_historico_id,
        cantidad,
        precio_unitario,
        descuento_unitario,
        veterinario_id
    )
SELECT @new_factura_id,
    st.diagnostico_id,
    st.detalle_historico_id,
    st.cantidad,
    ISNULL(st.precio_unitario, d.precio_base),
    st.descuento_unitario,
    st.veterinario_id
FROM @serv_tab st
    LEFT JOIN diagnostico d ON d.id = st.diagnostico_id;
END 

SELECT @subtotal = ISNULL(
        (
            SELECT SUM(
                    dpc.cantidad * dpc.precio_unitario - dpc.cantidad * dpc.descuento_unitario
                )
            FROM detalle_productos dpc
            WHERE dpc.factura_id = @new_factura_id
        ),
        0
    ) + ISNULL(
        (
            SELECT SUM(
                    dsc.cantidad * dsc.precio_unitario - dsc.cantidad * dsc.descuento_unitario
                )
            FROM detalle_servicios dsc
            WHERE dsc.factura_id = @new_factura_id
        ),
        0
    );
SET @total = @subtotal + ISNULL(@impuestos, 0) - ISNULL(@descuentos, 0);

IF @finalizar = 1
SET @estado = 'Pagada';
UPDATE factura
SET subtotal = @subtotal,
    impuestos = ISNULL(@impuestos, 0),
    descuentos = ISNULL(@descuentos, 0),
    total = @total,
    estado = @estado
WHERE id = @new_factura_id;
COMMIT TRANSACTION;
SELECT @new_factura_id AS factura_id,
    @subtotal AS subtotal,
    @impuestos AS impuestos,
    @descuentos AS descuentos,
    @total AS total,
    @estado AS estado,
    'OK' AS mensaje;
END TRY BEGIN CATCH
DECLARE @err_msg NVARCHAR(4000) = ERROR_MESSAGE();
ROLLBACK TRANSACTION;
RAISERROR('Error en SP_SaveFactura: %s', 16, 1, @err_msg);
RETURN;
END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ValidarCIUnico]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ValidarCIUnico]
    @ci VARCHAR(15),
    @idPersona INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @existe BIT = 0;
    
    IF EXISTS (
        SELECT 1 FROM persona_fisica pf
        INNER JOIN persona p ON pf.id = p.id
        WHERE pf.ci = @ci 
        AND p.activo = 1
        AND (@idPersona IS NULL OR pf.id != @idPersona)
    )
    BEGIN
        SET @existe = 1;
    END
    
    SELECT @existe as existe;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ValidarEmailPersonalUnico]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ValidarEmailPersonalUnico]
    @email VARCHAR(100),
    @idPersonal INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @existe BIT = 0;

    IF EXISTS(
        SELECT 1 FROM personal 
        WHERE email = @email 
        AND (@idPersonal IS NULL OR id != @idPersonal)
    )
        SET @existe = 1;

    SELECT @existe AS existe;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ValidarEmailUnico]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ValidarEmailUnico]
    @email VARCHAR(255),
    @idPersona INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @existe BIT = 0;
    
    IF EXISTS (
        SELECT 1 FROM persona 
        WHERE email = @email 
        AND activo = 1
        AND (@idPersona IS NULL OR id != @idPersona)
    )
    BEGIN
        SET @existe = 1;
    END
    
    SELECT @existe as existe;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ValidarNITUnico]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ValidarNITUnico]
    @nit VARCHAR(20),
    @idPersona INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @existe BIT = 0;
    
    IF EXISTS (
        SELECT 1 FROM persona_juridica pj
        INNER JOIN persona p ON pj.id = p.id
        WHERE pj.nit = @nit 
        AND p.activo = 1
        AND (@idPersona IS NULL OR pj.id != @idPersona)
    )
    BEGIN
        SET @existe = 1;
    END
    
    SELECT @existe as existe;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ValidarUsuarioUnico]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ValidarUsuarioUnico]
    @usuario VARCHAR(50),
    @idPersonal INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @existe BIT = 0;

    IF EXISTS(
        SELECT 1 FROM personal 
        WHERE usuario = @usuario 
        AND (@idPersonal IS NULL OR id != @idPersonal)
    )
        SET @existe = 1;

    SELECT @existe AS existe;
END
GO
/****** Object:  StoredProcedure [dbo].[SP01_CreateOrUpdatePFisica]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP01_CreateOrUpdatePFisica] @id INT = NULL,
@ci VARCHAR(15) = NULL,
@nombre VARCHAR(100),
@apellido VARCHAR(100),
@email VARCHAR(255) = NULL,
@direccion VARCHAR(255) = NULL,
@telefono VARCHAR(20) = NULL,
@fecha_nacimiento DATE = NULL,
@genero CHAR(1) = NULL AS BEGIN
SET NOCOUNT ON;
BEGIN TRANSACTION;
DECLARE @persona_id INT;
BEGIN TRY IF @id IS NULL
OR @id = 0 BEGIN
INSERT INTO persona (tipo, email, direccion, telefono)
VALUES ('Física', @email, @direccion, @telefono);
SET @persona_id = SCOPE_IDENTITY();
INSERT INTO persona_fisica (
        id,
        ci,
        nombre,
        apellido,
        fecha_nacimiento,
        genero
    )
VALUES (
        @persona_id,
        @ci,
        @nombre,
        @apellido,
        @fecha_nacimiento,
        @genero
    );
SELECT @persona_id as id,
    'Persona física creada exitosamente' as mensaje;
END
ELSE BEGIN
IF EXISTS (
    SELECT 1
    FROM persona
    WHERE id = @id
        AND tipo = 'Física'
) BEGIN
UPDATE persona
SET email = ISNULL(@email, email),
    direccion = ISNULL(@direccion, direccion),
    telefono = ISNULL(@telefono, telefono)
WHERE id = @id;
UPDATE persona_fisica
SET ci = ISNULL(@ci, ci),
    nombre = @nombre,
    apellido = @apellido,
    fecha_nacimiento = ISNULL(@fecha_nacimiento, fecha_nacimiento),
    genero = ISNULL(@genero, genero)
WHERE id = @id;
SELECT @id as id,
    'Persona física actualizada exitosamente' as mensaje;
END
ELSE BEGIN RAISERROR('No existe persona física con ID %d', 16, 1, @id);
RETURN;
END
END COMMIT TRANSACTION;
END TRY BEGIN CATCH ROLLBACK TRANSACTION;
THROW;
END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[SP02_CreateOrUpdatePJuridica]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP02_CreateOrUpdatePJuridica] @id INT = NULL,
@razon_social VARCHAR(255),
@nit VARCHAR(20) = NULL,
@encargado_nombre VARCHAR(255) = NULL,
@encargado_cargo VARCHAR(100) = NULL,
@email VARCHAR(255) = NULL,
@direccion VARCHAR(255) = NULL,
@telefono VARCHAR(20) = NULL AS BEGIN
SET NOCOUNT ON;
BEGIN TRANSACTION;
DECLARE @persona_id INT;
BEGIN TRY IF @id IS NULL
OR @id = 0 BEGIN
INSERT INTO persona (tipo, email, direccion, telefono)
VALUES ('Jurídica', @email, @direccion, @telefono);
SET @persona_id = SCOPE_IDENTITY();
INSERT INTO persona_juridica (
        id,
        razon_social,
        nit,
        encargado_nombre,
        encargado_cargo
    )
VALUES (
        @persona_id,
        @razon_social,
        @nit,
        @encargado_nombre,
        @encargado_cargo
    );
SELECT @persona_id as id,
    'Persona jurídica creada exitosamente' as mensaje;
END
ELSE BEGIN
IF EXISTS (
    SELECT 1
    FROM persona
    WHERE id = @id
        AND tipo = 'Jurídica'
) BEGIN
UPDATE persona
SET email = ISNULL(@email, email),
    direccion = ISNULL(@direccion, direccion),
    telefono = ISNULL(@telefono, telefono)
WHERE id = @id;
UPDATE persona_juridica
SET razon_social = @razon_social,
    nit = ISNULL(@nit, nit),
    encargado_nombre = ISNULL(@encargado_nombre, encargado_nombre),
    encargado_cargo = ISNULL(@encargado_cargo, encargado_cargo)
WHERE id = @id;
SELECT @id as id,
    'Persona jurídica actualizada exitosamente' as mensaje;
END
ELSE BEGIN RAISERROR(
    'No existe persona jurídica con ID %d',
    16,
    1,
    @id
);
RETURN;
END
END COMMIT TRANSACTION;
END TRY BEGIN CATCH ROLLBACK TRANSACTION;
THROW;
END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[SP03_CreateOrUpdateVeterinario]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP03_CreateOrUpdateVeterinario] @id INT = NULL,
@nombre VARCHAR(100),
@apellido VARCHAR(100),
@email VARCHAR(100),
@usuario VARCHAR(50),
@contrasena VARCHAR(255),
@telefono VARCHAR(20) = NULL,
@direccion VARCHAR(255) = NULL,
@num_licencia VARCHAR(50),
@especialidad VARCHAR(100) = NULL,
@universidad VARCHAR(200) = NULL,
@salario DECIMAL(10, 2) = NULL AS BEGIN
SET NOCOUNT ON;
BEGIN TRANSACTION;
DECLARE @personal_id INT;
BEGIN TRY IF @id IS NULL
OR @id = 0 BEGIN
INSERT INTO personal (
        nombre,
        apellido,
        email,
        usuario,
        contrasena,
        telefono,
        direccion,
        salario
    )
VALUES (
        @nombre,
        @apellido,
        @email,
        @usuario,
        @contrasena,
        @telefono,
        @direccion,
        @salario
    );
SET @personal_id = SCOPE_IDENTITY();
INSERT INTO personal_veterinario (id, num_licencia, especialidad, universidad)
VALUES (
        @personal_id,
        @num_licencia,
        @especialidad,
        @universidad
    );
SELECT @personal_id as id,
    'Veterinario creado exitosamente' as mensaje;
END
ELSE BEGIN
IF EXISTS (
    SELECT 1
    FROM personal p
        INNER JOIN personal_veterinario pv ON p.id = pv.id
    WHERE p.id = @id
) BEGIN
UPDATE personal
SET nombre = @nombre,
    apellido = @apellido,
    email = @email,
    usuario = @usuario,
    contrasena = ISNULL(@contrasena, contrasena),
    telefono = ISNULL(@telefono, telefono),
    direccion = ISNULL(@direccion, direccion),
    salario = ISNULL(@salario, salario)
WHERE id = @id;
UPDATE personal_veterinario
SET num_licencia = @num_licencia,
    especialidad = ISNULL(@especialidad, especialidad),
    universidad = ISNULL(@universidad, universidad)
WHERE id = @id;
SELECT @id as id,
    'Veterinario actualizado exitosamente' as mensaje;
END
ELSE BEGIN RAISERROR('No existe veterinario con ID %d', 16, 1, @id);
RETURN;
END
END COMMIT TRANSACTION;
END TRY BEGIN CATCH ROLLBACK TRANSACTION;
THROW;
END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[SP04_CreateOrUpdateAuxiliar]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP04_CreateOrUpdateAuxiliar] @id INT = NULL,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @email VARCHAR(100),
    @usuario VARCHAR(50),
    @contrasena VARCHAR(255),
    @telefono VARCHAR(20) = NULL,
    @direccion VARCHAR(255) = NULL,
    @area VARCHAR(100) = NULL,
    @turno VARCHAR(10),
    @nivel VARCHAR(20) = 'Básico',
    @salario DECIMAL(10, 2) = NULL AS BEGIN
SET NOCOUNT ON;
BEGIN TRANSACTION;
DECLARE @personal_id INT;
BEGIN TRY IF @id IS NULL
OR @id = 0 BEGIN 
INSERT INTO personal (
        nombre,
        apellido,
        email,
        usuario,
        contrasena,
        telefono,
        direccion,
        salario
    )
VALUES (
        @nombre,
        @apellido,
        @email,
        @usuario,
        @contrasena,
        @telefono,
        @direccion,
        @salario
    );
SET @personal_id = SCOPE_IDENTITY();
INSERT INTO personal_auxiliar (id, area, turno, nivel)
VALUES (@personal_id, @area, @turno, @nivel);
SELECT @personal_id as id,
    'Auxiliar creado exitosamente' as mensaje;
END
ELSE BEGIN 
IF EXISTS (
    SELECT 1
    FROM personal p
        INNER JOIN personal_auxiliar pa ON p.id = pa.id
    WHERE p.id = @id
) BEGIN
UPDATE personal
SET nombre = @nombre,
    apellido = @apellido,
    email = @email,
    usuario = @usuario,
    contrasena = ISNULL(@contrasena, contrasena),
    telefono = ISNULL(@telefono, telefono),
    direccion = ISNULL(@direccion, direccion),
    salario = ISNULL(@salario, salario)
WHERE id = @id;
UPDATE personal_auxiliar
SET area = ISNULL(@area, area),
    turno = @turno,
    nivel = ISNULL(@nivel, nivel)
WHERE id = @id;
SELECT @id as id,
    'Auxiliar actualizado exitosamente' as mensaje;
END
ELSE BEGIN RAISERROR('No existe auxiliar con ID %d', 16, 1, @id);
RETURN;
END
END COMMIT TRANSACTION;
END TRY BEGIN CATCH ROLLBACK TRANSACTION;
THROW;
END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[SP05_CreateOrUpdateAnimal]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP05_CreateOrUpdateAnimal] @id INT = NULL,
    @nombre VARCHAR(100),
    @especie VARCHAR(50),
    @persona_id INT,
    @raza VARCHAR(100) = NULL,
    @fecha_nacimiento DATE = NULL,
    @peso DECIMAL(5, 2) = NULL,
    @color VARCHAR(50) = NULL,
    @genero CHAR(1) = NULL,
    @esterilizado BIT = 0,
    @microchip VARCHAR(50) = NULL AS BEGIN
SET NOCOUNT ON;
BEGIN TRANSACTION;
DECLARE @animal_id INT,
    @historico_id INT;
BEGIN TRY 
IF NOT EXISTS (
    SELECT 1
    FROM persona
    WHERE id = @persona_id
) BEGIN RAISERROR('La persona especificada no existe', 16, 1);
RETURN;
END IF @id IS NULL
OR @id = 0 BEGIN 
INSERT INTO animal (
        nombre,
        especie,
        raza,
        fecha_nacimiento,
        peso,
        color,
        genero,
        esterilizado,
        microchip,
        persona_id
    )
VALUES (
        @nombre,
        @especie,
        @raza,
        @fecha_nacimiento,
        @peso,
        @color,
        @genero,
        @esterilizado,
        @microchip,
        @persona_id
    );
SET @animal_id = SCOPE_IDENTITY();
INSERT INTO historico (animal_id, notas_generales)
VALUES (
        @animal_id,
        'Historial clínico creado automáticamente'
    );
SELECT @animal_id as id,
    'Animal registrado exitosamente con historial clínico' as mensaje;
END
ELSE BEGIN 
IF EXISTS (
    SELECT 1
    FROM animal
    WHERE id = @id
) BEGIN
UPDATE animal
SET nombre = @nombre,
    especie = @especie,
    raza = ISNULL(@raza, raza),
    fecha_nacimiento = ISNULL(@fecha_nacimiento, fecha_nacimiento),
    peso = ISNULL(@peso, peso),
    color = ISNULL(@color, color),
    genero = ISNULL(@genero, genero),
    esterilizado = ISNULL(@esterilizado, esterilizado),
    microchip = ISNULL(@microchip, microchip),
    persona_id = @persona_id
WHERE id = @id;
SELECT @id as id,
    'Animal actualizado exitosamente' as mensaje;
END
ELSE BEGIN RAISERROR('No existe animal con ID %d', 16, 1, @id);
RETURN;
END
END COMMIT TRANSACTION;
END TRY BEGIN CATCH ROLLBACK TRANSACTION;
THROW;
END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[SP06_CreateOrUpdateCategoria]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP06_CreateOrUpdateCategoria] @id INT = NULL,
    @nombre VARCHAR(100),
    @descripcion VARCHAR(255) = NULL,
    @activo BIT = 1 AS BEGIN
SET NOCOUNT ON;
BEGIN TRANSACTION;
BEGIN TRY IF @id IS NULL
OR @id = 0 BEGIN 
INSERT INTO categoria (nombre, descripcion, activo)
VALUES (@nombre, @descripcion, @activo);
SELECT SCOPE_IDENTITY() as id,
    'Categoría creada exitosamente' as mensaje;
END
ELSE BEGIN 
IF EXISTS (
    SELECT 1
    FROM categoria
    WHERE id = @id
) BEGIN
UPDATE categoria
SET nombre = @nombre,
    descripcion = ISNULL(@descripcion, descripcion),
    activo = ISNULL(@activo, activo)
WHERE id = @id;
SELECT @id as id,
    'Categoría actualizada exitosamente' as mensaje;
END
ELSE BEGIN RAISERROR('No existe categoría con ID %d', 16, 1, @id);
RETURN;
END
END COMMIT TRANSACTION;
END TRY BEGIN CATCH ROLLBACK TRANSACTION;
THROW;
END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[SP07_CreateOrUpdateProducto]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP07_CreateOrUpdateProducto] @id INT = NULL,
    @codigo VARCHAR(50) = NULL,
    @nombre VARCHAR(255),
    @descripcion TEXT = NULL,
    @precio DECIMAL(10, 2),
    @stock_minimo INT = 5,
    @stock_actual INT = 0,
    @requiere_receta BIT = 1,
    @categoria_id INT,
    @activo BIT = 1 AS BEGIN
SET NOCOUNT ON;
BEGIN TRANSACTION;
BEGIN TRY 
IF NOT EXISTS (
    SELECT 1
    FROM categoria
    WHERE id = @categoria_id
) BEGIN RAISERROR('La categoría especificada no existe', 16, 1);
RETURN;
END IF @id IS NULL
OR @id = 0 BEGIN
INSERT INTO producto (
        codigo,
        nombre,
        descripcion,
        precio,
        stock_minimo,
        stock_actual,
        requiere_receta,
        categoria_id,
        activo
    )
VALUES (
        @codigo,
        @nombre,
        @descripcion,
        @precio,
        @stock_minimo,
        @stock_actual,
        @requiere_receta,
        @categoria_id,
        @activo
    );
SELECT SCOPE_IDENTITY() as id,
    'Producto creado exitosamente' as mensaje;
END
ELSE BEGIN 
IF EXISTS (
    SELECT 1
    FROM producto
    WHERE id = @id
) BEGIN
UPDATE producto
SET codigo = ISNULL(@codigo, codigo),
    nombre = @nombre,
    descripcion = ISNULL(@descripcion, descripcion),
    precio = @precio,
    stock_minimo = ISNULL(@stock_minimo, stock_minimo),
    stock_actual = ISNULL(@stock_actual, stock_actual),
    requiere_receta = ISNULL(@requiere_receta, requiere_receta),
    categoria_id = @categoria_id,
    activo = ISNULL(@activo, activo)
WHERE id = @id;
SELECT @id as id,
    'Producto actualizado exitosamente' as mensaje;
END
ELSE BEGIN RAISERROR('No existe producto con ID %d', 16, 1, @id);
RETURN;
END
END COMMIT TRANSACTION;
END TRY BEGIN CATCH ROLLBACK TRANSACTION;
THROW;
END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[SP08_CreateOrUpdateDiagnostico]    Script Date: 01/09/2025 14:32:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP08_CreateOrUpdateDiagnostico] @id INT = NULL,
    @codigo VARCHAR(20) = NULL,
    @nombre VARCHAR(200),
    @descripcion TEXT = NULL,
    @precio_base DECIMAL(10, 2) = 0,
    @categoria_diagnostico VARCHAR(100) = NULL,
    @requiere_equipamiento BIT = 0,
    @activo BIT = 1 AS BEGIN
SET NOCOUNT ON;
BEGIN TRANSACTION;
BEGIN TRY IF @id IS NULL
OR @id = 0 BEGIN 
INSERT INTO diagnostico (
        codigo,
        nombre,
        descripcion,
        precio_base,
        categoria_diagnostico,
        requiere_equipamiento,
        activo
    )
VALUES (
        @codigo,
        @nombre,
        @descripcion,
        @precio_base,
        @categoria_diagnostico,
        @requiere_equipamiento,
        @activo
    );
SELECT SCOPE_IDENTITY() as id,
    'Diagnóstico creado exitosamente' as mensaje;
END
ELSE BEGIN 
IF EXISTS (
    SELECT 1
    FROM diagnostico
    WHERE id = @id
) BEGIN
UPDATE diagnostico
SET codigo = ISNULL(@codigo, codigo),
    nombre = @nombre,
    descripcion = ISNULL(@descripcion, descripcion),
    precio_base = @precio_base,
    categoria_diagnostico = ISNULL(@categoria_diagnostico, categoria_diagnostico),
    requiere_equipamiento = ISNULL(@requiere_equipamiento, requiere_equipamiento),
    activo = ISNULL(@activo, activo)
WHERE id = @id;
SELECT @id as id,
    'Diagnóstico actualizado exitosamente' as mensaje;
END
ELSE BEGIN RAISERROR('No existe diagnóstico con ID %d', 16, 1, @id);
RETURN;
END
END COMMIT TRANSACTION;
END TRY BEGIN CATCH ROLLBACK TRANSACTION;
THROW;
END CATCH
END;
GO
USE [master]
GO
ALTER DATABASE [Sistema_Veterinario] SET  READ_WRITE 
GO
