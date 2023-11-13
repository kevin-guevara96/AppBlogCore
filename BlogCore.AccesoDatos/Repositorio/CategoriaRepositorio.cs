using AppBlogCore.Data;
using BlogCore.AccesoDatos.Repositorio.IRepositorio;
using BlogCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlogCore.AccesoDatos.Repositorio
{
    internal class CategoriaRepositorio : Repositorio<Categoria>, ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _Db;

        public CategoriaRepositorio(ApplicationDbContext db) : base(db)
        {
            _Db = db;
        }

        public IEnumerable<SelectListItem> GetListaCategorias()
        {
            return _Db.Categorias.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.Id.ToString()
            }
            );
        }

        public void Update(Categoria categoria)
        {
            var objDesdeDb = _Db.Categorias.FirstOrDefault(s => s.Id == categoria.Id);
            objDesdeDb.Nombre = categoria.Nombre;
            objDesdeDb.Orden = categoria.Orden;

            _Db.SaveChanges();
        }
    }
}
