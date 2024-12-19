using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.IntefacesServicios;
using LogicaDeNegocio.InterfacesRepositorio;


namespace LogicaAplicacion.MovimientoDeStocks
{
    public class ObtenerMovimientosPorFecha : IObtenerPorFecha<Articulo>
    {
        IRepositorioMovimientoDeStock _repositorioMovimientoDeStock;
        public ObtenerMovimientosPorFecha(IRepositorioMovimientoDeStock repositorioMovimientoDeStock)
        {
            _repositorioMovimientoDeStock = repositorioMovimientoDeStock;
        }
        public IEnumerable<Articulo> Ejecutar(DateTime desde, DateTime hasta, int page)
        {
            return _repositorioMovimientoDeStock.GetPorFecha(desde,hasta, page);
        }
    }
}
