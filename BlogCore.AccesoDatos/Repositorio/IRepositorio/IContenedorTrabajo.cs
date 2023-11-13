using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.AccesoDatos.Repositorio.IRepositorio
{
    public interface IContenedorTrabajo : IDisposable
    {
        ICategoriaRepositorio Categoria {  get; }
        //Aquí se deben de ir agregando los diferentes respositorios
        IArticuloRepositorio Articulo { get; }

        ISliderRepositorio Slider { get; }
        IUsuarioRepositorio Usuario { get; }

        void Save();
    }
}
