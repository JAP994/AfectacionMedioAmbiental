using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedioAmbienteWeb.ViewModels
{
    public class PersonaViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = @"El ""Apellido"" es obligatorio:")]

        public string Nombre { get; set; }
        [Required]
        [DisplayName("El Apellido")]
        public string Apellido { get; set; }

        [DisplayName("Su Fotografia")]
        public IFormFile FotografiaPerfil { get; set; }

    }
}
