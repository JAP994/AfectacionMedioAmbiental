using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MedioAmbienteWeb.Models
{
    public class Persona
    {
        public Guid Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required(ErrorMessage =@"El ""Apellido"" es obligatorio:")]
        [DisplayName("El Apellido")]
        public string Apellido { get; set; }
        public Celular Celular { get; set; }

    }
}
