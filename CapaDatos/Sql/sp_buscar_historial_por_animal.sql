-- Stored Procedure para buscar historiales por animal
-- Filename: sp_buscar_historial_por_animal.sql

USE Sistema_Veterinario;
GO

-- Eliminar el SP si ya existe
IF OBJECT_ID('sp_buscar_historial_por_animal', 'P') IS NOT NULL
    DROP PROCEDURE sp_buscar_historial_por_animal;
GO

CREATE PROCEDURE sp_buscar_historial_por_animal
    @animal_id INT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        -- Buscar historiales para el animal específico
        SELECT 
            h.id AS Id,
            h.animal_id AS AnimalId,
            COALESCE(m.nombre, 'Sin nombre') AS NombreMascota,
            COALESCE(m.especie, 'N/A') AS Especie,
            COALESCE(p.nombres + ' ' + p.apellidos, 'Sin propietario') AS Propietario,
            h.notas_generales AS NotasGenerales,
            h.alergias AS Alergias,
            h.condiciones_medicas AS CondicionesMedicas,
            h.created_at AS FechaCreacion,
            h.updated_at AS UltimaActualizacion,
            COUNT(dh.id) AS CantidadDetalles
        FROM historico h
        LEFT JOIN mascotas m ON h.animal_id = m.id
        LEFT JOIN persona p ON m.propietario_id = p.id
        LEFT JOIN detalle_historico dh ON h.id = dh.historial_id
        WHERE h.animal_id = @animal_id
        GROUP BY 
            h.id, h.animal_id, m.nombre, m.especie, 
            p.nombres, p.apellidos, h.notas_generales, 
            h.alergias, h.condiciones_medicas, 
            h.created_at, h.updated_at
        ORDER BY h.created_at DESC;
        
    END TRY
    BEGIN CATCH
        -- En caso de error, lanzar excepción
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END
GO

-- Ejecutar el stored procedure para verificar que funciona
PRINT 'Stored procedure sp_buscar_historial_por_animal creado exitosamente.';
