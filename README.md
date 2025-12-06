# Sistema Veterinario

Proyecto de gestión para una veterinaria que agrupa capa de datos, lógica de negocio y una interfaz de escritorio (WinForms). Está diseñado para administrar clientes, mascotas, inventario, ventas, historial clínico y reportes.

**Estado**: Código fuente en la rama `fusion-de-la-rama`. Proyecto Windows Forms orientado a .NET Framework 4.8 (proyectos con `TargetFramework` = `net48`).

**Contenido principal del repositorio**

- **`SistemVeterinario/`**: Aplicación de escritorio (WinForms). Contiene formularios, recursos y la interfaz del usuario.
- **`CapaDatos/`**: Acceso a base de datos; contiene clases de conexión y DAOs (`DPersona.cs`, `DMascotas.cs`, `Dventas.cs`, etc.).
- **`CapaNegocio/`**: Lógica de negocio y facades que consumen `CapaDatos` (`NPersona.cs`, `NMascotas.cs`, `Nventas.cs`, etc.).
- **`DatabaseMigrator/`**: Proyecto de consola para ejecutar migraciones/seeders de la base de datos.
- **`Sql/`**: Scripts de migración y seeders.
- **`docs/`**: Documentación de módulos (p. ej. `HISTORIAL_MODULE_DOCUMENTATION.md`).

**Tecnologías y dependencias**

- **Plataforma**: .NET Framework 4.8 (`net48`).
- **Lenguaje**: C# (con `LangVersion` 7.3 en los proyectos).
- **Paquetes relevantes**: `Microsoft.Data.SqlClient`, `Microsoft.ReportingServices.ReportViewerControl.WinForms`, `FontAwesome.Sharp`, `QRCoder`, entre otros (ver referencias en los `.csproj`).

**Estructura y flujo de ejecución**

- La UI en `SistemVeterinario` referencia `CapaNegocio`, que a su vez usa `CapaDatos` para interactuar con la base de datos.
- `DatabaseMigrator` suele usarse para crear/esquematizar la base de datos y ejecutar seeders antes de correr la aplicación.

**Cómo compilar y ejecutar**

1. Requisitos previos:
   - Visual Studio 2019/2022 con carga de desarrollo .NET de escritorio (WinForms) y soporte para .NET Framework 4.8.
   - SDK de .NET y MSBuild disponibles (si se usa `dotnet build`).

2. Abrir la solución:
   - Abrir `SistemVeterinario.sln` en Visual Studio.

3. Compilar desde Visual Studio:
   - Restaurar paquetes NuGet, compilar la solución y establecer `SistemVeterinario` como proyecto de inicio.

4. Compilar desde línea de comandos (PowerShell):

```
dotnet build .\SistemVeterinario.sln
```

5. Ejecutar migraciones (si aplica):

```
dotnet run --project .\DatabaseMigrator\DatabaseMigrator.csproj
```

6. Ejecutar la aplicación de escritorio:
   - Desde Visual Studio: F5 (o Ctrl+F5) con `SistemVeterinario` como proyecto de inicio.
   - Desde la carpeta `bin\Debug` del proyecto `SistemVeterinario` ejecutar el .exe generado.

**Configuración y conexión a BD**

- Revisar `App.config` dentro de `SistemVeterinario/` para la cadena de conexión y otros ajustes del entorno.
- Scripts y migraciones están en `Sql/migrations` y `Sql/seeders`.

**Notas de mantenimiento y recomendaciones**

- El diseño separa claramente la capa de datos (`CapaDatos`) y la lógica de negocio (`CapaNegocio`), facilitando pruebas y mantenimiento.
- Al actualizar paquetes, pruebe `DatabaseMigrator` y los flujos de creación de reportes (ReportViewer) porque son áreas sensibles a cambios de versión.
- Para migraciones a .NET 6+ o .NET 7/8, revise dependencias WinForms y `Microsoft.ReportingServices.ReportViewerControl.WinForms` por compatibilidad.

**Contacto / Autor**

Repositorio: `victusman/SistemaVeterinario` — mantener coordinación con el equipo para merges y despliegues.

---

Si quieres, puedo:
- Añadir badges (build/tests) al `README.md`.
- Incluir pasos detallados para la configuración local de la base de datos.
- Generar un `CONTRIBUTING.md` con normas para commits y ramas.

Indícame cuál de estas opciones quieres que añada a continuación.
