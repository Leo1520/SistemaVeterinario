-- =============================================
-- Script: 2025_09_01_0001_datos_base_y_facturas.sql
-- Descripción: Crear datos base y generar 100 facturas con productos y servicios
-- Fecha: 1 de septiembre de 2025
-- Autor: Sistema Veterinario
-- Versión: 1.0
-- Optimizado para evitar anidamiento excesivo
-- =============================================

PRINT 'Iniciando creación de datos base y 100 facturas...'
PRINT '=================================================='

-- =============================================
-- 1. CREAR DATOS BASE - CATEGORÍAS
-- =============================================

PRINT '1. Creando categorías base...'
BEGIN TRANSACTION;

IF NOT EXISTS (SELECT 1 FROM categoria WHERE nombre = 'Medicamentos')
    INSERT INTO categoria (nombre, descripcion, activo) VALUES ('Medicamentos', 'Medicamentos veterinarios', 1);

IF NOT EXISTS (SELECT 1 FROM categoria WHERE nombre = 'Alimentos')
    INSERT INTO categoria (nombre, descripcion, activo) VALUES ('Alimentos', 'Alimentos para mascotas', 1);

IF NOT EXISTS (SELECT 1 FROM categoria WHERE nombre = 'Accesorios')
    INSERT INTO categoria (nombre, descripcion, activo) VALUES ('Accesorios', 'Accesorios y juguetes', 1);

IF NOT EXISTS (SELECT 1 FROM categoria WHERE nombre = 'Higiene')
    INSERT INTO categoria (nombre, descripcion, activo) VALUES ('Higiene', 'Productos de higiene', 1);

COMMIT TRANSACTION;

DECLARE @CatMedicamentos INT, @CatAlimentos INT, @CatAccesorios INT, @CatHigiene INT;
SELECT @CatMedicamentos = id FROM categoria WHERE nombre = 'Medicamentos';
SELECT @CatAlimentos = id FROM categoria WHERE nombre = 'Alimentos';
SELECT @CatAccesorios = id FROM categoria WHERE nombre = 'Accesorios';
SELECT @CatHigiene = id FROM categoria WHERE nombre = 'Higiene';

PRINT 'Categorías creadas correctamente'

-- =============================================
-- 2. CREAR DATOS BASE - PRODUCTOS
-- =============================================

PRINT '2. Creando productos base...'
BEGIN TRANSACTION;

-- Medicamentos
INSERT INTO producto (codigo, nombre, descripcion, precio, stock_minimo, stock_actual, requiere_receta, categoria_id, activo) VALUES
('MED001', 'Antibiótico Amoxicilina 500mg', 'Antibiótico de amplio espectro', 25.50, 10, 1000, 1, @CatMedicamentos, 1),
('MED002', 'Antiparasitario Interno', 'Desparasitante para uso interno', 18.75, 15, 800, 1, @CatMedicamentos, 1),
('MED003', 'Vacuna Antirrábica', 'Vacuna contra la rabia', 35.00, 20, 500, 1, @CatMedicamentos, 1),
('MED004', 'Vitaminas B Complex', 'Complejo vitamínico B', 12.25, 25, 600, 0, @CatMedicamentos, 1),
('MED005', 'Antiinflamatorio Meloxicam', 'Antiinflamatorio no esteroideo', 28.90, 12, 400, 1, @CatMedicamentos, 1),
('MED006', 'Desparasitante Externo', 'Antipulgas y garrapatas', 15.60, 18, 700, 0, @CatMedicamentos, 1),
('MED007', 'Suplemento Nutricional', 'Suplemento vitamínico general', 22.40, 8, 350, 0, @CatMedicamentos, 1),
('MED008', 'Analgésico Tramadol', 'Analgésico para dolor moderado a severo', 45.80, 5, 300, 1, @CatMedicamentos, 1),
('MED009', 'Antibiótico Cefalexina', 'Cefalosporina de primera generación', 38.25, 15, 450, 1, @CatMedicamentos, 1),
('MED010', 'Probiótico Veterinario', 'Probióticos para salud digestiva', 32.50, 10, 250, 0, @CatMedicamentos, 1);

