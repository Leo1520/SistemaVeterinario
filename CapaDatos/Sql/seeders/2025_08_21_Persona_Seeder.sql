-- =============================================
-- Script: 2025_08_21_Persona_Seeder.sql
-- Descripción: Seeder para personas físicas y jurídicas con datos bolivianos
-- Fecha: 21 de agosto de 2025
-- Autor: Sistema Veterinario
-- =============================================

USE [Sistema_Veterinario] -- Cambiar por el nombre de su base de datos
GO

-- =============================================
-- PERSONAS FÍSICAS (10 registros)
-- =============================================

PRINT 'Insertando Personas Físicas...'

-- Persona Física 1
EXEC SP01_CreateOrUpdatePFisica
    @ci = '12345678',
    @nombre = 'Maria Elena',
    @apellido = 'Quispe Mamani',
    @email = 'maria.quispe@gmail.com',
    @direccion = 'Av. Buenos Aires #1234, Zona Sur',
    @telefono = '78123456',
    @fecha_nacimiento = '1985-03-15',
    @genero = 'F';

-- Persona Física 2
EXEC SP01_CreateOrUpdatePFisica
    @ci = '23456789',
    @nombre = 'Carlos Alberto',
    @apellido = 'Mamani Condori',
    @email = 'carlos.mamani@hotmail.com',
    @direccion = 'Calle Comercio #567, El Alto',
    @telefono = '69876543',
    @fecha_nacimiento = '1978-11-22',
    @genero = 'M';

-- Persona Física 3
EXEC SP01_CreateOrUpdatePFisica
    @ci = '34567890',
    @nombre = 'Ana Lucia',
    @apellido = 'Vargas Flores',
    @email = 'ana.vargas@yahoo.com',
    @direccion = 'Av. 6 de Agosto #890, San Pedro',
    @telefono = '72345678',
    @fecha_nacimiento = '1992-07-08',
    @genero = 'F';

-- Persona Física 4
EXEC SP01_CreateOrUpdatePFisica
    @ci = '45678901',
    @nombre = 'Roberto',
    @apellido = 'Choque Apaza',
    @email = 'roberto.choque@gmail.com',
    @direccion = 'Calle Murillo #123, Centro',
    @telefono = '65432109',
    @fecha_nacimiento = '1980-12-03',
    @genero = 'M';

-- Persona Física 5
EXEC SP01_CreateOrUpdatePFisica
    @ci = '56789012',
    @nombre = 'Patricia',
    @apellido = 'Torrez Limachi',
    @email = 'patricia.torrez@outlook.com',
    @direccion = 'Av. América #456, Miraflores',
    @telefono = '76543210',
    @fecha_nacimiento = '1987-05-18',
    @genero = 'F';

-- Persona Física 6
EXEC SP01_CreateOrUpdatePFisica
    @ci = '67890123',
    @nombre = 'Luis Fernando',
    @apellido = 'Gutierrez Poma',
    @email = 'luis.gutierrez@gmail.com',
    @direccion = 'Calle Sagarnaga #789, Rosario',
    @telefono = '71234567',
    @fecha_nacimiento = '1975-09-25',
    @genero = 'M';

-- Persona Física 7
EXEC SP01_CreateOrUpdatePFisica
    @ci = '78901234',
    @nombre = 'Silvia',
    @apellido = 'Mendoza Cruz',
    @email = 'silvia.mendoza@hotmail.com',
    @direccion = 'Av. Ballivián #321, Calacoto',
    @telefono = '68901234',
    @fecha_nacimiento = '1990-02-14',
    @genero = 'F';

-- Persona Física 8
EXEC SP01_CreateOrUpdatePFisica
    @ci = '89012345',
    @nombre = 'Juan Carlos',
    @apellido = 'Huanca Ticona',
    @email = 'juan.huanca@yahoo.com',
    @direccion = 'Calle Ayacucho #654, Sopocachi',
    @telefono = '77890123',
    @fecha_nacimiento = '1983-08-07',
    @genero = 'M';

-- Persona Física 9
EXEC SP01_CreateOrUpdatePFisica
    @ci = '90123456',
    @nombre = 'Carmen Rosa',
    @apellido = 'Chipana Yujra',
    @email = 'carmen.chipana@gmail.com',
    @direccion = 'Av. Arce #987, San Jorge',
    @telefono = '73456789',
    @fecha_nacimiento = '1988-04-12',
    @genero = 'F';

-- Persona Física 10
EXEC SP01_CreateOrUpdatePFisica
    @ci = '01234567',
    @nombre = 'Miguel Angel',
    @apellido = 'Colque Mamani',
    @email = 'miguel.colque@outlook.com',
    @direccion = 'Calle Linares #147, Centro',
    @telefono = '74567890',
    @fecha_nacimiento = '1979-01-30',
    @genero = 'M';

