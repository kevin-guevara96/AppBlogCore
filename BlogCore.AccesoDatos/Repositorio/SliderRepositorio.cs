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
    internal class SliderRepositorio : Repositorio<Slider>, ISliderRepositorio
    {
        private readonly ApplicationDbContext _Db;

        public SliderRepositorio(ApplicationDbContext db) : base(db)
        {
            _Db = db;
        }


        public void Update(Slider slider)
        {
            var objDesdeDb = _Db.Sliders.FirstOrDefault(s => s.Id == slider.Id);
            objDesdeDb.Nombre = slider.Nombre;
            objDesdeDb.Estado = slider.Estado;
            objDesdeDb.UrlImagen = slider.UrlImagen;

            //_db.SaveChanges();
        }

    }
}
