using LogicaAccesoDatos.Excepciones;
using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.Excepciones;
using LogicaDeNegocio.Excepciones.MovimientoDeStock;
using LogicaDeNegocio.IntefacesServicios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientoDeStockController : ControllerBase
    {
        private IObtenerCantidadTotal<MovimientoDeStock> _cantidadDeMovimientos;
        private IAlta<MovimientoDeStock> _altaMovimiento;
        private IObtener<MovimientoDeStock> _obtenerMovimiento;
        private IObtenerTodosPaginado<MovimientoDeStock> _obtenerTodos;
        private IObtenerDosFiltros<MovimientoDeStock> _getAllXArtTipoPag;
        private IObtenerCantidadTotalDosFiltros<MovimientoDeStock> _cantidadDosFiltros;
        private IObtener<Articulo> _obtenerArticulo;
        private IObtener<TipoDeMovimiento> _obtenerTipo;
        private IObtenerDeString<Usuario> _obtenerUsuarioDesdeEmail;
        private IObtenerPorFecha<Articulo> _obtenerMovimientosPorFecha;
        private IObtenerCantidadPorFecha<Articulo> _cantidadPorFecha;
        private IObtenerResumen _obtenerResumen;

        public MovimientoDeStockController(IAlta<MovimientoDeStock> alta,
                                  IObtener<MovimientoDeStock> obtenerMovimiento,
                                  IObtenerTodosPaginado<MovimientoDeStock> obtenerTodos,
                                  IObtenerDosFiltros<MovimientoDeStock> getAllXArtTipoPag,
                                  IObtener<Articulo> obtenerArticulo,
                                  IObtener<TipoDeMovimiento> obtenerTipo,
                                  IObtener<Usuario> obtenerUsuario,
                                  IObtenerDeString<Usuario> obtenerUsuarioDesdeEmail,
                                  IObtenerPorFecha<Articulo> obtenerMovimientosPorFecha,
                                  IObtenerCantidadTotal<MovimientoDeStock> cantidadDeMovimientos,
                                  IObtenerCantidadTotalDosFiltros<MovimientoDeStock> cantidadDosFiltros,
                                  IObtenerCantidadPorFecha<Articulo> cantidadPorFecha,
                                  IObtenerResumen obtenerResumen)
        {
            _altaMovimiento = alta;
            _obtenerMovimiento = obtenerMovimiento;
            _obtenerTodos = obtenerTodos;
            _getAllXArtTipoPag = getAllXArtTipoPag;
            _obtenerArticulo = obtenerArticulo;
            _obtenerTipo = obtenerTipo;
           // _obtenerUsuario = obtenerUsuario;
            _obtenerUsuarioDesdeEmail = obtenerUsuarioDesdeEmail;
            _obtenerMovimientosPorFecha = obtenerMovimientosPorFecha;
            _cantidadDeMovimientos = cantidadDeMovimientos;
            _cantidadDosFiltros = cantidadDosFiltros;
            _cantidadPorFecha = cantidadPorFecha;
            _obtenerResumen = obtenerResumen;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        [HttpGet]
        public IActionResult GetAll(int page)
        {
            try
            {
                return Ok(_obtenerTodos.Ejecutar(page));

            }
            catch (NotFoundException e)
            {
                return StatusCode(204, e.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Contacte al administrador");
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        [HttpGet("GetResumen")]
        public IActionResult GetResumen()
        {
            try
            {
                return Ok(_obtenerResumen.Ejecutar());
            }
            catch (Exception)
            {
                return StatusCode(500, "Contacte al administrador");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        [HttpGet("GetCount")]
        public IActionResult GetCount()
        {
            try
            {
                return Ok(_cantidadDeMovimientos.Ejecutar());
            }catch (Exception)
            {
                return StatusCode(500, "Contacte al administrador");
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        [HttpGet("GetCountDosFiltros")]
        public IActionResult GetCountDosFiltros(int idArticulo, int idTipo)
        {
            try
            {
                return Ok(_cantidadDosFiltros.Ejecutar(idArticulo, idTipo));
            }
            catch (Exception)
            {
                return StatusCode(500, "Contacte al administrador");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        [HttpGet("GetCountPorFecha")]
        public IActionResult GetCountPorFecha(string desdestr, string hastastr)
        {
            try
            {
                var desde = DateTime.MinValue;
                var hasta = DateTime.MinValue;
                var okd = DateTime.TryParse(desdestr, out desde);
                var okh = DateTime.TryParse(hastastr, out hasta);

                return Ok(_cantidadPorFecha.Ejecutar(desde, hasta));
            }
            catch (Exception)
            {
                return StatusCode(500, "Contacte al administrador");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_obtenerMovimiento.Ejecutar(id));
            }
            catch (ArgumentNullRepositorioException e)
            {
                return StatusCode(400, e.Message);
            }
            catch (NotFoundException e)
            {
                return StatusCode(404, e.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Contacte al administrador");
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        [HttpPost]
        public IActionResult Create(MovimientoDeStockDto unMovimiento)
        {
            try
            {
                if (unMovimiento == null)
                {
                    throw new ArgumentException("Los valores enviados son incorrectos");
                }
                if (unMovimiento.articuloId == null)
                {
                    throw new ArticuloDeMovimientoInvalidoException();
                }
                if (unMovimiento.ejecutorEmail == null)
                {
                    throw new RolUsuarioInvalidoException();
                }
                if (unMovimiento.cantidad == null||unMovimiento.cantidad>ParametrosGenerales.cantMaxPorMovimiento||unMovimiento.cantidad<=0)
                {
                    throw new CantidadInvalidaException();
                }
                MovimientoDeStock movimiento = new MovimientoDeStock()
                {
                    articulo = _obtenerArticulo.Ejecutar(unMovimiento.articuloId),
                    tipo = _obtenerTipo.Ejecutar(unMovimiento.tipoId),
                    cantidad = unMovimiento.cantidad,
                    ejecutor = _obtenerUsuarioDesdeEmail.Ejecutar(unMovimiento.ejecutorEmail),
                };
                if(movimiento.ejecutor.Discriminator != "Encargado")
                {
                    throw new RolUsuarioInvalidoException();
                }
                movimiento.Validar();
                _altaMovimiento.Ejecutar(movimiento);
                return StatusCode(201);
            }
            catch (ArgumentException e)
            {
                return StatusCode(400, e.Message);
            }
            catch (DominioExcpetion e)
            {
                return StatusCode(400, e.Message);
            }
            catch (RepositorioException e)
            {
                return StatusCode(400, e.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Contactese con el administrador");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        [HttpGet]
        [Route("FiltroXArtTipoPag")]
        public IActionResult FiltroXArtTipoPag(int idArticulo, int idTipo, int page)
        {
            try
            {
                return Ok(_getAllXArtTipoPag.Ejecutar(idArticulo, idTipo, page));
            }
            catch (NotFoundException e)
            {
                return StatusCode(204, e.Message);
            }
            catch (ArgumentNullRepositorioException e)
            {
                return StatusCode(204, e.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Contacte al administrador");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize]
        [HttpGet]
        [Route("FiltroXFecha")]
        public IActionResult GetPorFecha(string desdestr, string hastastr, int page)
        {
            try
            {
                var desde = DateTime.MinValue;
                var hasta = DateTime.MinValue;
                var okd = DateTime.TryParse(desdestr, out desde);
                var okh = DateTime.TryParse(hastastr, out hasta);
                return Ok(_obtenerMovimientosPorFecha.Ejecutar(desde, hasta, page));
            }
            catch (NotFoundException e)
            {
                return StatusCode(204, e.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Contacte al administrador");
            }
        }
    }
}
