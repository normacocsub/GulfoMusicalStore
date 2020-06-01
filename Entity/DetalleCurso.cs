using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleCurso
    {
        public Factura Factura { get; set; }
        public Curso Curso { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Precio { get; set; }
        public int Unidades { get; set; }
        public DetalleCurso(Curso curso)
        {
            Curso = curso;    
        }
    }
}