PRINT 'Personas Físicas insertadas correctamente.'

-- =============================================
-- PERSONAS JURÍDICAS (20 registros)
-- =============================================

PRINT 'Insertando Personas Jurídicas...'

-- Persona Jurídica 1
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Veterinaria San Francisco SRL',
    @nit = '1020304050',
    @encargado_nombre = 'Dr. Eduardo Mamani',
    @encargado_cargo = 'Director Veterinario',
    @email = 'info@vetsanfrancisco.bo',
    @direccion = 'Av. 6 de Agosto #1250, La Paz',
    @telefono = '22451234';

-- Persona Jurídica 2
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Clínica Veterinaria Esperanza',
    @nit = '2030405060',
    @encargado_nombre = 'Dra. Carmen Quispe',
    @encargado_cargo = 'Gerente General',
    @email = 'contacto@veterinariaesperanza.com',
    @direccion = 'Calle Comercio #890, El Alto',
    @telefono = '28901234';

-- Persona Jurídica 3
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Pet Shop Los Amigos EIRL',
    @nit = '3040506070',
    @encargado_nombre = 'Carlos Vargas',
    @encargado_cargo = 'Propietario',
    @email = 'ventas@petshopamigos.bo',
    @direccion = 'Av. Heroínas #567, Cochabamba',
    @telefono = '44123456';

-- Persona Jurídica 4
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Distribuidora Agroveterinaria Bolivia',
    @nit = '4050607080',
    @encargado_nombre = 'Ana Torrez',
    @encargado_cargo = 'Gerente de Ventas',
    @email = 'distribucion@agrovet.com.bo',
    @direccion = 'Zona Industrial, Villa El Carmen, Santa Cruz',
    @telefono = '33789012';

-- Persona Jurídica 5
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Centro Veterinario Paws & Claws',
    @nit = '5060708090',
    @encargado_nombre = 'Dr. Roberto Choque',
    @encargado_cargo = 'Veterinario Jefe',
    @email = 'consultas@pawsandclaws.bo',
    @direccion = 'Av. América #234, Miraflores, La Paz',
    @telefono = '22567890';

-- Persona Jurídica 6
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Laboratorio Veterinario del Altiplano',
    @nit = '6070809000',
    @encargado_nombre = 'Dra. Patricia Mendoza',
    @encargado_cargo = 'Directora Técnica',
    @email = 'laboratorio@vetaltiplano.com',
    @direccion = 'Calle Potosí #123, La Paz',
    @telefono = '22345678';

-- Persona Jurídica 7
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Granja Avícola San Martín',
    @nit = '7080900010',
    @encargado_nombre = 'Luis Gutierrez',
    @encargado_cargo = 'Gerente de Producción',
    @email = 'produccion@granjasanmartin.bo',
    @direccion = 'Km 15 Carretera a Oruro, La Paz',
    @telefono = '22901234';

-- Persona Jurídica 8
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Veterinaria Tropical Santa Cruz',
    @nit = '8090001020',
    @encargado_nombre = 'Dra. Silvia Huanca',
    @encargado_cargo = 'Propietaria',
    @email = 'info@vettropical.com',
    @direccion = 'Av. Banzer #789, Santa Cruz',
    @telefono = '33456789';

-- Persona Jurídica 9
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Importadora de Medicamentos Veterinarios SRL',
    @nit = '9000102030',
    @encargado_nombre = 'Juan Carlos Chipana',
    @encargado_cargo = 'Director Comercial',
    @email = 'importaciones@medvet.bo',
    @direccion = 'Zona Franca, El Alto, La Paz',
    @telefono = '28123456';

-- Persona Jurídica 10
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Clínica Veterinaria del Valle',
    @nit = '0010203040',
    @encargado_nombre = 'Carmen Colque',
    @encargado_cargo = 'Administradora',
    @email = 'atencion@vetvalle.com',
    @direccion = 'Av. Libertador #456, Tarija',
    @telefono = '46678901';

-- Persona Jurídica 11
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Cooperativa Ganadera Altiplano',
    @nit = '1020304051',
    @encargado_nombre = 'Miguel Angel Mamani',
    @encargado_cargo = 'Presidente',
    @email = 'cooperativa@ganaderaltiplano.bo',
    @direccion = 'Plaza Principal, Patacamaya, La Paz',
    @telefono = '22234567';

-- Persona Jurídica 12
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Pet Care Center Sucre',
    @nit = '2030405061',
    @encargado_nombre = 'Ana Maria Vargas',
    @encargado_cargo = 'Gerente',
    @email = 'cuidados@petcaresucre.com',
    @direccion = 'Calle España #234, Sucre',
    @telefono = '46445566';