COMMIT TRANSACTION;
BEGIN TRANSACTION;

-- Alimentos
INSERT INTO producto (codigo, nombre, descripcion, precio, stock_minimo, stock_actual, requiere_receta, categoria_id, activo) VALUES
('ALI001', 'Alimento Premium Perro Adulto 15kg', 'Alimento balanceado para perros adultos', 85.00, 5, 150, 0, @CatAlimentos, 1),
('ALI002', 'Alimento Premium Gato Adulto 7.5kg', 'Alimento balanceado para gatos adultos', 65.00, 8, 120, 0, @CatAlimentos, 1),
('ALI003', 'Alimento Cachorro 10kg', 'Alimento especial para cachorros', 75.00, 6, 100, 0, @CatAlimentos, 1),
('ALI004', 'Snacks Dentales Perro', 'Premios para higiene dental', 18.50, 20, 300, 0, @CatAlimentos, 1),
('ALI005', 'Leche Maternizada Cachorros', 'Sustituto de leche materna', 45.00, 10, 80, 0, @CatAlimentos, 1);

COMMIT TRANSACTION;
BEGIN TRANSACTION;

-- Accesorios
INSERT INTO producto (codigo, nombre, descripcion, precio, stock_minimo, stock_actual, requiere_receta, categoria_id, activo) VALUES
('ACC001', 'Collar Ajustable Mediano', 'Collar de nylon ajustable', 12.00, 15, 200, 0, @CatAccesorios, 1),
('ACC002', 'Correa Retráctil 5m', 'Correa retráctil para paseos', 35.00, 10, 150, 0, @CatAccesorios, 1),
('ACC003', 'Juguete Pelota Resistente', 'Pelota de goma resistente', 8.50, 25, 400, 0, @CatAccesorios, 1),
('ACC004', 'Cama Perro Grande', 'Cama acolchada para perros grandes', 95.00, 5, 50, 0, @CatAccesorios, 1),
('ACC005', 'Transportadora Gato', 'Transportadora plástica para gatos', 125.00, 3, 30, 0, @CatAccesorios, 1);

-- Higiene
INSERT INTO producto (codigo, nombre, descripcion, precio, stock_minimo, stock_actual, requiere_receta, categoria_id, activo) VALUES
('HIG001', 'Shampoo Antipulgas 500ml', 'Shampoo medicado antipulgas', 28.00, 12, 180, 0, @CatHigiene, 1),
('HIG002', 'Toallitas Húmedas Mascotas', 'Toallitas para limpieza diaria', 15.00, 20, 250, 0, @CatHigiene, 1),
('HIG003', 'Desodorante Ambiental', 'Neutralizador de olores para mascotas', 22.50, 15, 160, 0, @CatHigiene, 1),
('HIG004', 'Cepillo Dental Pet', 'Cepillo de dientes para mascotas', 12.75, 18, 220, 0, @CatHigiene, 1),
('HIG005', 'Pasta Dental Veterinaria', 'Pasta dental especial para mascotas', 18.90, 15, 140, 0, @CatHigiene, 1);

COMMIT TRANSACTION;

PRINT 'Productos creados correctamente'

-- =============================================
-- 3. CREAR DATOS BASE - DIAGNÓSTICOS/SERVICIOS
-- =============================================

PRINT '3. Creando servicios base...'

