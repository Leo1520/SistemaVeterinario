-- Script para insertar datos de prueba en la tabla diagnostico
-- Sistema Veterinario - Datos de ejemplo para diagnósticos

INSERT INTO diagnostico (codigo, nombre, descripcion, precio_base, categoria_diagnostico, requiere_equipamiento, activo) VALUES
('DG001', 'Examen General', 'Revisión física completa del animal', 50.00, 'Consulta General', 0, 1),
('DG002', 'Análisis de Sangre', 'Examen completo de sangre para detectar enfermedades', 75.00, 'Laboratorio', 1, 1),
('DG003', 'Radiografía', 'Radiografía para diagnóstico por imagen', 120.00, 'Diagnóstico por Imagen', 1, 1),
('DG004', 'Ultrasonido', 'Ecografía para diagnóstico interno', 100.00, 'Diagnóstico por Imagen', 1, 1),
('DG005', 'Vacunación Múltiple', 'Aplicación de vacunas preventivas', 30.00, 'Prevención', 0, 1),
('DG006', 'Desparasitación', 'Tratamiento antiparasitario interno y externo', 25.00, 'Prevención', 0, 1),
('DG007', 'Cirugía Menor', 'Procedimiento quirúrgico ambulatorio', 200.00, 'Cirugía', 1, 1),
('DG008', 'Cirugía Mayor', 'Procedimiento quirúrgico complejo', 500.00, 'Cirugía', 1, 1),
('DG009', 'Consulta Dermatológica', 'Evaluación especializada de problemas de piel', 80.00, 'Especialidad', 0, 1),
('DG010', 'Consulta Cardiológica', 'Evaluación del sistema cardiovascular', 90.00, 'Especialidad', 1, 1),
('DG011', 'Limpieza Dental', 'Profilaxis dental y tratamiento periodontal', 60.00, 'Odontología', 1, 1),
('DG012', 'Extracción Dental', 'Procedimiento de extracción de piezas dentales', 80.00, 'Odontología', 1, 1),
('DG013', 'Castración/Esterilización', 'Procedimiento de esterilización quirúrgica', 150.00, 'Cirugía', 1, 1),
('DG014', 'Emergencia 24h', 'Atención de emergencia fuera de horario', 120.00, 'Emergencia', 0, 1),
('DG015', 'Internación', 'Hospitalización y cuidados intensivos', 80.00, 'Hospitalización', 1, 1);

-- Verificar que se insertaron correctamente
SELECT COUNT(*) as 'Total Diagnósticos Insertados' FROM diagnostico WHERE activo = 1;

-- Mostrar algunos registros de ejemplo
SELECT TOP 5 id, codigo, nombre, categoria_diagnostico, precio_base FROM diagnostico ORDER BY id;
