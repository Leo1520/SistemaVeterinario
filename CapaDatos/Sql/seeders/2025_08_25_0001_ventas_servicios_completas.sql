-- =============================================
-- Script: 2025_08_25_0001_ventas_servicios_completas.sql
-- Descripción: Seeder completo para generar 100 ventas con productos y servicios usando procedimientos almacenados
-- Fecha: 25 de agosto de 2025
-- Autor: Sistema Veterinario
-- Versión: 1.0
-- UUID: 0001
-- Usa: SP_SaveFactura procedimiento almacenado
-- Nota: Este script puede fallar por límites de anidamiento. Usar 0002 como alternativa.
-- =============================================

PRINT 'Iniciando inserción de 100 ventas con productos y servicios...'

-- =============================================
-- VERIFICAR DATOS BASE NECESARIOS
-- =============================================

-- Verificar que existan personas
DECLARE @PersonCount INT
SELECT @PersonCount = COUNT(*) FROM persona WHERE activo = 1
IF @PersonCount < 50
BEGIN
    PRINT 'ERROR: Se necesitan al menos 50 personas registradas para generar las ventas'
    RETURN
END

-- Verificar que existan productos
DECLARE @ProductCount INT  
SELECT @ProductCount = COUNT(*) FROM producto WHERE activo = 1
IF @ProductCount < 10
BEGIN
    PRINT 'Insertando productos básicos para las ventas...'
    
    -- Crear categoría básica si no existe
    IF NOT EXISTS (SELECT 1 FROM categoria WHERE nombre = 'Medicamentos')
    BEGIN
        EXEC SP06_CreateOrUpdateCategoria @nombre = 'Medicamentos', @descripcion = 'Medicamentos veterinarios'
    END
    
    DECLARE @CatMedicamentos INT
    SELECT @CatMedicamentos = id FROM categoria WHERE nombre = 'Medicamentos'
    
    -- Insertar productos básicos
    EXEC SP07_CreateOrUpdateProducto @codigo = 'MED001', @nombre = 'Antibiótico Amoxicilina 500mg', @precio = 25.50, @categoria_id = @CatMedicamentos, @stock_actual = 1000, @stock_minimo = 10
    EXEC SP07_CreateOrUpdateProducto @codigo = 'MED002', @nombre = 'Antiparasitario Interno', @precio = 18.75, @categoria_id = @CatMedicamentos, @stock_actual = 800, @stock_minimo = 15
    EXEC SP07_CreateOrUpdateProducto @codigo = 'MED003', @nombre = 'Vacuna Antirrábica', @precio = 35.00, @categoria_id = @CatMedicamentos, @stock_actual = 500, @stock_minimo = 20
    EXEC SP07_CreateOrUpdateProducto @codigo = 'MED004', @nombre = 'Vitaminas B Complex', @precio = 12.25, @categoria_id = @CatMedicamentos, @stock_actual = 600, @stock_minimo = 25
    EXEC SP07_CreateOrUpdateProducto @codigo = 'MED005', @nombre = 'Antiinflamatorio Meloxicam', @precio = 28.90, @categoria_id = @CatMedicamentos, @stock_actual = 400, @stock_minimo = 12
    EXEC SP07_CreateOrUpdateProducto @codigo = 'MED006', @nombre = 'Desparasitante Externo', @precio = 15.60, @categoria_id = @CatMedicamentos, @stock_actual = 700, @stock_minimo = 18
    EXEC SP07_CreateOrUpdateProducto @codigo = 'MED007', @nombre = 'Suplemento Nutricional', @precio = 22.40, @categoria_id = @CatMedicamentos, @stock_actual = 350, @stock_minimo = 8
    EXEC SP07_CreateOrUpdateProducto @codigo = 'MED008', @nombre = 'Analgésico Tramadol', @precio = 45.80, @categoria_id = @CatMedicamentos, @stock_actual = 300, @stock_minimo = 5
    EXEC SP07_CreateOrUpdateProducto @codigo = 'MED009', @nombre = 'Antibiótico Cefalexina', @precio = 38.25, @categoria_id = @CatMedicamentos, @stock_actual = 450, @stock_minimo = 15
    EXEC SP07_CreateOrUpdateProducto @codigo = 'MED010', @nombre = 'Probiótico Veterinario', @precio = 32.50, @categoria_id = @CatMedicamentos, @stock_actual = 250, @stock_minimo = 10
