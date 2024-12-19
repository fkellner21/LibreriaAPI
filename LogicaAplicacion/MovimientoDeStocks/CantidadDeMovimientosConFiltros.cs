using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.IntefacesServicios;
using LogicaDeNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.MovimientoDeStocks
{
    public class CantidadDeMovimientosConFiltros: IObtenerCantidadTotalDosFiltros<MovimientoDeStock>
    {
        IRepositorioMovimientoDeStock _repositorioMovimientos;
        public CantidadDeMovimientosConFiltros(IRepositorioMovimientoDeStock repositorioMovimientos)
        {
            _repositorioMovimientos = repositorioMovimientos;
        }

        public int Ejecutar(int idArticulo, int idTipo)
        {
            return _repositorioMovimientos.GetCountFiltro(idArticulo, idTipo);
        }
    }
}
