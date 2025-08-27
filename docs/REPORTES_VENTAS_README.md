# DOCUMENTACIÓN REPORTES DE VENTAS
## Sistema Veterinario

### Reportes Implementados

#### 1. Resumen de Ventas (`rptVentasResumen.rdlc`)
- **Descripción**: Muestra un resumen agrupado por período (día, semana, mes, año)
- **Campos esperados**: `periodo`, `total_ventas`, `cantidad_facturas`
- **SP asociado**: `SP_ReporteVentasResumen`

#### 2. Ventas Detalladas (`rptVentasDetalle.rdlc`)
- **Descripción**: Listado detallado de todas las facturas en un rango de fechas
- **Campos esperados**: `fecha_emision`, `numero_factura`, `cliente`, `total`, `estado`
- **SP asociado**: `SP_ReporteVentasDetalle`

#### 3. Productos Más Vendidos (`rptVentasProductosTop.rdlc`)
- **Descripción**: Top de productos más vendidos con cantidades e ingresos
- **Campos esperados**: `producto_nombre`, `total_vendido`, `precio_promedio`, `total_ingresos`
- **SP asociado**: `SP_ReporteVentasProductosTop`

#### 4. Clientes Top (`rptVentasTopClientes.rdlc`)
- **Descripción**: Top de clientes con mayor volumen de compras
- **Campos esperados**: `cliente_nombre`, `total_facturas`, `promedio_compra`, `total_compras`
- **SP asociado**: `SP_ReporteVentasTopClientes`

#### 5. Estadísticas Generales (`rptVentasEstadisticas.rdlc`)
- **Descripción**: Métricas generales del sistema de ventas
- **Campos esperados**: `metrica`, `cantidad`, `valor`
- **SP asociado**: `SP_ReporteVentasEstadisticasGenerales`

### Parámetros de Reportes

#### Comunes a todos:
- `FechaInicio`: Fecha inicial del período
- `FechaFin`: Fecha final del período  
- `TipoReporte`: Tipo de reporte generado
- `FechaGeneracion`: Fecha y hora de generación

#### Específicos:
- `Periodo`: Tipo de agrupación (DIARIO, SEMANAL, MENSUAL, ANUAL)
- `TotalRegistros`: Cantidad de registros devueltos

### Configuración del Formulario

#### Tipos de Período:
- Diario → Agrupación por DIA
- Semanal → Agrupación por SEMANA  
- Mensual → Agrupación por MES
- Anual → Agrupación por AÑO

#### Rangos Predefinidos:
- Personalizado
- Hoy
- Últimos 7 días
- Últimos 30 días
- Mes actual
- Año actual
- Último mes
- Último año

### Funcionalidades Implementadas

✅ Generación de reportes por período
✅ Exportación a PDF, Excel y Word
✅ Vista previa e impresión
✅ Búsqueda y filtrado
✅ Validaciones de fechas
✅ Manejo de errores
✅ Modo genérico si no existe RDLC
✅ Configuración automática de parámetros
✅ Resúmenes y totales en reportes

### Notas Técnicas

1. Los archivos RDLC usan el DataSet `dsReporte`
2. Todos los reportes manejan formato de moneda en español (es-ES)
3. Los reportes incluyen encabezados, detalles y pies de página
4. Se implementó fallback a modo genérico si fallan los RDLC
5. Los parámetros se configuran automáticamente desde el formulario

### Posibles Mejoras Futuras

- Gráficos en reportes
- Filtros adicionales por estado, cliente, producto
- Reportes comparativos entre períodos
- Integración con dashboard
- Reportes programados/automáticos
- Envío por email

### Solución de Problemas

#### Error "No se encontraron datos":
- Verificar rango de fechas
- Comprobar conexión a BD
- Validar existencia de datos en el período

#### Error "Archivo RDLC no encontrado":
- El sistema usará modo genérico automáticamente
- Verificar ruta en `Application.StartupPath\Reportes`

#### Error de campos:
- Los campos del RDLC deben coincidir con los del SP
- Verificar nombres exactos en BD vs reporte
