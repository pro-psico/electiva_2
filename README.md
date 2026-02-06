# 📌 API de Gestión de Tareas – ASP.NET Core

Este proyecto es una **API REST desarrollada en ASP.NET Core** que permite gestionar tareas de forma simple y eficiente.  
Soporta las operaciones básicas de **crear, consultar, editar y eliminar tareas**, almacenándolas **en memoria** (sin base de datos), ideal para fines académicos y pruebas de conceptos de backend.

---

## 🚀 Funcionalidades principales

- Crear tareas con título, descripción y estado  
- Consultar todas las tareas existentes  
- Editar tareas por ID  
- Eliminar tareas  
- Persistencia temporal en memoria (sin base de datos)  
- Pruebas completas mediante **Postman**

---

## 🛠️ Tecnologías usadas

- **ASP.NET Core Web API**
- **C#**
- **Postman**
- Arquitectura basada en **Controller + Services + Models**

---

## 📂 Estructura del proyecto

```
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
```

---

## ▶️ Cómo ejecutar el proyecto

### 1️⃣ Requisitos
- .NET SDK 6 o superior
- Visual Studio o VS Code
- Postman

Verifica instalación:
```bash
dotnet --version
```

---

### 2️⃣ Ejecutar la API
Desde la carpeta del proyecto:

```bash
dotnet restore
dotnet run
```

La API quedará disponible en una URL similar a:

```
https://localhost:5001
http://localhost:5000
```

---

## 🧪 Pruebas de la API con Postman

### 🔹 Crear tarea (POST)
```
POST /api/tareas
```

```json
{
  "titulo": "Aprender ASP.NET",
  "descripcion": "Crear una API REST",
  "estado": "pendiente"
}
```

---

### 🔹 Ver todas las tareas (GET)
```
GET /api/tareas
```

---

### 🔹 Editar tarea (PUT)
```
PUT /api/tareas/{id}
```

```json
{
  "titulo": "ASP.NET dominado",
  "descripcion": "API completada",
  "estado": "completada"
}
```

---

### 🔹 Eliminar tarea (DELETE)
```
DELETE /api/tareas/{id}
```

---

## 🧠 Almacenamiento en memoria

- Uso de lista en memoria
- No usa base de datos
- Los datos se pierden al reiniciar la aplicación

---

## ✅ Buenas prácticas

- Separación de capas
- Uso de interfaces
- Endpoints REST claros
- Código limpio y mantenible

---

## 📌 Nota final

Proyecto académico que demuestra el uso correcto de una API REST en ASP.NET Core con pruebas completas y documentación clara.

