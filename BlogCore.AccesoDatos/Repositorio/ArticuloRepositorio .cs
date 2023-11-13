using AppBlogCore.Data;
using BlogCore.AccesoDatos.Repositorio.IRepositorio;
using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BlogCore.AccesoDatos.Repositorio
{
    internal class ArticuloRepositorio : Repositorio<Articulo>, IArticuloRepositorio
    {
        private readonly ApplicationDbContext _Db;

        public ArticuloRepositorio(ApplicationDbContext db) : base(db)
        {
            _Db = db;
        }       

        public void Update(Articulo articulo)
        {
            var objDesdeDb = _Db.Articulos.FirstOrDefault(s => s.Id == articulo.Id);
            objDesdeDb.Nombre = articulo.Nombre;
            objDesdeDb.Descripcion = articulo.Descripcion;
            objDesdeDb.UrlImagen = articulo.UrlImagen;
            objDesdeDb.CategoriaId = articulo.CategoriaId;

            //_db.SaveChanges();
        }
    }
}
