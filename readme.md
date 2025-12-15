## Requisitos previos:
- .NET 9.0
- Docker Desktop

# InsightFlow-users-service

Sistema de gestión de usuarios. Este servicio forma parte de la arquitectura de servicios con despliegue continuo de InsightFlow

## Arquitectura y Patrón de Diseño

### Arquitectura: Servicios con despliegue continuo


### Patrones de Diseño Implementados:

1. **Dependency Injection:** Inyección de dependencias 
2. **Data Transfer Object (DTO):** Transferencia de datos entre capas
3. **Soft Delete Pattern:** Eliminación lógica para auditoría

## Instalación
1.- Primero debemos abrir la consola de comandos apretando las siguientes teclas y escribir 'cmd':

- "Windows + R" y escribimos 'cmd'

2.- Ahora debemos crear una carpeta en donde guardar el proyecto, esta carpeta puede estar donde desee el usuario:
```bash
mkdir [NombreDeCarpeta]
```
3.- Accedemoss a la carpeta.
```bash
cd NombreDeCarpeta
```
4.- Se debe clonar el repositorio en el lugar deseado por el usuario con el siguiente comando:
```bash
git clone https://github.com/bxnjadev/insightflow-documents
```
5.- Accedemos a la carpeta creada por el repositorio:
```bash
cd insightFlow-users-service
```
6.- Ahora debemos restaurar las dependencias del proyecto con el siguiente comando:
```bash
dotnet restore
```
7.- Con las dependencias restauradas, abrimos el editor:
```bash
code .
```
8.- Finalmente ya en el editor ejecutamos el siguiente comando para ejecutar el proyecto:
```bash
dotnet run
```

## Estructura del repositorio
- Funciona con una API de tipo REST
- Se ofrece un .env de con datos de ejemplo
- Se utiliza el Framework .NET de C#
- Se utiliza la ruta "http://localhost:5035" para realizar las peticiones HTTP