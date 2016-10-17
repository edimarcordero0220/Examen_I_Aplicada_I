using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string FechaNacimiento { get; set; }
        public string limiteCredit { get; set; }

        public Usuarios()
        {
                
        }
    }
}
