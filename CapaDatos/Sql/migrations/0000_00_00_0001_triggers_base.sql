-- Triggers de updated_at
CREATE TRIGGER TR_UpdatedAt_Persona ON persona
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE persona
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_PersonaFisica ON persona_fisica
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE persona_fisica
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_PersonaJuridica ON persona_juridica
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE persona_juridica
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_Personal ON personal
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE personal
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_PersonalVeterinario ON personal_veterinario
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE personal_veterinario
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_PersonalAuxiliar ON personal_auxiliar
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE personal_auxiliar
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_Animal ON animal
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE animal
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_Historico ON historico
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE historico
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_DetalleHistorico ON detalle_historico
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE detalle_historico
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_Categoria ON categoria
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE categoria
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_Producto ON producto
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE producto
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_Diagnostico ON diagnostico
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE diagnostico
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_Factura ON factura
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE factura
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_DetalleProductos ON detalle_productos
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE detalle_productos
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

CREATE TRIGGER TR_UpdatedAt_DetalleServicios ON detalle_servicios
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE detalle_servicios
    SET updated_at = GETDATE()
    WHERE id IN (SELECT id FROM inserted);
END;
GO

-- Triggers de cálculo de subtotales
CREATE TRIGGER TR_CalcularSubtotal_DetalleProductos ON detalle_productos
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dp
    SET subtotal = i.cantidad * i.precio_unitario - (i.cantidad * i.descuento_unitario)
    FROM detalle_productos dp
    INNER JOIN inserted i ON dp.id = i.id;
END;
GO

CREATE TRIGGER TR_CalcularSubtotal_DetalleServicios ON detalle_servicios
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE ds
    SET subtotal = i.cantidad * i.precio_unitario - (i.cantidad * i.descuento_unitario)
    FROM detalle_servicios ds
    INNER JOIN inserted i ON ds.id = i.id;
END;
GO

-- Triggers de actualización de totales en facturas
CREATE TRIGGER TR_ActualizarTotal_Factura_Productos ON detalle_productos
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @facturas_afectadas TABLE (factura_id INT);
    
    INSERT INTO @facturas_afectadas (factura_id)
    SELECT DISTINCT factura_id FROM inserted
    UNION
    SELECT DISTINCT factura_id FROM deleted;
    
    UPDATE f
    SET subtotal = ISNULL(productos.total_productos, 0) + ISNULL(servicios.total_servicios, 0),
        total = ISNULL(productos.total_productos, 0) + ISNULL(servicios.total_servicios, 0) + f.impuestos - f.descuentos
    FROM factura f
    LEFT JOIN (
        SELECT factura_id, SUM(subtotal) as total_productos
        FROM detalle_productos
        WHERE factura_id IN (SELECT factura_id FROM @facturas_afectadas)
        GROUP BY factura_id
    ) productos ON f.id = productos.factura_id
    LEFT JOIN (
        SELECT factura_id, SUM(subtotal) as total_servicios
        FROM detalle_servicios
        WHERE factura_id IN (SELECT factura_id FROM @facturas_afectadas)
        GROUP BY factura_id
    ) servicios ON f.id = servicios.factura_id
    WHERE f.id IN (SELECT factura_id FROM @facturas_afectadas);
END;
GO

CREATE TRIGGER TR_ActualizarTotal_Factura_Servicios ON detalle_servicios
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @facturas_afectadas TABLE (factura_id INT);
    
    INSERT INTO @facturas_afectadas (factura_id)
    SELECT DISTINCT factura_id FROM inserted
    UNION
    SELECT DISTINCT factura_id FROM deleted;
    
    UPDATE f
    SET subtotal = ISNULL(productos.total_productos, 0) + ISNULL(servicios.total_servicios, 0),
        total = ISNULL(productos.total_productos, 0) + ISNULL(servicios.total_servicios, 0) + f.impuestos - f.descuentos
    FROM factura f
    LEFT JOIN (
        SELECT factura_id, SUM(subtotal) as total_productos
        FROM detalle_productos
        WHERE factura_id IN (SELECT factura_id FROM @facturas_afectadas)
        GROUP BY factura_id
    ) productos ON f.id = productos.factura_id
    LEFT JOIN (
        SELECT factura_id, SUM(subtotal) as total_servicios
        FROM detalle_servicios
        WHERE factura_id IN (SELECT factura_id FROM @facturas_afectadas)
        GROUP BY factura_id
    ) servicios ON f.id = servicios.factura_id
    WHERE f.id IN (SELECT factura_id FROM @facturas_afectadas);
END;
GO

-- Vistas
CREATE VIEW VW_PersonasCompletas AS
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

CREATE VIEW VW_AnimalesConPropietario AS
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

CREATE VIEW VW_PersonalCompleto AS
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