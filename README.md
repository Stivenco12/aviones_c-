# Juego de Aviones en C#

Este proyecto es un juego desarrollado en C# utilizando Windows Forms. Permite controlar un avión y disparar a enemigos en pantalla mediante una interfaz gráfica interactiva.

## Estructura del Proyecto

El proyecto está organizado en los siguientes archivos y carpetas:

- `avienes guerra.sln`: Archivo de solución para abrir el proyecto en Visual Studio.
- `avienes guerra/`: Carpeta principal que contiene los archivos del juego.
  - `Program.cs`: Archivo principal que inicia la aplicación y establece el formulario principal.
  - `Form1.cs`: Contiene la lógica del juego, incluyendo el movimiento del avión y la detección de colisiones.
  - `Form1.Designer.cs`: Código generado automáticamente que define la interfaz gráfica.
  - `Form1.resx`: Archivo de recursos asociado al formulario.
  - `Properties/`: Configuraciones del proyecto.
    - `AssemblyInfo.cs`: Define metadatos del ensamblado.
    - `Resources.Designer.cs` y `Resources.resx`: Manejan recursos gráficos y sonidos.
    - `Settings.Designer.cs` y `Settings.settings`: Contienen configuraciones del usuario.
  - `Resources/`: Carpeta con imágenes del juego.
    - `bullet.png`: Imagen de la bala disparada por el jugador.
    - `enemy.png`: Imagen del avión enemigo.
    - `player.png`: Imagen del avión controlado por el usuario.
  - `bin/Debug/`: Contiene el ejecutable (`avienes guerra.exe`) y archivos de configuración.
  - `obj/Debug/`: Archivos temporales generados durante la compilación.

## Requisitos

Para ejecutar o modificar este proyecto, necesitas:

- Visual Studio con soporte para .NET Framework 4.7.2 o superior.
- Windows como sistema operativo para ejecutar el juego.
- Conocimientos básicos de C# y Windows Forms para personalizar la funcionalidad.

## Instalación y Uso

### Instalación

1. Clonar o descargar el repositorio.
2. Abrir `avienes guerra.sln` en Visual Studio.
3. Restaurar paquetes NuGet si es necesario.
4. Compilar y ejecutar el proyecto.

### Uso

1. Ejecutar `avienes guerra.exe`.
2. Controlar el avión con las teclas de dirección.
3. Disparar con la tecla `Espacio`.
4. Evitar colisiones con los enemigos.
5. Acumular puntos eliminando enemigos.

## Funcionalidades

- Movimiento fluido del avión con el teclado.
- Disparo de balas al presionar la barra espaciadora.
- Detección de colisiones con enemigos.
- Uso de imágenes para representar los elementos del juego.

## Posibles Mejoras

- Implementar niveles de dificultad.
- Agregar sonidos y efectos visuales.
- Mejorar la detección de colisiones.
- Incluir un sistema de puntajes con almacenamiento.

## Desarrollador = Stiven

## Contacto

Num = +57 318 3164638

Email = [jestcoam@gmail.com](mailto:jestcoam@gmail.com)