-- Persona Jurídica 13
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Alimentos Balanceados del Oriente',
    @nit = '3040506071',
    @encargado_nombre = 'Roberto Torrez',
    @encargado_cargo = 'Jefe de Producción',
    @email = 'ventas@alimentosoriente.bo',
    @direccion = 'Parque Industrial, Santa Cruz',
    @telefono = '33789123';

-- Persona Jurídica 14
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Veterinaria Andina Potosí',
    @nit = '4050607081',
    @encargado_nombre = 'Patricia Cruz',
    @encargado_cargo = 'Veterinaria Principal',
    @email = 'consultas@vetandina.com',
    @direccion = 'Av. Universitaria #567, Potosí',
    @telefono = '26223344';

-- Persona Jurídica 15
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Hacienda Ganadera La Esperanza',
    @nit = '5060708091',
    @encargado_nombre = 'Luis Fernando Mendoza',
    @encargado_cargo = 'Administrador',
    @email = 'hacienda@esperanza.com.bo',
    @direccion = 'Provincia Warnes, Santa Cruz',
    @telefono = '33556677';

-- Persona Jurídica 16
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Clínica Veterinaria Beni',
    @nit = '6070809001',
    @encargado_nombre = 'Silvia Gutierrez',
    @encargado_cargo = 'Directora',
    @email = 'clinica@vetbeni.bo',
    @direccion = 'Av. Mamoré #123, Trinidad, Beni',
    @telefono = '36778899';

-- Persona Jurídica 17
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Distribuidora de Insumos Pecuarios',
    @nit = '7080900011',
    @encargado_nombre = 'Juan Huanca',
    @encargado_cargo = 'Gerente de Distribución',
    @email = 'distribuidora@pecuarios.bo',
    @direccion = 'Av. Circunvalación #789, Cochabamba',
    @telefono = '44112233';

-- Persona Jurídica 18
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Centro de Investigación Veterinaria UMSA',
    @nit = '8090001021',
    @encargado_nombre = 'Dra. Carmen Chipana',
    @encargado_cargo = 'Directora de Investigación',
    @email = 'investigacion@umsa.edu.bo',
    @direccion = 'Campus Universitario, Cota Cota, La Paz',
    @telefono = '22345567';

-- Persona Jurídica 19
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Farmacia Veterinaria Central',
    @nit = '9000102031',
    @encargado_nombre = 'Miguel Colque',
    @encargado_cargo = 'Farmacéutico Responsable',
    @email = 'farmacia@vetcentral.com',
    @direccion = 'Calle Ayacucho #345, La Paz',
    @telefono = '22667788';

-- Persona Jurídica 20
EXEC SP02_CreateOrUpdatePJuridica
    @razon_social = 'Servicios Veterinarios Móviles Bolivia',
    @nit = '0010203041',
    @encargado_nombre = 'Ana Rosa Mamani',
    @encargado_cargo = 'Coordinadora de Servicios',
    @email = 'servicios@vetmovil.bo',
    @direccion = 'Av. del Ejército #678, La Paz',
    @telefono = '22889900';

PRINT 'Personas Jurídicas insertadas correctamente.'

-- =============================================
-- VERIFICACIÓN DE DATOS INSERTADOS
-- =============================================

PRINT 'Verificando datos insertados...'

-- Contar personas físicas
DECLARE @CountFisicas INT
SELECT @CountFisicas = COUNT(*)
FROM persona p 
INNER JOIN persona_fisica pf ON p.id = pf.id
WHERE p.activo = 1

PRINT 'Total de Personas Físicas insertadas: ' + CAST(@CountFisicas AS VARCHAR(10))

-- Contar personas jurídicas
DECLARE @CountJuridicas INT
SELECT @CountJuridicas = COUNT(*)
FROM persona p 
INNER JOIN persona_juridica pj ON p.id = pj.id
WHERE p.activo = 1

PRINT 'Total de Personas Jurídicas insertadas: ' + CAST(@CountJuridicas AS VARCHAR(10))

-- Mostrar resumen
SELECT 
    'Física' AS TipoPersona,
    COUNT(*) AS Cantidad
FROM persona p 
INNER JOIN persona_fisica pf ON p.id = pf.id
WHERE p.activo = 1

UNION ALL

SELECT 
    'Jurídica' AS TipoPersona,
    COUNT(*) AS Cantidad
FROM persona p 
INNER JOIN persona_juridica pj ON p.id = pj.id
WHERE p.activo = 1

PRINT 'Seeder ejecutado exitosamente.'
PRINT 'Fecha de ejecución: ' + CONVERT(VARCHAR(20), GETDATE(), 120)

-- =============================================
-- FIN DEL SCRIPT
-- =============================================