INSERT INTO diagnostico (codigo, nombre, descripcion, precio_base, categoria_diagnostico, requiere_equipamiento, activo) VALUES
('SERV001', 'Consulta Veterinaria General', 'Consulta médica general', 50.00, 'Consultas', 0, 1),
('SERV002', 'Vacunación', 'Aplicación de vacunas', 40.00, 'Prevención', 0, 1),
('SERV003', 'Desparasitación', 'Tratamiento antiparasitario', 30.00, 'Prevención', 0, 1),
('SERV004', 'Cirugía Menor', 'Procedimientos quirúrgicos menores', 200.00, 'Cirugía', 1, 1),
('SERV005', 'Examen de Laboratorio', 'Análisis clínicos básicos', 80.00, 'Diagnóstico', 1, 1),
('SERV006', 'Radiografía', 'Estudio radiológico', 120.00, 'Diagnóstico', 1, 1),
('SERV007', 'Limpieza Dental', 'Profilaxis dental veterinaria', 150.00, 'Odontología', 1, 1),
('SERV008', 'Esterilización', 'Castración/esterilización', 300.00, 'Cirugía', 1, 1),
('SERV009', 'Ecografía', 'Ultrasonido diagnóstico', 100.00, 'Diagnóstico', 1, 1),
('SERV010', 'Hospitalización (día)', 'Internación por día', 75.00, 'Hospitalización', 0, 1),
('SERV011', 'Curación de Heridas', 'Tratamiento de heridas menores', 35.00, 'Tratamiento', 0, 1),
('SERV012', 'Control Post-operatorio', 'Seguimiento post-cirugía', 45.00, 'Seguimiento', 0, 1),
('SERV013', 'Terapia con Suero', 'Fluidoterapia intravenosa', 60.00, 'Tratamiento', 0, 1),
('SERV014', 'Aplicación de Inyecciones', 'Administración de medicamentos inyectables', 25.00, 'Tratamiento', 0, 1),
('SERV015', 'Corte de Uñas', 'Recorte de uñas profesional', 20.00, 'Estética', 0, 1);

PRINT 'Servicios creados: ' + CAST(@@ROWCOUNT AS VARCHAR(10))

-- =============================================
-- 4. CREAR DATOS BASE - PERSONAS
-- =============================================

PRINT '4. Creando personas base...'

-- Personas Físicas
DECLARE @i INT = 1;
WHILE @i <= 50
BEGIN
    DECLARE @persona_id INT;
    DECLARE @nombre VARCHAR(100), @apellido VARCHAR(100), @ci VARCHAR(15), @email VARCHAR(255);
    DECLARE @telefono VARCHAR(20), @direccion VARCHAR(255);
    
    -- Generar datos aleatorios
    SET @nombre = CASE (ABS(CHECKSUM(NEWID())) % 20)
        WHEN 0 THEN 'Juan' WHEN 1 THEN 'María' WHEN 2 THEN 'Carlos' WHEN 3 THEN 'Ana'
        WHEN 4 THEN 'Luis' WHEN 5 THEN 'Carmen' WHEN 6 THEN 'Pedro' WHEN 7 THEN 'Rosa'
        WHEN 8 THEN 'Diego' WHEN 9 THEN 'Elena' WHEN 10 THEN 'Miguel' WHEN 11 THEN 'Laura'
        WHEN 12 THEN 'José' WHEN 13 THEN 'Patricia' WHEN 14 THEN 'Antonio' WHEN 15 THEN 'Isabel'
        WHEN 16 THEN 'Francisco' WHEN 17 THEN 'Mónica' WHEN 18 THEN 'Javier' ELSE 'Claudia'
    END;
    
    SET @apellido = CASE (ABS(CHECKSUM(NEWID())) % 20)
        WHEN 0 THEN 'García López' WHEN 1 THEN 'Rodríguez Silva' WHEN 2 THEN 'Martínez Quispe'
        WHEN 3 THEN 'López Mamani' WHEN 4 THEN 'González Vargas' WHEN 5 THEN 'Pérez Condori'
        WHEN 6 THEN 'Sánchez Morales' WHEN 7 THEN 'Ramírez Choque' WHEN 8 THEN 'Cruz Apaza'
        WHEN 9 THEN 'Flores Torrez' WHEN 10 THEN 'Herrera Nina' WHEN 11 THEN 'Jiménez Calle'
        WHEN 12 THEN 'Morales Quisbert' WHEN 13 THEN 'Ruiz Limachi' WHEN 14 THEN 'Díaz Huanca'
        WHEN 15 THEN 'Álvarez Chura' WHEN 16 THEN 'Romero Condori' WHEN 17 THEN 'Torres Inca'
        WHEN 18 THEN 'Domínguez Copa' ELSE 'Gutiérrez Mamani'
    END;
    
    SET @ci = CAST((ABS(CHECKSUM(NEWID())) % 10000000) + 1000000 AS VARCHAR) + ' LP';
    SET @email = LOWER(@nombre) + '.' + LOWER(REPLACE(@apellido, ' ', '')) + '@email.com';
    SET @telefono = '7' + CAST((ABS(CHECKSUM(NEWID())) % 10000000) + 1000000 AS VARCHAR(7));
    SET @direccion = 'Av. ' + @apellido + ' #' + CAST((ABS(CHECKSUM(NEWID())) % 999) + 100 AS VARCHAR);

    -- Insertar persona
    INSERT INTO persona (tipo, email, direccion, telefono, activo)
    VALUES ('Física', @email, @direccion, @telefono, 1);
    
    SET @persona_id = SCOPE_IDENTITY();
    
    -- Insertar persona física
    INSERT INTO persona_fisica (id, ci, nombre, apellido, fecha_nacimiento, genero)
    VALUES (@persona_id, @ci, @nombre, @apellido, 
            DATEADD(YEAR, -(ABS(CHECKSUM(NEWID())) % 50) - 18, GETDATE()),
            CASE ABS(CHECKSUM(NEWID())) % 2 WHEN 0 THEN 'M' ELSE 'F' END);
    
    SET @i = @i + 1;
