using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio.IntefacesServicios
{
    public interface IObtenerCantidadTotalDosFiltros<T>
    {
        public int Ejecutar(int primero, int segundo);
    }
}
