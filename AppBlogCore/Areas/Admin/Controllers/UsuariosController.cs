using BlogCore.AccesoDatos.Repositorio.IRepositorio;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;


namespace AppBlogCore.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UsuariosController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public UsuariosController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //Opción 1; Obtener todos los usuarios
            //return View(_contenedorTrabajo.Usuario.GetAll());

            //Opción 2: Obtener todos los usuarios menos el que esté logueado, para no bloquearse asi mismo
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var usarioActual = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            return View(_contenedorTrabajo.Usuario.GetAll(u => u.Id != usarioActual.Value));
        }

        [HttpGet]
        public IActionResult Bloquear(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _contenedorTrabajo.Usuario.BloquearUsuario(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Desbloquear(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _contenedorTrabajo.Usuario.DesbloquearUsuario(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
