using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models
{
    public class VeterinariosModels
    {
        public int id { get; set; }
        public string razonSocial { get; set; }
        public string direccion { get; set; }
        public string horarioAtencion { get; set; }
        public string internacion { get; set; }
        public string observaciones { get; set; }
    }
}