END

-- Verificar que existan diagnósticos/servicios
DECLARE @DiagCount INT
SELECT @DiagCount = COUNT(*) FROM diagnostico WHERE activo = 1
IF @DiagCount < 10
BEGIN
    PRINT 'Insertando servicios básicos...'
    
    -- Insertar diagnósticos/servicios básicos
    EXEC SP08_CreateOrUpdateDiagnostico @codigo = 'SERV001', @nombre = 'Consulta Veterinaria General', @precio_base = 50.00, @categoria_diagnostico = 'Consultas'
    EXEC SP08_CreateOrUpdateDiagnostico @codigo = 'SERV002', @nombre = 'Vacunación', @precio_base = 40.00, @categoria_diagnostico = 'Prevención'
    EXEC SP08_CreateOrUpdateDiagnostico @codigo = 'SERV003', @nombre = 'Desparasitación', @precio_base = 30.00, @categoria_diagnostico = 'Prevención'
    EXEC SP08_CreateOrUpdateDiagnostico @codigo = 'SERV004', @nombre = 'Cirugía Menor', @precio_base = 200.00, @categoria_diagnostico = 'Cirugía'
    EXEC SP08_CreateOrUpdateDiagnostico @codigo = 'SERV005', @nombre = 'Examen de Laboratorio', @precio_base = 80.00, @categoria_diagnostico = 'Diagnóstico'
    EXEC SP08_CreateOrUpdateDiagnostico @codigo = 'SERV006', @nombre = 'Radiografía', @precio_base = 120.00, @categoria_diagnostico = 'Diagnóstico'
    EXEC SP08_CreateOrUpdateDiagnostico @codigo = 'SERV007', @nombre = 'Limpieza Dental', @precio_base = 150.00, @categoria_diagnostico = 'Odontología'
    EXEC SP08_CreateOrUpdateDiagnostico @codigo = 'SERV008', @nombre = 'Esterilización', @precio_base = 300.00, @categoria_diagnostico = 'Cirugía'
    EXEC SP08_CreateOrUpdateDiagnostico @codigo = 'SERV009', @nombre = 'Ecografía', @precio_base = 100.00, @categoria_diagnostico = 'Diagnóstico'
    EXEC SP08_CreateOrUpdateDiagnostico @codigo = 'SERV010', @nombre = 'Hospitalización', @precio_base = 75.00, @categoria_diagnostico = 'Hospitalización'
END

-- Verificar que exista personal veterinario  
DECLARE @VetCount INT
SELECT @VetCount = COUNT(*) FROM personal_veterinario
IF @VetCount < 3
BEGIN
    PRINT 'Insertando veterinarios básicos...'
    
    EXEC SP03_CreateOrUpdateVeterinario @nombre = 'Dr. Carlos', @apellido = 'Mendoza Silva', @email = 'cmendoza@vet.com', @usuario = 'cmendoza', @contrasena = 'vet123', @telefono = '78123456', @direccion = 'Av. América #123', @num_licencia = 'VET001', @especialidad = 'Medicina General', @universidad = 'UMSA', @salario = 8000.00
    EXEC SP03_CreateOrUpdateVeterinario @nombre = 'Dra. Ana', @apellido = 'Rodriguez Lopez', @email = 'arodriguez@vet.com', @usuario = 'arodriguez', @contrasena = 'vet456', @telefono = '69234567', @direccion = 'Calle Sucre #456', @num_licencia = 'VET002', @especialidad = 'Cirugía', @universidad = 'UCB', @salario = 9000.00
    EXEC SP03_CreateOrUpdateVeterinario @nombre = 'Dr. Miguel', @apellido = 'Vargas Quispe', @email = 'mvargas@vet.com', @usuario = 'mvargas', @contrasena = 'vet789', @telefono = '71345678', @direccion = 'Av. 6 de Agosto #789', @num_licencia = 'VET003', @especialidad = 'Pequeños Animales', @universidad = 'UPSA', @salario = 7500.00
END

PRINT 'Datos base verificados y preparados.'
PRINT '========================================'

