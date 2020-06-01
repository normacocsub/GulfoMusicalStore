using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Barrio Barrio { get; set; }
        public Lugar Lugar { get; set; }
        public Factura Factura { get; set; }
        public IList<Factura> Facturas { get; set; }
        public Cliente()
        {
              
        }

        public Cliente(string cedula,string primernombre,string segundonombre,string primerapellido,string segundoapellido,string correo,string telefono)
        {
            Cedula = cedula;
            PrimerNombre = primernombre;
            SegundoNombre = segundonombre;
            PrimerApellido = primerapellido;
            SegundoApellido = segundoapellido;
            Correo = correo;
            Telefono = telefono;
        }

        public void AgregarFactura(Factura factura)
        {
            Factura = factura;
            Facturas.Add(Factura);
        }

        public void AgregarLugar(Lugar lugar)
        {
            Lugar = lugar;
        }

        public void AgregarBarrio(Barrio barrio)
        {
            Barrio = barrio;
        }
    }
}
