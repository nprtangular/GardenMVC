using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demomvc2.Models
{
    public class UsuarioLista
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
    }
}