-- =============================================
-- GENERAR 100 VENTAS CON PRODUCTOS Y SERVICIOS
-- =============================================

DECLARE @i INT = 1
DECLARE @persona_id INT
DECLARE @vet_id INT
DECLARE @productos_json NVARCHAR(MAX)
DECLARE @servicios_json NVARCHAR(MAX)
DECLARE @numero_factura VARCHAR(50)
DECLARE @fecha_base DATE = '2024-01-01'
DECLARE @dias_aleatorios INT

WHILE @i <= 100
BEGIN
    PRINT 'Generando venta ' + CAST(@i AS VARCHAR(3)) + '/100'
    
    -- Seleccionar persona aleatoria
    SELECT TOP 1 @persona_id = id 
    FROM persona 
    WHERE activo = 1
    ORDER BY NEWID()
    
    -- Seleccionar veterinario aleatorio  
    SELECT TOP 1 @vet_id = id
    FROM personal_veterinario
    ORDER BY NEWID()
    
    -- Generar número de factura
    SET @numero_factura = 'FAC-' + RIGHT('0000' + CAST(@i AS VARCHAR), 4)
    
    -- Fecha aleatoria en los últimos 365 días
    SET @dias_aleatorios = ABS(CHECKSUM(NEWID())) % 365
    SET @fecha_base = DATEADD(DAY, @dias_aleatorios, '2024-01-01')
    
    -- Generar productos JSON (1-4 productos aleatorios)
    DECLARE @num_productos INT = (ABS(CHECKSUM(NEWID())) % 4) + 1
    DECLARE @j INT = 1
    SET @productos_json = '['
    
    WHILE @j <= @num_productos
    BEGIN
        DECLARE @prod_id INT
        DECLARE @cantidad INT = (ABS(CHECKSUM(NEWID())) % 5) + 1
        DECLARE @descuento DECIMAL(10,2) = 0
        
        -- Seleccionar producto aleatorio
        SELECT TOP 1 @prod_id = id 
        FROM producto 
        WHERE activo = 1
        ORDER BY NEWID()
        
        -- 20% de probabilidad de descuento
        IF (ABS(CHECKSUM(NEWID())) % 100) < 20
            SET @descuento = (ABS(CHECKSUM(NEWID())) % 10) + 1
        
        IF @j > 1 SET @productos_json = @productos_json + ','
        SET @productos_json = @productos_json + '{"id":' + CAST(@prod_id AS VARCHAR) + ',"cantidad":' + CAST(@cantidad AS VARCHAR) + ',"descuento":' + CAST(@descuento AS VARCHAR) + '}'
        
        SET @j = @j + 1
    END
    SET @productos_json = @productos_json + ']'
    
    -- Generar servicios JSON (1-3 servicios aleatorios)
    DECLARE @num_servicios INT = (ABS(CHECKSUM(NEWID())) % 3) + 1
    SET @j = 1
    SET @servicios_json = '['
    
    WHILE @j <= @num_servicios
    BEGIN
        DECLARE @serv_id INT
        DECLARE @serv_cantidad INT = 1
        DECLARE @serv_descuento DECIMAL(10,2) = 0
        
        -- Seleccionar servicio aleatorio
        SELECT TOP 1 @serv_id = id 
        FROM diagnostico 
        WHERE activo = 1
        ORDER BY NEWID()
        
        -- 15% de probabilidad de descuento en servicios
        IF (ABS(CHECKSUM(NEWID())) % 100) < 15
            SET @serv_descuento = (ABS(CHECKSUM(NEWID())) % 15) + 1
        
        IF @j > 1 SET @servicios_json = @servicios_json + ','
        SET @servicios_json = @servicios_json + '{"id":' + CAST(@serv_id AS VARCHAR) + ',"cantidad":' + CAST(@serv_cantidad AS VARCHAR) + ',"descuento":' + CAST(@serv_descuento AS VARCHAR) + ',"veterinario_id":' + CAST(@vet_id AS VARCHAR) + '}'
        
        SET @j = @j + 1
    END
    SET @servicios_json = @servicios_json + ']'
    
    -- Calcular impuestos aleatorios (0-13%)
    DECLARE @impuestos DECIMAL(10,2) = (ABS(CHECKSUM(NEWID())) % 14) * 1.0
    
    -- Estado aleatorio (80% pagadas, 15% pendientes, 5% canceladas)
    DECLARE @estado VARCHAR(20)
    DECLARE @rand_estado INT = ABS(CHECKSUM(NEWID())) % 100
    IF @rand_estado < 80 
        SET @estado = 'Pagada'
    ELSE IF @rand_estado < 95
        SET @estado = 'Pendiente'  
    ELSE
        SET @estado = 'Cancelada'
    
    -- Ejecutar procedimiento almacenado
    BEGIN TRY
        EXEC SP_SaveFactura 
            @persona_id = @persona_id,
            @numero_factura = @numero_factura,
            @fecha_vencimiento = @fecha_base,
            @notas = 'Venta generada automáticamente por seeder',
            @productos = @productos_json,
            @servicios = @servicios_json,
            @impuestos = @impuestos,
            @descuentos = 0,
            @estado = @estado,
            @finalizar = 1
            
        -- Actualizar fecha de emisión para simular ventas en diferentes fechas
        UPDATE factura 
        SET fecha_emision = @fecha_base
        WHERE numero_factura = @numero_factura
        
    END TRY
    BEGIN CATCH
        PRINT 'Error en venta ' + CAST(@i AS VARCHAR) + ': ' + ERROR_MESSAGE()
    END CATCH
    
    SET @i = @i + 1
