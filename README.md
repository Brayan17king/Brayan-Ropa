# Brayan-Ropa

### HttpGet:

###### General:

http://localhost:5071/api/Entity

###### URL:

- http://localhost:5071/api/Cargo

- http://localhost:5071/api/Cliente

- http://localhost:5071/api/Color

- http://localhost:5071/api/Departamento

- http://localhost:5071/api/DetalleOrden

- http://localhost:5071/api/DetalleVenta

- http://localhost:5071/api/Empleado

- http://localhost:5071/api/Empresa

- http://localhost:5071/api/Estado

- http://localhost:5071/api/FormaPago

- http://localhost:5071/api/Genero

- http://localhost:5071/api/Insumo

- http://localhost:5071/api/Inventario

- http://localhost:5071/api/Municipio

- http://localhost:50715071/api/Orden

- http://localhost:5071/api/Pais

- http://localhost:5071/api/Prenda

- http://localhost:5071/api/Proveedor

- http://localhost:5071/api/Talla

- http://localhost:5071/api/TipoEstado

- http://localhost:5071/api/TipoPersona

- http://localhost:5071/api/TipoProteccion

- http://localhost:5071/api/Venta

### HttpGetById y HttpDelete:

###### General:

http://localhost:5071/api/Entity/id

###### URL:

- http://localhost:5071/api/Cargo/1

- http://localhost:5071/api/Cliente/1

- http://localhost:5071/api/Color/1

- http://localhost:5071/api/Departamento/1

- http://localhost:5071/api/DetalleOrden/1

- http://localhost:5071/api/DetalleVenta/1

- http://localhost:5071/api/Empleado/1

- http://localhost:5071/api/Empresa/1

- http://localhost:5071/api/Estado/1

- http://localhost:5071/api/FormaPago/1

- http://localhost:5071/api/Genero/1

- http://localhost:5071/api/Insumo/1

- http://localhost:5071/api/Inventario/1

- http://localhost:5071/api/Municipio/1

- http://localhost:5071/api/Orden/1

- http://localhost:5071/api/Pais/1

- http://localhost:5071/api/Prenda/1

- http://localhost:5071/api/Proveedor/1

- http://localhost:5071/api/Talla/1

- http://localhost:5071/api/TipoEstado/1

- http://localhost:5071/api/TipoPersona/1

- http://localhost:5071/api/TipoProteccion/1

- http://localhost:5071/api/Venta/1

### HttpPost y HttpPut:

###### General:

Post: http://localhost:5071/Entity

Put: http://localhost:5071/Entity/id

###### LayOut:

Cargo:

- Post: http://localhost:5071/api/Cargo Put: http://localhost:5071/api/Cargo/1
  
  ```json
  {  
      "descripcion": "Vendedor", 
      "sueldoBase": 500
  }
  ```

- Post: http://localhost:5071/api/Cliente Put: http://localhost:5071/api/Cliente/1
  
  ```json
  {
    "idCliente": 1005108582,
    "nombreCliente": "brayan",
    "fechaRegistro": "2023-10-20",
    "idMunicipio": 1,
    "idTipoPersona": 1
  }
  ```

- Post: http://localhost:5071/api/Color Put: http://localhost:5071/api/Color/1
  
  ```json
  {
    "descripcionColor": "Morado"
  }
  ```

- Post: http://localhost:5071/api/Departamento Put: http://localhost:5071/api/Departamento/1
  
  ```json
  {
    "nombreDepartamento": "Santander",
    "idPais": 1
  }
  ```

- Post: http://localhost:5071/api/DetalleOrden Put: http://localhost:5071/api/DetalleOrden/1
  
  ```json
  {
    "cantidadProducir": 100,
    "cantidadProducida": 80,
    "idOrden": 1,
    "idPrenda": 1,
    "idColor": 1,
    "idEstado": 1
  }
  ```

- Post: http://localhost:5071/api/DetalleVenta Put: http://localhost:5071/api/DetalleVenta/1
  
  ```json
  {
    "cantidad": 100,
    "valorUnit": 10,
    "idVenta": 1,
    "idProducto": 1,
    "idTalla": 1
  }
  ```

