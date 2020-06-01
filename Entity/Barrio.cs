using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Barrio
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public Lugar Lugar { get; set; }
    }
}
