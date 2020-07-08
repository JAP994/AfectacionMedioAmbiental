using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiental.Models
{
    public class Persona
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public Celular Celular { get; set; }


    }
}