- Post: http://localhost:5071/api/Empleado Put: http://localhost:5071/api/Empleado/1
  
  ```json
  {
    "idEmpleado": 1095791522,
    "nombreEmpleado": "Ale",
    "fechaIngreso": "2023-10-20",
    "idCargo": 1,
    "idMunicipio": 1
  }
  ```

- Post: http://localhost:5071/api/Empresa Put: http://localhost:5071/api/Empresa/1
  
  ```json
  {
    "nit": 4553534,
    "razonSocial": "Juridicial",
    "representanteLegal": "Juan Carlos",
    "fechaCreacion": "2023-10-20",
    "idMun": 1
  }
  ```

- Post: http://localhost:5071/api/Estado Put: http://localhost:5071/api/Estado/1
  
  ```json
  {
    "descripcion": "el asesino de dotnet",
    "idTipoEstado": 1
  }
  ```

- Post: http://localhost:5071/api/FormaPago Put: http://localhost:5071/api/FormaPago/1
  
  ```json
  {
    "descripcionPago": "Debito"
  }
  ```

- Post: http://localhost:5071/api/Genero Put: http://localhost:5071/api/Genero/1
  
  ```json
  {
    "descripcionGenero": "Femenino"
  }
  ```

- Post: http://localhost:5071/api/Insumo Put: http://localhost:5071/api/Insumo/1
  
  ```json
  {
    "nombreInsumo": "Jean",
    "valorUnit": 120000,
    "stockMin": 100,
    "stockMax": 300
  }
  ```

- Post: http://localhost:5071/api/Inventario Put: http://localhost:5071/api/Inventario/1
  
  ```json
  {
    "codInventario":123 ,
    "valorVtaCop": 45000,
    "valorVtaUsd": 10,
    "idPrenda": 1
  }
  ```

- Post: http://localhost:5071/api/Municipio Put: http://localhost:5071/api/Municipio/1
  
  ```json
  {
    "nombreMunicipio": "Bucaramanga",
    "idDep": 1
  }
  ```

- Post: http://localhost:5071/api/Orden Put: http://localhost:5071/api/Orden/1
  
  ```json
  {
    "fechaOrden": "2023-10-20",
    "idCliente": 1,
    "idEmpleado": 1,
    "idEstado": 1
  }
  ```

- Post: http://localhost:5071/api/Pais Put: http://localhost:5071/api/Pais/1
  
  ```json
  {
    "nombrePais": "Colombia"
  }
  ```

- Post: http://localhost:5071/api/Prenda Put: http://localhost:5071/api/Prenda/1
  
  ```json
  {
    "idPrenda": 789156564,
    "nombrePrenda": "Jean",
    "valorUnitCop": 25000,
    "valorUnitUsd": 6,
    "idEstado": 1,
    "idTipoProteccion": 1,
    "idGenero": 1
  }
  ```

- Post: http://localhost:5071/api/Proveedor Put: http://localhost:5071/api/Proveedor/1
  
  ```json
  {
    "nitProveedor": 456456,
    "nombreProveedor": "Jose Mario",
    "idTipoPersona": 1,
    "idMunicipio": 1
  }
  ```

- Post: http://localhost:5071/api/Talla Put: http://localhost:5071/api/Talla/1
  
  ```json
  {
    "descripcion": "B"
  }
  ```

- Post: http://localhost:5071/api/TipoEstado Put: http://localhost:5071/api/TipoEstado/1
  
  ```json
  {
    "descripcionTipoEstado": "Fuera de Servicio"
  }
  ```

- Post: http://localhost:5071/api/TipoPersona Put: http://localhost:5071/api/TipoPersona/1
  
  ```json
  {
    "nombrePersona": "Emprendedor"
  }
  ```

- Post: http://localhost:5071/api/TipoProteccion Put: http://localhost:5071/api/TipoProteccion/1
  
  ```json
  {
    "descripcion": "Buenisimo"
  }
  ```

- Post: http://localhost:5071/api/Venta Put: http://localhost:5071/api/Venta/1
  
  ```json
  {
    "fechaVenta": "2023-10-20",
    "idEmpleado": 1,
    "idCliente": 1,
    "idFormaPago": 1
  }
  ```