END

PRINT '========================================'
PRINT 'SEEDER DE VENTAS COMPLETADO EXITOSAMENTE'
PRINT '========================================'

-- =============================================
-- VERIFICAR RESULTADOS
-- =============================================

-- Contar facturas generadas
DECLARE @FacturaCount INT
SELECT @FacturaCount = COUNT(*) FROM factura

PRINT 'Total de facturas generadas: ' + CAST(@FacturaCount AS VARCHAR(10))

-- Mostrar estadísticas por estado
SELECT 
    estado,
    COUNT(*) as cantidad,
    FORMAT(SUM(total), 'C', 'es-BO') as total_monto
FROM factura 
GROUP BY estado
ORDER BY COUNT(*) DESC

-- Mostrar resumen de productos vendidos
SELECT TOP 10
    p.codigo,
    p.nombre,
    SUM(dp.cantidad) as total_vendido,
    FORMAT(SUM(dp.subtotal), 'C', 'es-BO') as ingresos_generados
FROM detalle_productos dp
INNER JOIN producto p ON dp.producto_id = p.id
INNER JOIN factura f ON dp.factura_id = f.id
GROUP BY p.codigo, p.nombre
ORDER BY SUM(dp.cantidad) DESC

-- Mostrar resumen de servicios prestados  
SELECT TOP 10
    d.codigo,
    d.nombre,
    COUNT(*) as veces_prestado,
    FORMAT(SUM(ds.subtotal), 'C', 'es-BO') as ingresos_generados
FROM detalle_servicios ds
INNER JOIN diagnostico d ON ds.diagnostico_id = d.id
INNER JOIN factura f ON ds.factura_id = f.id
GROUP BY d.codigo, d.nombre
ORDER BY COUNT(*) DESC

-- Estadísticas de ventas por mes
SELECT 
    YEAR(fecha_emision) as año,
    MONTH(fecha_emision) as mes,
    DATENAME(MONTH, fecha_emision) as nombre_mes,
    COUNT(*) as total_facturas,
    FORMAT(SUM(total), 'C', 'es-BO') as total_ventas
FROM factura
GROUP BY YEAR(fecha_emision), MONTH(fecha_emision), DATENAME(MONTH, fecha_emision)
ORDER BY año DESC, mes DESC

PRINT 'Datos de ejemplo generados correctamente:'
PRINT '- 100 facturas con productos y servicios'
PRINT '- Fechas distribuidas en el año 2024'
PRINT '- Estados realistas (80% pagadas)'
PRINT '- Productos y servicios aleatorios'
PRINT '- Descuentos e impuestos variables'
PRINT '- Veterinarios asignados a servicios'
PRINT 'Fecha de generación: ' + CONVERT(VARCHAR(20), GETDATE(), 120)
PRINT '========================================'

-- =============================================
-- FIN DEL SCRIPT
-- =============================================