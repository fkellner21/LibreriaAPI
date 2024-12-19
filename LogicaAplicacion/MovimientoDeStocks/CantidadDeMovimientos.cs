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
    public class CantidadDeMovimientos:IObtenerCantidadTotal<MovimientoDeStock>
    {
        IRepositorioMovimientoDeStock _repositorioMovimientos;
        public CantidadDeMovimientos(IRepositorioMovimientoDeStock repositorioMovimientos)
        {
            _repositorioMovimientos = repositorioMovimientos;
        }

        public int Ejecutar()
        {
            return _repositorioMovimientos.GetCount();
        }
    }
}