END;

-- Personas Jurídicas
SET @i = 1;
WHILE @i <= 10
BEGIN
    DECLARE @razon_social VARCHAR(255), @nit VARCHAR(20);
    
    SET @razon_social = CASE (ABS(CHECKSUM(NEWID())) % 10)
        WHEN 0 THEN 'Veterinaria San Martín SRL' WHEN 1 THEN 'Clínica Animal Care LTDA'
        WHEN 2 THEN 'Pet Shop Los Amigos SRL' WHEN 3 THEN 'Hospital Veterinario Central SA'
        WHEN 4 THEN 'Farmacia Veterinaria Salud Animal' WHEN 5 THEN 'Refugio de Mascotas Esperanza'
        WHEN 6 THEN 'Tienda de Mascotas El Paraíso' WHEN 7 THEN 'Centro de Adopción Animal'
        WHEN 8 THEN 'Cuidados Veterinarios Integrales' ELSE 'Servicios Veterinarios Premium'
    END;
    
    SET @nit = CAST((ABS(CHECKSUM(NEWID())) % 900000000) + 100000000 AS VARCHAR);
    SET @email = 'info@' + REPLACE(LOWER(@razon_social), ' ', '') + '.com';
    SET @direccion = 'Zona ' + CAST(@i AS VARCHAR) + ', Calle Comercio #' + CAST((@i * 100) AS VARCHAR);
    SET @telefono = '2' + CAST((ABS(CHECKSUM(NEWID())) % 1000000) + 100000 AS VARCHAR(6));

    -- Insertar persona jurídica
    INSERT INTO persona (tipo, email, direccion, telefono, activo)
    VALUES ('Jurídica', @email, @direccion, @telefono, 1);
    
    SET @persona_id = SCOPE_IDENTITY();
    
    INSERT INTO persona_juridica (id, razon_social, nit, encargado_nombre, encargado_cargo)
    VALUES (@persona_id, @razon_social, @nit, 
            'Encargado ' + CAST(@i AS VARCHAR), 'Gerente General');
    
    SET @i = @i + 1;
END;

PRINT 'Personas creadas: 50 físicas + 10 jurídicas = 60 total'

-- =============================================
-- 5. CREAR DATOS BASE - PERSONAL VETERINARIO
-- =============================================

PRINT '5. Creando personal veterinario...'

