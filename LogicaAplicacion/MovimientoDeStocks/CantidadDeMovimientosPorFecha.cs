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
    public class CantidadDeMovimientosPorFecha:IObtenerCantidadPorFecha<Articulo>
    {
        IRepositorioMovimientoDeStock _repositorioMovimientos;
        public CantidadDeMovimientosPorFecha(IRepositorioMovimientoDeStock repositorioMovimientos)
        {
            _repositorioMovimientos = repositorioMovimientos;
        }

        public int Ejecutar(DateTime desde, DateTime hasta)
        {
            return _repositorioMovimientos.GetCountPorFecha(desde, hasta);
        }
    }
}
