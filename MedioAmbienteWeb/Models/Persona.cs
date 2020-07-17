using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedioAmbienteWeb.Models
{
    public class Persona
    {
        public Guid Id { get; set; }
        [Required]

        public string Nombre { get; set; }
        [Required]

        public string Apellido { get; set; }

        public Celular Celular { get; set; }

        public byte[] FotografiaPerfil { get; set; }
        [NotMapped]

        public string FotografiaBase64 { get; set; }
    }
}
