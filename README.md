📌 API de Gestión de Tareas – ASP.NET Core

Este proyecto es una API REST desarrollada en ASP.NET Core que permite gestionar tareas de forma simple y eficiente.
Soporta las operaciones básicas de crear, consultar, editar y eliminar tareas, almacenándolas en memoria (sin base de datos), ideal para fines académicos y pruebas de conceptos de backend.

🚀 Funcionalidades principales

Crear tareas con título, descripción y estado

Consultar todas las tareas existentes

Editar tareas por ID

Eliminar tareas

Persistencia temporal en memoria (sin base de datos)

Pruebas completas mediante Postman

🛠️ Tecnologías usadas

ASP.NET Core Web API

C#

Postman (para pruebas de endpoints)

Arquitectura basada en Controller + Services + Models

📂 Estructura del proyecto
ProyectoElectiva2
│
├── Controllers
│   └── TareasController.cs
│
├── Models
│   └── TaskModel.cs
│
├── Services
│   ├── ITaskServices.cs
│   └── TaskServices.cs
│
└── Program.cs

▶️ Cómo ejecutar el proyecto
1️⃣ Requisitos

.NET SDK 6 o superior

Visual Studio o VS Code

Postman

Verifica instalación:

dotnet --version

2️⃣ Ejecutar la API

Desde la carpeta del proyecto:

dotnet restore
dotnet run


La API quedará disponible en una URL similar a:

https://localhost:5001
http://localhost:5000


(La URL exacta se muestra en la consola al ejecutar el proyecto).

🧪 Pruebas de la API con Postman
🔹 1. Crear tarea (POST)

Endpoint

POST /api/tareas


Body (JSON):

{
  "titulo": "Aprender ASP.NET",
  "descripcion": "Crear una API REST",
  "estado": "pendiente"
}

🔹 2. Ver todas las tareas (GET)

Endpoint

GET /api/tareas


Devuelve una lista con todas las tareas creadas.

🔹 3. Editar tarea (PUT)

Endpoint

PUT /api/tareas/{id}


Ejemplo:

PUT /api/tareas/1


Body (JSON):

{
  "titulo": "ASP.NET dominado",
  "descripcion": "API completada",
  "estado": "completada"
}

🔹 4. Eliminar tarea (DELETE)

Endpoint

DELETE /api/tareas/{id}


Ejemplo:

DELETE /api/tareas/1

🧠 Gestión del almacenamiento en memoria

Las tareas se almacenan en una lista en memoria

No se utiliza base de datos

Los datos se pierden al reiniciar la aplicación

La lógica está encapsulada en TaskServices, cumpliendo separación de responsabilidades

✅ Buenas prácticas aplicadas

Separación de capas (Controller / Service / Model)

Uso de interfaces para desacoplar lógica

Endpoints REST claros y coherentes

Código limpio y fácil de mantener

📌 Notas finales

Este proyecto cumple con los requisitos funcionales solicitados y demuestra el uso correcto de una API REST en ASP.NET Core, incluyendo pruebas de endpoints, manejo de datos en memoria y documentación clara para su ejecución y validación.
