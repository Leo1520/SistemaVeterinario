-- =============================================
-- Procedimientos almacenados para Detalle Historial
-- Sistema Veterinario
-- =============================================

-- Procedimiento para insertar un nuevo detalle de historial
CREATE OR ALTER PROCEDURE sp_insertar_detalle_historial
    @historico_id INT,
    @tipo_evento NVARCHAR(50),
    @fecha_evento DATETIME,
    @observaciones NVARCHAR(1000),
    @tratamiento NVARCHAR(500) = NULL,
    @medicamentos NVARCHAR(500) = NULL,
    @dosis NVARCHAR(200) = NULL,
    @veterinario_id INT = NULL,
    @peso_animal DECIMAL(5,2) = NULL,
    @temperatura DECIMAL(4,1) = NULL,
    @cobrado BIT = 0,
    @costo DECIMAL(10,2) = 0
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        -- Validar que el historial existe
        IF NOT EXISTS (SELECT 1 FROM historico WHERE id = @historico_id)
        BEGIN
            SELECT 'Error: El historial especificado no existe' AS resultado;
            RETURN;
        END
        
        -- Validar que el veterinario existe (si se proporciona)
        IF @veterinario_id IS NOT NULL AND NOT EXISTS (
            SELECT 1 FROM personal p 
            WHERE p.id = @veterinario_id AND p.rol = 'Veterinario'
        )
        BEGIN
            SELECT 'Error: El veterinario especificado no existe o no tiene el rol correcto' AS resultado;
            RETURN;
        END
        
        -- Insertar el detalle
        INSERT INTO detalle_historico (
            historico_id, tipo_evento, fecha_evento, observaciones, 
            tratamiento, medicamentos, dosis, veterinario_id,
            peso_animal, temperatura, cobrado, costo
        )
        VALUES (
            @historico_id, @tipo_evento, @fecha_evento, @observaciones,
            @tratamiento, @medicamentos, @dosis, @veterinario_id,
            @peso_animal, @temperatura, @cobrado, @costo
        );
        
        SELECT 'Detalle de historial insertado correctamente' AS resultado;
    END TRY
    BEGIN CATCH
        SELECT 'Error: ' + ERROR_MESSAGE() AS resultado;
    END CATCH
END
GO

-- Procedimiento para editar un detalle de historial
CREATE OR ALTER PROCEDURE sp_editar_detalle_historial
    @id INT,
    @historico_id INT,
    @tipo_evento NVARCHAR(50),
    @fecha_evento DATETIME,
    @observaciones NVARCHAR(1000),
    @tratamiento NVARCHAR(500) = NULL,
    @medicamentos NVARCHAR(500) = NULL,
    @dosis NVARCHAR(200) = NULL,
    @veterinario_id INT = NULL,
    @peso_animal DECIMAL(5,2) = NULL,
    @temperatura DECIMAL(4,1) = NULL,
    @cobrado BIT = 0,
    @costo DECIMAL(10,2) = 0
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        -- Validar que el detalle existe
        IF NOT EXISTS (SELECT 1 FROM detalle_historico WHERE id = @id)
        BEGIN
            SELECT 'Error: El detalle de historial especificado no existe' AS resultado;
            RETURN;
        END
        
        -- Validar que el historial existe
        IF NOT EXISTS (SELECT 1 FROM historico WHERE id = @historico_id)
        BEGIN
            SELECT 'Error: El historial especificado no existe' AS resultado;
            RETURN;
        END
        
        -- Validar que el veterinario existe (si se proporciona)
        IF @veterinario_id IS NOT NULL AND NOT EXISTS (
            SELECT 1 FROM personal p 
            WHERE p.id = @veterinario_id AND p.rol = 'Veterinario'
        )
        BEGIN
            SELECT 'Error: El veterinario especificado no existe o no tiene el rol correcto' AS resultado;
            RETURN;
        END
        
        -- Actualizar el detalle
        UPDATE detalle_historico SET
            historico_id = @historico_id,
            tipo_evento = @tipo_evento,
            fecha_evento = @fecha_evento,
            observaciones = @observaciones,
            tratamiento = @tratamiento,
            medicamentos = @medicamentos,
            dosis = @dosis,
            veterinario_id = @veterinario_id,
            peso_animal = @peso_animal,
            temperatura = @temperatura,
            cobrado = @cobrado,
            costo = @costo
        WHERE id = @id;
        
        SELECT 'Detalle de historial actualizado correctamente' AS resultado;
    END TRY
    BEGIN CATCH
        SELECT 'Error: ' + ERROR_MESSAGE() AS resultado;
    END CATCH
