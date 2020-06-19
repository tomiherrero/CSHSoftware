using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Models
{
    public class UsuarioModels
    {
        public int id { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }
        public int idTipoUsuario { get; set; }
        [ForeignKey("idTipoUsuario")]
        public virtual TipoUsuarioModels TipoUsuarioModels { get; set; }
    }
}
