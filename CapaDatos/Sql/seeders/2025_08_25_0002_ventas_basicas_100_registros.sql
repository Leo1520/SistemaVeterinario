-- =============================================
-- Script: 2025_08_25_0002_ventas_basicas_100_registros.sql
-- Descripción: Seeder para insertar 100 ventas básicas con productos y servicios
-- Fecha: 25 de agosto de 2025
-- Autor: Sistema Veterinario
-- Versión: 1.0
-- UUID: 0002
-- =============================================

PRINT 'Iniciando inserción de 100 ventas básicas...'
PRINT '============================================='

DECLARE @i INT = 1

WHILE @i <= 100
BEGIN
    -- Insertar factura basica
    INSERT INTO factura (
        numero_factura, 
        persona_id, 
        fecha_emision, 
        fecha_vencimiento,
        subtotal, 
        impuestos, 
        descuentos,
        total, 
        estado,
        notas,
        created_at,
        updated_at
    )
    SELECT 
        'VNT-' + RIGHT('0000' + CAST(@i AS VARCHAR), 4),
        p.id,
        DATEADD(DAY, -(@i % 365), GETDATE()),
        DATEADD(DAY, -(@i % 365) + 30, GETDATE()),
        50.0 + (@i % 150),
        (50.0 + (@i % 150)) * 0.13,
        0,
        (50.0 + (@i % 150)) * 1.13,
        CASE 
            WHEN @i % 10 = 0 THEN 'Pendiente'
            WHEN @i % 20 = 0 THEN 'Cancelada'
            ELSE 'Pagada'
        END,
        'Venta de ejemplo #' + CAST(@i AS VARCHAR),
        GETDATE(),
        GETDATE()
    FROM (
        SELECT TOP 1 id 
        FROM persona 
        WHERE activo = 1 
        ORDER BY NEWID()
    ) p
    
    IF @i % 20 = 0
        PRINT 'Insertadas ' + CAST(@i AS VARCHAR) + ' facturas...'
    
    SET @i = @i + 1
END

PRINT 'Insercion de facturas completada!'

-- Insertar detalles de productos (sin triggers complejos)
PRINT 'Insertando detalles de productos...'

INSERT INTO detalle_productos (
    factura_id, 
    producto_id, 
    cantidad, 
    precio_unitario, 
    descuento_unitario,
    subtotal,
    created_at,
    updated_at
)
SELECT 
    f.id,
    p.id,
    CASE WHEN (f.id % 3) = 0 THEN 3 ELSE 1 END,
    p.precio,
    0,
    CASE WHEN (f.id % 3) = 0 THEN 3 * p.precio ELSE p.precio END,
    GETDATE(),
    GETDATE()
FROM factura f
CROSS JOIN producto p
WHERE f.numero_factura LIKE 'VNT-%'
AND p.id <= 5  -- Solo primeros 5 productos
AND (f.id + p.id) % 7 = 0  -- Distribuir aleatoriamente

PRINT 'Detalles de productos insertados!'

-- Insertar detalles de servicios
PRINT 'Insertando detalles de servicios...'

INSERT INTO detalle_servicios (
    factura_id,
    diagnostico_id, 
    cantidad,
    precio_unitario,
    descuento_unitario,
    subtotal,
    veterinario_id,
    created_at,
    updated_at
)
SELECT 
    f.id,
    d.id,
    1,
    d.precio_base,
    0,
    d.precio_base,
    v.id,
    GETDATE(),
    GETDATE()
FROM factura f
CROSS JOIN diagnostico d
CROSS JOIN personal_veterinario v
WHERE f.numero_factura LIKE 'VNT-%'
AND d.id <= 3  -- Solo primeros 3 servicios
AND (f.id + d.id + v.id) % 11 = 0  -- Distribuir aleatoriamente

PRINT 'Detalles de servicios insertados!'

-- Mostrar resultados
SELECT 'Facturas creadas' as Tipo, COUNT(*) as Cantidad FROM factura WHERE numero_factura LIKE 'VNT-%'
UNION ALL
SELECT 'Detalles productos', COUNT(*) FROM detalle_productos dp INNER JOIN factura f ON dp.factura_id = f.id WHERE f.numero_factura LIKE 'VNT-%'
UNION ALL  
SELECT 'Detalles servicios', COUNT(*) FROM detalle_servicios ds INNER JOIN factura f ON ds.factura_id = f.id WHERE f.numero_factura LIKE 'VNT-%'

PRINT 'Proceso completado exitosamente!'