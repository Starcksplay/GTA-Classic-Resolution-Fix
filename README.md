GTA Classic Resolution Fix Wrapper

¿Qué hace?

Este wrapper soluciona el problema de inicio en Windows 10/11 donde GTA III, GTA Vice City y GTA San Andreas muestran errores como:

- "Cannot find 1920x1080x32 video mode"
- El juego queda ejecutándose en segundo plano sin abrir la ventana
- El juego no abre

El programa fuerza temporalmente el modo 640x480 durante el primer inicio y luego restaura la configuración normal.

Instalación

1. Cierra el juego si está abierto.

2. Abre la carpeta donde está instalado tu GTA.

3. Haz una copia de seguridad del ejecutable original.

4. Cambia el nombre del archivo original:

GTA San Andreas:

gta_sa.exe → gta_sa_real.exe

GTA Vice City:

gta-vc.exe → gta-vc_real.exe

GTA III:

gta3.exe → gta3_real.exe

(o como este escrito en tu carpeta)

5. Copia el archivo del wrapper en esa misma carpeta.

El wrapper debe tener el nombre original del juego:

gta_sa.exe
gta-vc.exe
gta3.exe

6. Inicia el juego normalmente desde tu launcher habitual.

Notas

- El archivo original del juego no se modifica.
- El wrapper necesita estar en la misma carpeta que el ejecutable real.
- La configuración de primera ejecución se guarda en:

Documentos\GTA Wrapper Fix

- Si quieres eliminar el fix, borra el wrapper y vuelve a cambiar:

gta_sa_real.exe → gta_sa.exe
gta-vc_real.exe → gta-vc.exe
gta3_real.exe → gta3.exe

-Si dejo de funcionar:

Anda a Documentos\GTA Wrapper Fix
borra los archivos y volve a intentar

Compatible con instalaciones modificadas que usan SilentPatch, CLEO, ModLoader y otros mods.
