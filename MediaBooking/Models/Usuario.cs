using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBooking.Models
{
    public class Usuario
    {
        public long Id_user { get; set; }
        public string Nombre_user { get; set; }

        public string Apellido_user { get; set; }

        public string Correo_user { get; set; }

        public string Telefono_user { get; set; }

        public string Direccion_user { get; set; }

        public string Contrasena_user { get; set; }
    }
}
