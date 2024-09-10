# Proyecto PrimerParcial1C2024 - UNLAM PW3

Este proyecto es una aplicación web desarrollada con tecnología **.NET** y **C#**. El proyecto está diseñado para ser ejecutado en un entorno de desarrollo .NET y ofrece funcionalidad web básica.

## Requisitos previos

Para ejecutar este proyecto necesitarás tener instalados los siguientes elementos:

- **Visual Studio 2022** (o superior) con soporte para **ASP.NET y C#**. Puedes descargarlo desde [Visual Studio](https://visualstudio.microsoft.com/).
- **.NET SDK 6.0** o superior. Descárgalo desde [aquí](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
- **SQL Server** o una base de datos compatible (si se requiere en el proyecto).

## Instrucciones para ejecutar el proyecto

### Paso 1: Clonar o descargar el proyecto

1. Si tienes Git instalado, clona este repositorio usando el siguiente comando:

   ```bash
   git clone https://github.com/MadelaineDiLauro22/PrimerParcial1C2024-UNLAM-PW3.git
   ```

   Si no tienes Git, descarga el proyecto en formato `.zip` desde el botón **Download ZIP** en GitHub y descomprímelo en tu computadora.

### Paso 2: Abrir el proyecto en Visual Studio

1. Abre **Visual Studio**.
2. Haz clic en **Open a Project or Solution** (Abrir un proyecto o solución).
3. Navega a la carpeta donde descargaste o clonaste el proyecto y selecciona el archivo de solución `.sln`.
4. Visual Studio cargará el proyecto con su configuración predeterminada.

### Paso 3: Ejecutar el proyecto

1. Asegúrate de que la solución esté seleccionada como **Proyecto de inicio**. Si no lo está, haz clic derecho sobre la solución en el **Explorador de Soluciones** y selecciona **Set as StartUp Project**.
2. Haz clic en el botón **Run** o presiona `F5` para compilar y ejecutar el proyecto.
3. Si el proyecto tiene dependencias de base de datos, asegúrate de que el **SQL Server** esté configurado y corriendo.

### Paso 4: Acceder a la aplicación web

1. Una vez que el proyecto esté ejecutándose, el navegador se abrirá automáticamente.
2. Si no es así, abre el navegador manualmente y navega a la dirección predeterminada que generalmente será:

   ```
   https://localhost:5001/
   ```

3. A partir de aquí, podrás interactuar con la aplicación web desarrollada.

## Estructura del Proyecto

- `Controllers/`: Contiene los controladores de la aplicación.
- `Models/`: Contiene los modelos de datos utilizados.
- `Views/`: Carpeta que almacena las vistas de la aplicación.
- `wwwroot/`: Carpeta que contiene archivos estáticos como CSS, JavaScript e imágenes.
- `appsettings.json`: Archivo de configuración del proyecto.

## Modificar el Código

1. Abre los archivos del proyecto en **Visual Studio**.
2. Modifica cualquier parte del código (C#, HTML, CSS, etc.) según lo que desees cambiar.
3. Guarda los cambios y vuelve a ejecutar el proyecto para ver los resultados actualizados.

## Herramientas recomendadas

- **Visual Studio 2022**: [Descargar aquí](https://visualstudio.microsoft.com/).
- **.NET SDK 6.0**: Asegúrate de que esté instalado para compilar y ejecutar el proyecto.
- **SQL Server** (si se necesita base de datos): [Descargar aquí](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).
