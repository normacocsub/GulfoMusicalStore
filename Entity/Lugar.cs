using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Lugar
    {
        public int Codigo { get; set; }
        public string Ciudad { get; set; }
        public Barrio Barrio { get; set; }
        private IList<Barrio> Barrios { get; set; }

        public Lugar()
        {
            Barrios = new List<Barrio>();
        }
        public void AgregarBarrios(Barrio barrio)
        {
            Barrio = barrio;
            Barrio.Lugar = this;
            Barrios.Add(barrio);
        }
    }
}