INSERT INTO personal (nombre, apellido, email, usuario, contrasena, telefono, direccion, salario, rol, activo) VALUES
('Dr. Carlos', 'Mendoza Silva', 'cmendoza@vet.com', 'cmendoza', 'vet123', '78123456', 'Av. América #123', 8000.00, 'Veterinario', 1),
('Dra. Ana', 'Rodríguez López', 'arodriguez@vet.com', 'arodriguez', 'vet456', '69234567', 'Calle Sucre #456', 9000.00, 'Veterinario', 1),
('Dr. Miguel', 'Vargas Quispe', 'mvargas@vet.com', 'mvargas', 'vet789', '71345678', 'Av. 6 de Agosto #789', 7500.00, 'Veterinario', 1),
('Dra. Patricia', 'Morales Choque', 'pmorales@vet.com', 'pmorales', 'vet321', '75456789', 'Calle Comercio #321', 8500.00, 'Veterinario', 1),
('Dr. Roberto', 'Jiménez Mamani', 'rjimenez@vet.com', 'rjimenez', 'vet654', '68567890', 'Av. Ballivián #654', 7800.00, 'Veterinario', 1);

-- Insertar datos de veterinarios
DECLARE @vet_ids TABLE (id INT, licencia VARCHAR(50), especialidad VARCHAR(100));

DECLARE @id1 INT = (SELECT id FROM personal WHERE usuario = 'cmendoza');
DECLARE @id2 INT = (SELECT id FROM personal WHERE usuario = 'arodriguez');
DECLARE @id3 INT = (SELECT id FROM personal WHERE usuario = 'mvargas');
DECLARE @id4 INT = (SELECT id FROM personal WHERE usuario = 'pmorales');
DECLARE @id5 INT = (SELECT id FROM personal WHERE usuario = 'rjimenez');

INSERT INTO personal_veterinario (id, num_licencia, especialidad, universidad, anios_experiencia) VALUES
(@id1, 'VET001', 'Medicina General', 'Universidad Veterinaria', 5),
(@id2, 'VET002', 'Cirugía', 'Universidad Veterinaria', 8),
(@id3, 'VET003', 'Pequeños Animales', 'Universidad Veterinaria', 3),
(@id4, 'VET004', 'Medicina Interna', 'Universidad Veterinaria', 10),
(@id5, 'VET005', 'Dermatología', 'Universidad Veterinaria', 7);

PRINT 'Personal veterinario creado: 5 veterinarios'

-- =============================================
-- 6. GENERAR 100 FACTURAS CON PRODUCTOS Y SERVICIOS
-- =============================================

BEGIN TRANSACTION;

PRINT '6. Generando 100 facturas...'

