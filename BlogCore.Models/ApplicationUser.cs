using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El dirección es obligatorio")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El entidad es obligatoria")]
        public string Entidad { get; set; }
        [Required(ErrorMessage = "El pais es obligatorio")]
        public string Pais { get; set; }

    }
}
