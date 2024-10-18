# InvoiceApp
---

Este es un proyecto de una aplicaci�n de gesti�n de facturas construida con WinForms y .NET Core. La aplicaci�n permite visualizar una lista de facturas, crear nuevas facturas y manejar los elementos de cada factura.

Adem�s, utiliza un patr�n MVP (Model-View-Presenter) y se conecta a una API mediante HTTP para crear y descargar facturas.

![](https://raw.githubusercontent.com/sergiolozav2/InvoiceApp/refs/heads/main/Demo/demo1.gif)

## Caracter�sticas
---
- Muestra de facturas
- Creaci�n de facturas
- Actualizaci�n constante de facturas (polling)
- Descarga de facturas en PDF
- Validaci�n de datos crear facturas
- Pruebas unitarias
- Arquitectura MVP (Model-View-Presenter)
- Manejo de errores

## Requisitos
---
- .NET Core 8.0 o superior
- API REST para gesti�n de facturas corriendo en http://localhost:5084

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
Se utiliz� el patr�n MVP para dise�ar esta aplicaci�n y facilitar el desarrollo de tests.

### Componentes del Patr�n MVP
1. Modelo:
   - Representa los datos y la informaci�n obtenida.
   - Es independiente de la vista.
   - Ejemplo: `Invoice.cs`, `Item.cs`, `RawItem.cs`.
2. Vista:
   - Se encarga de guardar el estado de datos que se muestra al usuario.
   - El presentador lo modifica seg�n la l�gica de negocio.
   - Ejemplo: `CreateInvoiceView.cs` y `InvoiceView.cs`.
2. Presentador:
   - Act�a como intermediario entre el modelo y la vista.
   - Contiene la l�gica de la aplicaci�n.
   - Ejemplo: `CreateInvoicePresenter.cs` y `InvoicePresenter.cs`.