SET @i = 1;
WHILE @i <= 100
BEGIN
    DECLARE @factura_id INT;
    DECLARE @numero_factura VARCHAR(50) = 'FAC-' + RIGHT('0000' + CAST(@i AS VARCHAR), 4);
    DECLARE @fecha_emision DATE;
    DECLARE @fecha_vencimiento DATE;
    DECLARE @subtotal DECIMAL(10,2) = 0;
    DECLARE @impuestos DECIMAL(10,2);
    DECLARE @descuentos DECIMAL(10,2) = 0;
    DECLARE @total DECIMAL(10,2);
    DECLARE @estado VARCHAR(20);
    
    -- Seleccionar persona aleatoria
    SELECT TOP 1 @persona_id = id FROM persona WHERE activo = 1 ORDER BY NEWID();
    
    -- Fecha aleatoria en los últimos 365 días
    SET @fecha_emision = DATEADD(DAY, -(ABS(CHECKSUM(NEWID())) % 365), GETDATE());
    SET @fecha_vencimiento = DATEADD(DAY, 30, @fecha_emision);
    
    -- Estado aleatorio
    SET @estado = CASE ABS(CHECKSUM(NEWID())) % 100
        WHEN 0 THEN 'Cancelada' 
        WHEN 1 THEN 'Anulada'
        ELSE CASE WHEN ABS(CHECKSUM(NEWID())) % 100 < 85 THEN 'Pagada' ELSE 'Pendiente' END
    END;
    
    -- Crear factura
    INSERT INTO factura (numero_factura, fecha_emision, fecha_vencimiento, persona_id, 
                        subtotal, impuestos, descuentos, total, estado, notas)
    VALUES (@numero_factura, @fecha_emision, @fecha_vencimiento, @persona_id,
            0, 0, 0, 0, @estado, 'Factura generada automáticamente');
    
    SET @factura_id = SCOPE_IDENTITY();
    
    -- Agregar productos (1-4 productos por factura)
    DECLARE @num_productos INT = (ABS(CHECKSUM(NEWID())) % 4) + 1;
    DECLARE @j INT = 1;
    
    WHILE @j <= @num_productos
    BEGIN
        DECLARE @producto_id INT, @cantidad INT, @precio_unitario DECIMAL(10,2);
        DECLARE @descuento_unitario DECIMAL(10,2) = 0, @subtotal_producto DECIMAL(10,2);
        
        -- Seleccionar producto aleatorio
        SELECT TOP 1 @producto_id = id, @precio_unitario = precio 
        FROM producto WHERE activo = 1 ORDER BY NEWID();
        
        SET @cantidad = (ABS(CHECKSUM(NEWID())) % 5) + 1;
        
        -- 20% probabilidad de descuento
        IF (ABS(CHECKSUM(NEWID())) % 100) < 20
            SET @descuento_unitario = @precio_unitario * 0.1; -- 10% descuento
        
        SET @subtotal_producto = (@precio_unitario - @descuento_unitario) * @cantidad;
        SET @subtotal = @subtotal + @subtotal_producto;
        
        -- Insertar detalle producto
        INSERT INTO detalle_productos (factura_id, producto_id, cantidad, precio_unitario, 
                                     descuento_unitario, subtotal, receta_verificada)
        VALUES (@factura_id, @producto_id, @cantidad, @precio_unitario, 
                @descuento_unitario, @subtotal_producto, 
                CASE WHEN (SELECT requiere_receta FROM producto WHERE id = @producto_id) = 1 
                     THEN ABS(CHECKSUM(NEWID())) % 2 ELSE 0 END);
        
        -- Actualizar stock
        UPDATE producto SET stock_actual = stock_actual - @cantidad WHERE id = @producto_id;
        
        SET @j = @j + 1;
    END;
    
    -- Agregar servicios (1-3 servicios por factura)
    DECLARE @num_servicios INT = (ABS(CHECKSUM(NEWID())) % 3) + 1;
    SET @j = 1;
    
    WHILE @j <= @num_servicios
    BEGIN
        DECLARE @diagnostico_id INT, @precio_servicio DECIMAL(10,2);
        DECLARE @descuento_servicio DECIMAL(10,2) = 0, @subtotal_servicio DECIMAL(10,2);
        DECLARE @veterinario_id INT;
        
        -- Seleccionar servicio aleatorio
        SELECT TOP 1 @diagnostico_id = id, @precio_servicio = precio_base 
        FROM diagnostico WHERE activo = 1 ORDER BY NEWID();
        
        -- Seleccionar veterinario aleatorio
        SELECT TOP 1 @veterinario_id = id FROM personal_veterinario ORDER BY NEWID();
        
        -- 15% probabilidad de descuento en servicios
        IF (ABS(CHECKSUM(NEWID())) % 100) < 15
            SET @descuento_servicio = @precio_servicio * 0.05; -- 5% descuento
        
        SET @subtotal_servicio = @precio_servicio - @descuento_servicio;
        SET @subtotal = @subtotal + @subtotal_servicio;
        
        -- Insertar detalle servicio
        INSERT INTO detalle_servicios (factura_id, diagnostico_id, cantidad, precio_unitario,
                                     descuento_unitario, subtotal, veterinario_id)
        VALUES (@factura_id, @diagnostico_id, 1, @precio_servicio, 
                @descuento_servicio, @subtotal_servicio, @veterinario_id);
        
        SET @j = @j + 1;
    END;
    
    -- Calcular totales
    SET @impuestos = @subtotal * 0.13; -- 13% IVA
    SET @total = @subtotal + @impuestos - @descuentos;
    
    -- Actualizar factura con totales
    UPDATE factura 
    SET subtotal = @subtotal, impuestos = @impuestos, descuentos = @descuentos, total = @total
    WHERE id = @factura_id;
    
    IF @i % 10 = 0 
        PRINT 'Procesadas ' + CAST(@i AS VARCHAR) + '/100 facturas...';
    
    SET @i = @i + 1;
