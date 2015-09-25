using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public int IdSociedad { get; set; }
        public string PassUsuario { get; set; }
        public string NomUsuario { get; set; }
    }
}