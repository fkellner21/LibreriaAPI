﻿using LogicaDeNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio.InterfacesRepositorio
{
    public interface IRepositorioArticulo
    {
        public Articulo GetById(int id);
        public IEnumerable<Articulo> GetAll();
    }
}
