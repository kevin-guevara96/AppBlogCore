using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BlogCore.AccesoDatos.Repositorio.IRepositorio
{
    public interface IArticuloRepositorio : IRepositorio<Articulo>
    {
        void Update(Articulo articulo);
    }
}
