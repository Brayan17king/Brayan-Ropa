using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private readonly RopaContext _context;

        private ICargo _Cargos;
        private ICliente _Clientes;
        private IColor _Colores;
        private IDepartamento _Departamentos;
        private IDetalleOrden _DetalleOrdenes;
        private IDetalleVenta _DetalleVentas;
        private IEmpleado _Empleados;
        private IEmpresa _Empresas;
        private IEstado _Estados;
        private IFormaPago _FormaPagos;
        private IGenero _Generos;
        private IInsumos _Insumos;
        private IInventario _Inventarios;
        private IMunicipio _Municipios;
        private IOrden _Ordenes;
        private IPais _Paises;
        private IPrenda _Prendas;
        private IProveedor _Proveedores;
        private ITalla _Tallas;
        private ITipoEstado _TipoEstados;
        private ITipoPersona _TipoPersonas;
        private ITipoProteccion _TipoProtecciones;
        private IVenta _Ventas;
        
        public UnitOfWork(RopaContext context)
        {
            _context = context;
        }

        public ICargo Cargos
        {
            get
            {
                if (_Cargos == null)
                {
                    _Cargos = new CargoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Cargos;
            }
        }

        public ICliente Clientes
        {
            get
            {
                if (_Clientes == null)
                {
                    _Clientes = new ClienteRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Clientes;
            }
        }

        public IColor Colores
        {
            get
            {
                if (_Colores == null)
                {
                    _Colores = new ColorRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Colores;
            }
        }

        public IDepartamento Departamentos
        {
            get
            {
                if (_Departamentos == null)
                {
                    _Departamentos = new DepartamentoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Departamentos;
            }
        }

        public IDetalleOrden DetalleOrdenes
        {
            get
            {
                if (_DetalleOrdenes == null)
                {
                    _DetalleOrdenes = new DetalleOrdenRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _DetalleOrdenes;
            }
        }

        public IDetalleVenta DetalleVentas
        {
            get
            {
                if (_DetalleVentas == null)
                {
                    _DetalleVentas = new DetalleVentaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _DetalleVentas;
            }
        }

        public IEmpleado Empleados
        {
            get
            {
                if (_Empleados == null)
                {
                    _Empleados = new EmpleadoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Empleados;
            }
        }

        public IEmpresa Empresas
        {
            get
            {
                if (_Empresas == null)
                {
                    _Empresas = new EmpresaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Empresas;
            }
        }

        public IEstado Estados
        {
            get
            {
                if (_Estados == null)
                {
                    _Estados = new EstadoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Estados;
            }
        }

        public IFormaPago FormaPagos
        {
            get
            {
                if (_FormaPagos == null)
                {
                    _FormaPagos = new FormaPagoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _FormaPagos;
            }
        }
        public IGenero Generos
        {
            get
            {
                if (_Generos == null)
                {
                    _Generos = new GeneroRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Generos;
            }
        }

        public IInsumos Insumos
        {
            get
            {
                if (_Insumos == null)
                {
                    _Insumos = new InsumosRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Insumos;
            }
        }

        public IInventario Inventarios
        {
            get
            {
                if (_Inventarios == null)
                {
                    _Inventarios = new InventarioRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Inventarios;
            }
        }
        public IMunicipio Municipios
        {
            get
            {
                if (_Municipios == null)
                {
                    _Municipios = new MunicipioRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Municipios;
            }
        }

        public IOrden Ordenes
        {
            get
            {
                if (_Ordenes == null)
                {
                    _Ordenes = new OrdenRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Ordenes;
            }
        }

        public IPais Paises
        {
            get
            {
                if (_Paises == null)
                {
                    _Paises = new PaisRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Paises;
            }
        }
        public IPrenda Prendas
        {
            get
            {
                if (_Prendas == null)
                {
                    _Prendas = new PrendaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Prendas;
            }
        }
        public IProveedor Proveedores
        {
            get
            {
                if (_Proveedores == null)
                {
                    _Proveedores = new ProveedorRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Proveedores;
            }
        }
        public ITalla Tallas
        {
            get
            {
                if (_Tallas == null)
                {
                    _Tallas = new TallaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Tallas;
            }
        }
        public ITipoEstado TipoEstados
        {
            get
            {
                if (_TipoEstados == null)
                {
                    _TipoEstados = new TipoEstadoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _TipoEstados;
            }
        }
        public ITipoPersona TipoPersonas
        {
            get
            {
                if (_TipoPersonas == null)
                {
                    _TipoPersonas = new TipoPersonaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _TipoPersonas;
            }
        }
        public ITipoProteccion TipoProtecciones
        {
            get
            {
                if (_TipoProtecciones == null)
                {
                    _TipoProtecciones = new TipoProteccionRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _TipoProtecciones;
            }
        }
        public IVenta Ventas
        {
            get
            {
                if (_Ventas == null)
                {
                    _Ventas = new VentaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Ventas;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}