using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models
{
    public class UsuarioModels
    {
        public int id { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }
        public string idTipoUsuario { get; set; }
    }
}
