# InvoiceApp
---

Este es un proyecto de una aplicación de gestión de facturas construida con WinForms y .NET Core. La aplicación permite visualizar una lista de facturas, crear nuevas facturas y manejar los elementos de cada factura.

Además, utiliza un patrón MVP (Model-View-Presenter) y se conecta a una API mediante HTTP para crear y descargar facturas.

![](https://raw.githubusercontent.com/sergiolozav2/InvoiceApp/refs/heads/main/Demo/demo1.gif)

## Características
---
- Muestra de facturas
- Creación de facturas
- Actualización constante de facturas (polling)
- Descarga de facturas en PDF
- Validación de datos crear facturas
- Pruebas unitarias
- Arquitectura MVP (Model-View-Presenter)
- Manejo de errores

## Requisitos
---
- .NET Core 8.0 o superior
- API REST para gestión de facturas corriendo en http://localhost:5084

## Como ejecutar
---
- Clonar el repositorio
```bash
  git clone https://github.com/sergiolozav2/InvoiceApp
```
- Ingresar al directorio
```bash
  cd InvoiceApp
```
- Ejecutar con dotnet
```bash
  dotnet run
```

## Como ejecutar tests
---
- Ingresar al directorio
```bash
  cd InvoiceAppTests
```
- Ejecutar con dotnet
```bash
  dotnet test
```

## Arquitectura
---
Se utilizó el patrón MVP para diseñar esta aplicación y facilitar el desarrollo de tests.

### Componentes del Patrón MVP
1. Modelo:
   - Representa los datos y la información obtenida.
   - Es independiente de la vista.
   - Ejemplo: `Invoice.cs`, `Item.cs`, `RawItem.cs`.
2. Vista:
   - Se encarga de guardar el estado de datos que se muestra al usuario.
   - El presentador lo modifica según la lógica de negocio.
   - Ejemplo: `CreateInvoiceView.cs` y `InvoiceView.cs`.
2. Presentador:
   - Actúa como intermediario entre el modelo y la vista.
   - Contiene la lógica de la aplicación.
   - Ejemplo: `CreateInvoicePresenter.cs` y `InvoicePresenter.cs`.