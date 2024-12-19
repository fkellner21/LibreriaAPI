using LogicaDeNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio.InterfacesRepositorio
{
    public interface IRepositorioMovimientoDeStock
    {
        public void Add(MovimientoDeStock obj);
        public MovimientoDeStock GetById(int id);
        public IEnumerable<MovimientoDeStock> GetAll(int page);
        public IEnumerable<MovimientoDeStock> GetAllXArtTipoPagl(int idArticulo, int idTipo, int page);
        public IEnumerable<Articulo> GetPorFecha(DateTime desde, DateTime hasta, int page);
        public int GetCount();
        public int GetCountFiltro(int idArticulo, int idTipo);
        public int GetCountPorFecha(DateTime desde, DateTime hasta);
        public IEnumerable<Resultado> ResumenPorAnio();

    }
}
