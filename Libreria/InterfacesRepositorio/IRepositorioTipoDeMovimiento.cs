using LogicaDeNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio.InterfacesRepositorio
{
    public interface IRepositorioTipoDeMovimiento
    {
        public void Add(TipoDeMovimiento obj);
        public void Delete(int id);
        public void Update(int id, TipoDeMovimiento obj);
        public TipoDeMovimiento GetById(int id);
        public IEnumerable<TipoDeMovimiento> GetAll();
    }
}