END
GO

-- Procedimiento para eliminar un detalle de historial
CREATE OR ALTER PROCEDURE sp_eliminar_detalle_historial
    @id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        -- Validar que el detalle existe
        IF NOT EXISTS (SELECT 1 FROM detalle_historico WHERE id = @id)
        BEGIN
            SELECT 'Error: El detalle de historial especificado no existe' AS resultado;
            RETURN;
        END
        
        -- Eliminar el detalle
        DELETE FROM detalle_historico WHERE id = @id;
        
        SELECT 'Detalle de historial eliminado correctamente' AS resultado;
    END TRY
    BEGIN CATCH
        SELECT 'Error: ' + ERROR_MESSAGE() AS resultado;
    END CATCH
END
GO

-- Procedimiento para obtener detalles por historial
CREATE OR ALTER PROCEDURE sp_mostrar_detalles_por_historial
    @historico_id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        dh.id,
        dh.historico_id,
        dh.tipo_evento,
        dh.fecha_evento,
        dh.observaciones,
        dh.tratamiento,
        dh.medicamentos,
        dh.dosis,
        dh.veterinario_id,
        dh.peso_animal,
        dh.temperatura,
        dh.cobrado,
        dh.costo,
        h.animal_id,
        a.nombre as animal_nombre,
        CASE 
            WHEN dh.veterinario_id IS NOT NULL 
            THEN CONCAT(pf.nombre, ' ', pf.apellido)
            ELSE 'Sin asignar'
        END as veterinario_nombre,
        CASE
            WHEN dh.veterinario_id IS NOT NULL
            THEN pv.especialidad
            ELSE ''
        END as veterinario_especialidad
    FROM detalle_historico dh
    INNER JOIN historico h ON dh.historico_id = h.id
    INNER JOIN animal a ON h.animal_id = a.id
    LEFT JOIN personal p ON dh.veterinario_id = p.id
    LEFT JOIN persona pe ON p.id = pe.id
    LEFT JOIN persona_fisica pf ON pe.id = pf.id
    LEFT JOIN personal_veterinario pv ON p.id = pv.id
    WHERE dh.historico_id = @historico_id
    ORDER BY dh.fecha_evento DESC;
END
GO

-- Procedimiento para obtener un detalle por ID
CREATE OR ALTER PROCEDURE sp_obtener_detalle_historial_por_id
    @id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        dh.id,
        dh.historico_id,
        dh.tipo_evento,
        dh.fecha_evento,
        dh.observaciones,
        dh.tratamiento,
        dh.medicamentos,
        dh.dosis,
        dh.veterinario_id,
        dh.peso_animal,
        dh.temperatura,
        dh.cobrado,
        dh.costo,
        h.animal_id,
        a.nombre as animal_nombre,
        CASE 
            WHEN dh.veterinario_id IS NOT NULL 
            THEN CONCAT(pf.nombre, ' ', pf.apellido)
            ELSE 'Sin asignar'
        END as veterinario_nombre,
        CASE
            WHEN dh.veterinario_id IS NOT NULL
            THEN pv.especialidad
            ELSE ''
        END as veterinario_especialidad
    FROM detalle_historico dh
    INNER JOIN historico h ON dh.historico_id = h.id
    INNER JOIN animal a ON h.animal_id = a.id
    LEFT JOIN personal p ON dh.veterinario_id = p.id
    LEFT JOIN persona pe ON p.id = pe.id
    LEFT JOIN persona_fisica pf ON pe.id = pf.id
    LEFT JOIN personal_veterinario pv ON p.id = pv.id
    WHERE dh.id = @id;
END
GO

PRINT 'Procedimientos almacenados para Detalle Historial creados exitosamente';
