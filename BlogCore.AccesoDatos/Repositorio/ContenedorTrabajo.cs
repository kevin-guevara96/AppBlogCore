using AppBlogCore.Data;
using BlogCore.AccesoDatos.Repositorio.IRepositorio;
using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.AccesoDatos.Repositorio
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;

        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Categoria = new CategoriaRepositorio(_db);
            Articulo = new ArticuloRepositorio(_db);
            Slider = new SliderRepositorio(_db);
            Usuario = new UsuarioRepositorio(_db);
        }

        public ICategoriaRepositorio Categoria { get; private set; }
        public IArticuloRepositorio Articulo { get; private set; }
        public ISliderRepositorio Slider { get; private set; }
        public IUsuarioRepositorio Usuario { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