END;

PRINT 'Facturas generadas: 100'

-- =============================================
-- REHABILITAR TODOS LOS TRIGGERS
-- =============================================

PRINT 'Rehabilitando triggers...'
ALTER TABLE persona ENABLE TRIGGER ALL;
ALTER TABLE persona_fisica ENABLE TRIGGER ALL;
ALTER TABLE persona_juridica ENABLE TRIGGER ALL;  
ALTER TABLE personal ENABLE TRIGGER ALL;
ALTER TABLE personal_veterinario ENABLE TRIGGER ALL;
ALTER TABLE producto ENABLE TRIGGER ALL;
ALTER TABLE categoria ENABLE TRIGGER ALL;
ALTER TABLE diagnostico ENABLE TRIGGER ALL;
ALTER TABLE factura ENABLE TRIGGER ALL;
ALTER TABLE detalle_productos ENABLE TRIGGER ALL;
ALTER TABLE detalle_servicios ENABLE TRIGGER ALL;
PRINT 'Triggers rehabilitados exitosamente'

-- Confirmar transacción
COMMIT TRANSACTION;

PRINT '=================================================='
PRINT 'SCRIPT COMPLETADO EXITOSAMENTE'
PRINT '=================================================='

-- =============================================
-- 7. VERIFICAR RESULTADOS
-- =============================================

PRINT '7. Verificando resultados...'

-- Contar registros creados
SELECT 
    'Categorías' as Tabla, COUNT(*) as Registros FROM categoria
UNION ALL SELECT 'Productos', COUNT(*) FROM producto
UNION ALL SELECT 'Diagnósticos', COUNT(*) FROM diagnostico  
UNION ALL SELECT 'Personas', COUNT(*) FROM persona
UNION ALL SELECT 'Personal', COUNT(*) FROM personal
UNION ALL SELECT 'Veterinarios', COUNT(*) FROM personal_veterinario
UNION ALL SELECT 'Facturas', COUNT(*) FROM factura
UNION ALL SELECT 'Detalles Productos', COUNT(*) FROM detalle_productos
UNION ALL SELECT 'Detalles Servicios', COUNT(*) FROM detalle_servicios;

-- Estadísticas de facturas por estado
PRINT 'Facturas por estado:';
SELECT estado, COUNT(*) as cantidad, FORMAT(SUM(total), 'C', 'es-BO') as total_monto
FROM factura GROUP BY estado ORDER BY COUNT(*) DESC;

-- Top 5 productos más vendidos
PRINT 'Top 5 productos más vendidos:';
SELECT TOP 5 p.codigo, p.nombre, SUM(dp.cantidad) as total_vendido,
       FORMAT(SUM(dp.subtotal), 'C', 'es-BO') as ingresos
FROM detalle_productos dp
INNER JOIN producto p ON dp.producto_id = p.id
GROUP BY p.codigo, p.nombre
ORDER BY SUM(dp.cantidad) DESC;

-- Top 5 servicios más prestados
PRINT 'Top 5 servicios más prestados:';
SELECT TOP 5 d.codigo, d.nombre, COUNT(*) as veces_prestado,
       FORMAT(SUM(ds.subtotal), 'C', 'es-BO') as ingresos
FROM detalle_servicios ds
INNER JOIN diagnostico d ON ds.diagnostico_id = d.id
GROUP BY d.codigo, d.nombre
ORDER BY COUNT(*) DESC;

-- OBTENEMOS UN ID DE UNA FACTURA GENERADA PARA PRUEBAS
DECLARE @FacturaID INT;
SELECT @FacturaID = MAX(id) FROM factura;
PRINT 'Probando stored procedures con factura ID: ' + CAST(@FacturaID AS VARCHAR);

EXEC sp_factura_datos_principales @factura_id = @FacturaID;
EXEC sp_factura_detalle_productos @factura_id = @FacturaID;
EXEC sp_factura_detalle_servicios @factura_id = @FacturaID;

PRINT 'Script completado exitosamente. Fecha: ' + CONVERT(VARCHAR(20), GETDATE(), 120);
